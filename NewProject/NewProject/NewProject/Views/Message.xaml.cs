using NewProject.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace NewProject.Views
{
    public partial class Message : ContentPage
    {
        public Message()
        {
            InitializeComponent();
            BindingContext = new MessageViewModel();
        }
        void OnButtonClicked(object sender, EventArgs args)
        {
            Navigation.PushAsync(new FertilizerSuggestion());
        }
        void Onclickedicon1(object sender, EventArgs args)
        {
            Navigation.PushAsync(new NewProject.Views.MainPage());
        }
    }
}
