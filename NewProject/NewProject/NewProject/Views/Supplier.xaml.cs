using NewProject.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace NewProject.Views
{
    public partial class Supplier : ContentPage
    {
        public Supplier()
        {
            Model.Demo dem1 = SupplierViewModel.GetDemo();
           SupplierViewModel vm1 = new SupplierViewModel(dem1);
            BindingContext = vm1;
            InitializeComponent();
        }
        public void OnButtonClick4(Object o, EventArgs e)
        {
            Navigation.PushAsync(new FertilizerMain());
        }
        public void OnButtonClick5(Object o, EventArgs e)
        {
            Navigation.PushAsync(new Pesticide());
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
