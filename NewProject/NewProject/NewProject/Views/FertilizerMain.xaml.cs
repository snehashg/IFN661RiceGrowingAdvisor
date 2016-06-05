using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewProject.ViewModel;
using Xamarin.Forms;

namespace NewProject
{
    public partial class FertilizerMain : ContentPage
    {
        public FertilizerMain()
        {
            InitializeComponent();
            BindingContext = new FertilizerViewModel();
        }

        void OnButtonClicked(object sender, EventArgs args)
        {
            Navigation.PushAsync(new FertilizerSuggestion());
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

