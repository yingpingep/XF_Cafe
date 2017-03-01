using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

using ImageCircle.Forms.Plugin.UWP;

namespace XF_CafeNomad.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();
            Xamarin.FormsMaps.Init("117PalmDboENQswr0Aef~D1ZWrDyHe3jqUdI2ZOSlWg~Alp_pY07cSBEUISJPcCikNRV3cnmM6q99ewE6yzCyB3oiwd5WKQblbtAvPZYyfQz");
            ImageCircleRenderer.Init();
            LoadApplication(new XF_CafeNomad.App());
        }
    }
}
