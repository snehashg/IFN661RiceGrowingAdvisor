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
    public class SoilTemperatureViewModel : ViewModelBase
    {
        private IEnumerable<RiceGrowingAdvisor> SoilTempdetail;
        public SoilTemperatureViewModel()
        {
            var DB = new Databasemain();
            SoilTempdetail = DB.GetRGA();

        }

        public IEnumerable<RiceGrowingAdvisor> SoilTempDetail
        {
            get
            {
                return this.SoilTempdetail;
            }
            set
            {
                this.SoilTempdetail = value; RaisePropertyChanged(() => SoilTempDetail);
            }
        }

    }


}
