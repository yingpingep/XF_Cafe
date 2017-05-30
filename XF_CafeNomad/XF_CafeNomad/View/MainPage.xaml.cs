using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using XF_CafeNomad.Service;
using XF_CafeNomad.Model;

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

            Button btn = new Button();
            btn.Text = "Click Me!";

            SuggestShopList.ItemsSource = t.Result;
        }

        private async void SuggestShopList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            CafeShop selectedItem = e.SelectedItem as CafeShop;
            await Navigation.PushAsync(new MapPage(selectedItem));
        }
    }
}
