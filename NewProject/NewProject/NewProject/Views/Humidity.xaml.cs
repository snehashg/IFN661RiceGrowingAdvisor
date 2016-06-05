using NewProject.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace NewProject.Views
{
    public partial class Humidity : ContentPage
    {
        public Humidity()
        {
            InitializeComponent();
            BindingContext = new HumdityViewModel();
        }
        void Onclickedicon1(object sender, EventArgs args)
        {
            Navigation.PushAsync(new NewProject.Views.MainPage());
        }
        void Onclickedicon2(object sender, EventArgs args)
        {
            Navigation.PushAsync(new NewProject.Views.Message());
        }
        void Onclickedicon3(object sender, EventArgs args)
        {
            Navigation.PushAsync(new NewProject.Views.Notification());
        }
    }
}
