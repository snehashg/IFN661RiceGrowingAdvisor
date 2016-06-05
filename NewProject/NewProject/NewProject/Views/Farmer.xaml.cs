using NewProject.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace NewProject.Views
{
    public partial class Farmer : ContentPage
    {
        FarmerviewModel vm1;
        public Farmer()
        {
            Model.Demo dem1 = FarmerviewModel.GetDemo();
            vm1 = new FarmerviewModel(dem1);
            BindingContext = vm1;
            InitializeComponent();
        }

       
        public void OnButtonClicked1(Object o, EventArgs e)
        {
            Navigation.PushAsync(new Waterlevel());
        }
        public void OnButtonClicked3(Object o, EventArgs e)
        {
            Navigation.PushAsync(new SoilMOIS());
        }
        public void OnButtonClicked2(Object o, EventArgs e)
        {
            Navigation.PushAsync(new Waterquality());
        }
        public void OnButtonClicked4(Object o, EventArgs e)
        {
            Navigation.PushAsync(new NPK());
        }
        public void OnButtonClicked5(Object o, EventArgs e)
        {
            Navigation.PushAsync(new SoilTemperature());
        }
        public void OnButtonClicked6(Object o, EventArgs e)
        {
            Navigation.PushAsync(new Humidity());
        }
        
    }
}
