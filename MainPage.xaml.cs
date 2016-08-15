using SmartAir.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Data.Json;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.Storage.Streams;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace SmartAir
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : BindablePage
    {
        private DispatcherTimer _timer = new DispatcherTimer();
        private DispatcherTimer m_timer = new DispatcherTimer();

        private int i=0;
        private bool nav = true;
        private const int maxi = 10;
        public MainPage()
        {
            this.InitializeComponent();
            _timer_Tick(null, null);
            _timer.Interval = TimeSpan.FromSeconds(120);
            _timer.Tick += _timer_Tick;
            m_timer.Interval = TimeSpan.FromSeconds(1);
            m_timer.Tick += M_timer_Tick;

            this.Loaded += MainPage_Loaded;
        }

        private async void M_timer_Tick(object sender, object e)
        {
            if (nav)
            {
                i++;
            }else
            {
                i--;
            }
            if(i > maxi || i < 1)
            {
                nav = !nav;
            }
            ApplyFilter(i);
            this.OnPropertyChanged(nameof(LastUpdatedDisplay));
        }
        #region image
        WriteableBitmap wb;
        WriteableBitmap[] wbs = new WriteableBitmap[maxi + 2];
        private async void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            //StorageFile file = await StorageFile.GetFileFromApplicationUriAsync(new Uri("ms-appx:///b.png"));
            StorageFile file = await StorageFile.GetFileFromApplicationUriAsync(new Uri("ms-appx:///Images/2.jpg"));

            wb = new WriteableBitmap(1000, 1000);
            bg.ImageSource = wb;

            // Ensure a file was selected
            if (file != null)
            {
                // Set the source of the WriteableBitmap to the image stream
                using (IRandomAccessStream fileStream = await file.OpenAsync(FileAccessMode.Read))
                {
                    try
                    {
                        await wb.SetSourceAsync(fileStream);
                    }
                    catch (TaskCanceledException)
                    {
                        // The async action to set the WriteableBitmap's source may be canceled if the user clicks the button repeatedly
                    }
                }
            }

            // 初始值
            ApplyFilter(i);
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="level">[0,40]</param>
        async void ApplyFilter(float level)
        {
            if(wbs[i] != null)
            {
                bg.ImageSource = wbs[i];
                return;
            }

            // 拷贝
            WriteableBitmap new_bitmap = await Utility.BitmapClone(wb);

            // 添加高斯滤镜效果
            MyImage mi = new MyImage(new_bitmap);
            GaussianBlurFilter filter = new GaussianBlurFilter();
            filter.Sigma = level;
            filter.process(mi);

            // 图片添加完滤镜的 int[] 数组
            int[] array = mi.colorArray;

            // byte[] 数组的长度是 int[] 数组的 4倍
            byte[] result = new byte[array.Length * 4];

            // 通过自加，来遍历 byte[] 数组中的值
            int j = 0;
            for (int i = 0; i < array.Length; i++)
            {
                // 同时把 int 值中 a、r、g、b 的排列方式，转换为 byte数组中 b、g、r、a 的存储方式 
                result[j++] = (byte)(array[i]);       // Blue
                result[j++] = (byte)(array[i] >> 8);  // Green
                result[j++] = (byte)(array[i] >> 16); // Red
                result[j++] = (byte)(array[i] >> 24); // Alpha
            }

            // Open a stream to copy the image contents to the WriteableBitmap's pixel buffer 
            using (Stream stream = new_bitmap.PixelBuffer.AsStream())
            {
                await stream.WriteAsync(result, 0, result.Length);
            }
            wbs[i] = new_bitmap;
            bg.ImageSource = new_bitmap;// 把 WriteableBitmap 对象赋值给 Image 控件

            // 用像素缓冲区的数据绘制图片
            //new_bitmap.Invalidate();
        }
        #endregion

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            _timer.Start();
            m_timer.Start();

          }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            _timer.Stop();
            m_timer.Stop();

            base.OnNavigatedFrom(e);
        }

        private async void _timer_Tick(object sender, object e)
        {
            using (HttpClient httpclient = new HttpClient())
            {

                httpclient.DefaultRequestHeaders.Accept.Clear();
                httpclient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpclient.BaseAddress = new Uri("https://seed-pi-data.run.aws-usw02-pr.ice.predix.io/");
                try
                {
                    HttpResponseMessage response = await httpclient.GetAsync("item/dl");
                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();
                          JsonArray users = JsonArray.Parse(responseBody);
                        for(uint i = 0; i < users.Count; i++)
                        {
                            String name = users.GetObjectAt(i).GetNamedString("label");
                            String val = users.GetObjectAt(i).GetNamedString("value");
                            switch (name)
                            {
                                
                                case "temperature":
                                    temperature = val;
                                    break;
                                case "humidity":
                                    humidity = val;
                                    break;
                                case "pm2.5":
                                    pm25 = val;
                                    break;
                            }
                        }
                        

                    }

                }
                catch (Exception ex)
                {
                    //await new MessageDialog(ex.Message).ShowAsync();
                }

                maxItem = new Item();
                minItem = new Item();

                try
                {
                    HttpResponseMessage response = await httpclient.GetAsync("item/max/dl");
                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();
                        JsonArray users = JsonArray.Parse(responseBody);
                        for (uint i = 0; i < users.Count; i++)
                        {
                            String name = users.GetObjectAt(i).GetNamedString("label");
                            String val = users.GetObjectAt(i).GetNamedString("value");
                            switch (name)
                            {

                                case "temperature":
                                    maxItem.Temperature = val;
                                    break;
                                case "humidity":
                                    maxItem.Humidity = val;
                                    break;
                                case "pm2.5":
                                    maxItem.Pm25 = val;
                                    break;
                                case "pm1.0":
                                    maxItem.Pm1 = val;
                                    break;
                                case "pm10":
                                    maxItem.Pm10 = val;
                                    break;
                            }
                        }


                    }

                }
                catch (Exception ex)
                {
                    //await new MessageDialog(ex.Message).ShowAsync();
                }

                try
                {
                    HttpResponseMessage response = await httpclient.GetAsync("item/min/dl");
                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();
                        JsonArray users = JsonArray.Parse(responseBody);
                        for (uint i = 0; i < users.Count; i++)
                        {
                            String name = users.GetObjectAt(i).GetNamedString("label");
                            String val = users.GetObjectAt(i).GetNamedString("value");
                            switch (name)
                            {

                                case "temperature":
                                    minItem.Temperature = val;
                                    break;
                                case "humidity":
                                    minItem.Humidity = val;
                                    break;
                                case "pm2.5":
                                    minItem.Pm25 = val;
                                    break;
                                case "pm1.0":
                                    minItem.Pm1 = val;
                                    break;
                                case "pm10":
                                    minItem.Pm10 = val;
                                    break;
                            }
                        }


                    }

                }
                catch (Exception ex)
                {
                    //await new MessageDialog(ex.Message).ShowAsync();
                }


            }

                      


            this.OnPropertyChanged(nameof(TemperatureDisplay));
            this.OnPropertyChanged(nameof(HumidityDisplay));
            
            this.OnPropertyChanged(nameof(Pm25Display));

            this.OnPropertyChanged(nameof(Maxmsg));
            this.OnPropertyChanged(nameof(Minmsg));

           // i++;
            //if (i > 40) i = 0;
            //if (i % 3 == 0) bg.ImageSource = new BitmapImage(new Uri("ms-appx://SmartAir/Images/1.jpeg"));
            //if (i % 3 == 1) bg.ImageSource = new BitmapImage(new Uri("ms-appx://SmartAir/Images/2.jpg"));
            //if (i % 3 == 2) bg.ImageSource = new BitmapImage(new Uri("ms-appx://SmartAir/Images/3.png"));

            //ApplyFilter(i);
        }

        private string temperature = "0";
        private string humidity = "0";
        private string pm25 = "0";
        private Item maxItem,minItem;


        public string Minmsg
        {
            get
            {
                if (minItem != null)
                {
                    return string.Format("{0} % RH           {1} °C          {2} μg/m³", minItem.Humidity, minItem.Temperature,  minItem.Pm25); ;
                }
                return "";
            }
        }

        public string Maxmsg
        {
            get
            {
                if (maxItem != null)
                {
                    return string.Format("{0} % RH           {1} °C          {2} μg/m³",  maxItem.Humidity, maxItem.Temperature, maxItem.Pm25); ;
                }
                return "";
            }
        }
        public string TemperatureDisplay
        {
            get
            {
                return string.Format("{0:0.0} °C", float.Parse(temperature));
            }
        }

        public string HumidityDisplay
        {
            get { 

                return string.Format("{0:0.0}% RH", float.Parse(humidity));
            }
        }

        public string Pm25Display
        {
            get
            {
                return string.Format("{0} μg/m³", pm25);
            }
        }

        public string LastUpdatedDisplay
        {
            get { return DateTime.Now.ToString(); }
        }

        private async void queryItem(string url, Item item)
        {
            if(item == null)
            {
                item = new Item();
            }
            using (HttpClient httpclient = new HttpClient())
            {

                httpclient.DefaultRequestHeaders.Accept.Clear();
                httpclient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpclient.BaseAddress = new Uri("https://seed-pi-data.run.aws-usw02-pr.ice.predix.io/");
                try
                {
                    HttpResponseMessage response = await httpclient.GetAsync(url);
                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();
                        JsonArray users = JsonArray.Parse(responseBody);
                        for (uint i = 0; i < users.Count; i++)
                        {
                            String name = users.GetObjectAt(i).GetNamedString("label");
                            String val = users.GetObjectAt(i).GetNamedString("value");
                            switch (name)
                            {

                                case "temperature":
                                    item.Temperature = val;
                                    break;
                                case "humidity":
                                    item.Humidity = val;
                                    break;
                                case "pm2.5":
                                    item.Pm25 = val;
                                    break;
                                case "pm1.0":
                                    item.Pm1 = val;
                                    break;
                                case "pm10":
                                    item.Pm10 = val;
                                    break;
                            }
                        }


                    }

                }
                catch (Exception ex)
                {
                    //await new MessageDialog(ex.Message).ShowAsync();
                }


            }
           }
        
        private async void  queryCloud()
        {
            Uri uri = new Uri("https://seed-pi-data.run.aws-usw02-pr.ice.predix.io/item/dl");
            using (HttpClient httpclient = new HttpClient())
            {

                //httpclient.BaseAddress = new Uri("https://seed-pi-data.run.aws-usw02-pr.ice.predix.io/");
                httpclient.DefaultRequestHeaders.Accept.Clear();
                httpclient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //httpclient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/51.0.2704.106 Safari/537.36");
                //httpclient.DefaultRequestHeaders.Add("Accept-Language", "en-US,en;q=0.8");
                /*
                HttpWebRequest webrequest = (HttpWebRequest)HttpWebRequest.Create(uri);
                httpclient.DefaultRequestHeaders.Add("name", "value");
                httpclient.DefaultRequestHeaders.Accept.TryParseAdd("application/json");
                webrequest.Method = "GET";
                HttpWebResponse response =  webrequest.GetResponseAsync();
                StreamReader streamReader1 = new StreamReader(response.GetResponseStream());
                */

                try
                {

                    HttpResponseMessage response = await httpclient.GetAsync(uri);
                    /*if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();
                        tmp = responseBody;
                    }*/

                    //HttpResponseMessage response = await httpclient.GetAsync("api/ms/piv/temperature");
                    if (response.EnsureSuccessStatusCode().StatusCode.ToString().ToLower() == "ok")
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();
                        //tmp = responseBody;
                        await new MessageDialog(responseBody).ShowAsync();
                    }

                }
                catch (Exception ex)
                {
                    //await new MessageDialog(ex.Message).ShowAsync();
                }
            }
        }

 
        class Item
        {
            public string Temperature { get; set; }
            public string Humidity { get; set; }
            public string Pm25 { get; set; }
            public string Pm10 { get; set; }

            public string Pm1 { get; set; }
        }


    }

  
}
