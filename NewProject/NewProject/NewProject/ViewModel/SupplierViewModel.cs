using GalaSoft.MvvmLight;
using NewProject.Model;
using NewProject.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject.ViewModel
{
    public class SupplierViewModel : ViewModelBase
    {
        public SupplierViewModel(Demo demo)
        {
            Supplier = demo.supplier;
        }

        private string _supplier;
        public string Supplier { get { return _supplier; } set { _supplier = value; RaisePropertyChanged(() => Supplier); } }


        public static NewProject.Model.Demo GetDemo()
        {
            var demo = new NewProject.Model.Demo()
            {

                supplier = "Supplier HomePage",

            };
            return demo;
        }
    }
}
