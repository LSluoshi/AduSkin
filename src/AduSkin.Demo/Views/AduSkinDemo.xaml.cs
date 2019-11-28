﻿using AduSkin.Controls.Metro;
using AduSkin.Demo.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AduSkin.Demo.Views
{
   /// <summary>
   /// AduSkinDemo.xaml 的交互逻辑
   /// </summary>
   public partial class AduSkinDemo : AduWindow
   {
      public AduSkinDemo()
      {
         InitializeComponent();

         DemoModel item = new DemoModel()
         {
            ID = 1,
            Name = " “ AduChat ” 极简聊天UI ",
            Cover = "http://m.qpic.cn/psb?/V12WtbKq4PLaCF/RS2rHkLeCVhVkNXaXT7LaeIC9aNE19yHsrQ6Fy0mdxU!/b/dLYAAAAAAAAA&bo=GgQEAxoEBAMDCSw!&rf=viewer_4",
            Link = "https://baidu.com",
            Likes = "99+",
            Shares = "99+",
            BlogDate = "November 3, 2019",
            Describe = "基于AduSkin 和 HandyControl，仿Win10菜单，聊天气泡，极致UI ！",
         };
         DemoList.Add(item);
         DemoModel item4 = new DemoModel()
         {
            ID = 1,
            Name = "“Maker Wallpaper” 让我们来见一见这款精心为您打造的视频桌面壁纸！",
            Cover = "http://dmskin.com/image/xxxx.png",
            Link = "https://baidu.com",
            Likes = "99+",
            Shares = "99+",
            BlogDate = "November 1, 2019",
            Describe = "At Maker Wallpaper we’re passionate about breaking boundaries and setting a new bar for player expectations. We believe that all gamers deserve to share beautiful, immersive experiences regardless of which platform they play on.",
         };
         DemoList.Add(item4);
         DemoModel item3 = new DemoModel()
         {
            ID = 1,
            Name = "“Shadow” 心理FM PC客户端, 众多贴心新功能等你去发现！",
            Cover = "http://b191.photo.store.qq.com/psb?/V12WtbKq4PLaCF/nQlvRpwSF72VutvTvmKvqhGyFXZrnz2B2dQTk436wdc!/b/dL8AAAAAAAAA&bo=VgUAA1YFAAMDCSw!&rf=viewer_4",
            Link = "https://baidu.com",
            Likes = "99+",
            Shares = "99+",
            BlogDate = "September 6, 2019",
            Describe = "Shadow 2.0 launched today with a bunch of fun new features. Most importantly - we’re now live on Steam so whether you and your friends play on a PC, Mac, iOS or Android, you can all Listen FM together.  Download link here: ",
         };
         DemoList.Add(item3);
         DemoModel item2 = new DemoModel()
         {
            ID = 1,
            Name = " “Super Evil” 一款独具匠心的音乐播放器！",
            Cover = "http://b191.photo.store.qq.com/psb?/V12WtbKq4PLaCF/qcNDwznfR2QbFMy96v53FD93ClzOuRbra6p.x0If4w8!/b/dL8AAAAAAAAA&bo=gAc4BIAHOAQDCSw!&rf=viewer_4",
            Link = "https://baidu.com",
            Likes = "99+",
            Shares = "99+",
            BlogDate = "August 1, 2019",
            Describe = "At Super Evil we’re passionate about breaking boundaries and setting a new bar for player expectations. We believe that all gamers deserve to share beautiful, immersive experiences regardless of which platform they play on.",
         };
         DemoList.Add(item2);
         DemoModel item1 = new DemoModel()
         {
            ID = 1,
            Name = "“AduMusic” QQ Music For WPF , 没想到你是这样的播放器！",
            Cover = "http://b301.photo.store.qq.com/psb?/V12WtbKq4PLaCF/XRG14p7ndKsURVgQHY1NfIeYYwEaQ3euaDhKuStSpTU!/b/dC0BAAAAAAAA&bo=QgfKA0IHygMDCSw!&rf=viewer_4",
            Link = "https://baidu.com",
            Likes = "99+",
            Shares = "99+",
            BlogDate = "12月 6, 2018",
            Describe = "At Super Evil we’re passionate about breaking boundaries and setting a new bar for player expectations. We believe that all gamers deserve to share beautiful, immersive experiences regardless of which platform they play on.",
         };
         DemoList.Add(item1);

         Demos.ItemsSource = DemoList;
         Carousels.ItemsSource = DemoList;
      }
      public ObservableCollection<DemoModel> DemoList { get; set; } = new ObservableCollection<DemoModel>();
   }
}