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
    public class FarmerviewModel : ViewModelBase
    {
        public FarmerviewModel(Demo demo)
        {
            Farmer = demo.farmer;
        }

        private string _farmer;
        public string Farmer { get { return _farmer; } set { _farmer = value; RaisePropertyChanged(() => Farmer); } }
         

        public static NewProject.Model.Demo GetDemo()
        {
            var demo = new NewProject.Model.Demo()
            {
                
                farmer = "farmer HomePage",
               
            };
            return demo;
        }
    }
}
