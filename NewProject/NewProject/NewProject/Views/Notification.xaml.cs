using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace NewProject.Views
{
    public partial class Notification : ContentPage
    {
        public Notification()
        {
            InitializeComponent();
        }
        void Onclickedicon1(object sender, EventArgs args)
        {
            Navigation.PushAsync(new NewProject.Views.MainPage());
        }
    }
}
