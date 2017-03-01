using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using XF_CafeNomad.Service;
using ImageCircle.Forms.Plugin.Abstractions;

namespace XF_CafeNomad.View
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var t = Task.Run(() =>
            {
                CafeInfor cafeinfor = new CafeInfor();
                return cafeinfor.GetShopsAsync();
            });

            SuggestShopList.ItemsSource = t.Result;
        }
    }
}
