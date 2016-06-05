using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;
using GalaSoft.MvvmLight;
using System.Diagnostics;

namespace NewProject.ViewModel
{
    public class SoilMOISViewModel : ViewModelBase
    {
        private IEnumerable<RiceGrowingAdvisor> Soilmoisdetail;
        public SoilMOISViewModel()
        {
            var DB = new Databasemain();
            Soilmoisdetail = DB.GetRGA();

        }
      
        public IEnumerable<RiceGrowingAdvisor> SoilmoisDetail
        {
            get
            {
                return this.Soilmoisdetail;
            }
            set
            {
                this.Soilmoisdetail = value; RaisePropertyChanged(() => SoilmoisDetail);
            }
        }

    }


}
