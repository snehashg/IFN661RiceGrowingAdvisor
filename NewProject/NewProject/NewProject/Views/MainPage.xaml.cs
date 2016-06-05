using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace NewProject.Views
{
    public partial class MainPage : ContentPage
    {
        MVVMPatern.MainViewModel vm;
        public MainPage()
        {
            Model.Demo dem = MVVMPatern.MainViewModel.GetDemo();
            vm = new MVVMPatern.MainViewModel(dem);
            BindingContext = vm;

            InitializeComponent();
        }

       public void OnButtonClick1(Object o, EventArgs e)
        {
            Navigation.PushAsync(new Farmer());

            }
        
        public void OnButtonClick2(Object o, EventArgs e)
        {
            Navigation.PushAsync(new Advisor());
        }
        public void OnButtonClick3(Object o, EventArgs e)
        {
            Navigation.PushAsync(new Supplier());
        }
    }
}
