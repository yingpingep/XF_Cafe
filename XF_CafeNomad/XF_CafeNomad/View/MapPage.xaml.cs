using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Maps;
using XF_CafeNomad.Model;
using XF_CafeNomad.Service;

namespace XF_CafeNomad.View
{
    public partial class MapPage : ContentPage
    {        
        public MapPage(CafeShop selectedItem)
        {
            InitializeComponent();

            var position = new Position(selectedItem.latitude, selectedItem.longitude);
            var pin = new Pin
            {
                Type = PinType.Place,
                Position = position,
                Label = selectedItem.name,
                Address = selectedItem.address
            };

            CafeMap.Pins.Add(pin);
            CafeMap.MoveToRegion(MapSpan.FromCenterAndRadius(position, Distance.FromKilometers(5)));
        }
    }
}
