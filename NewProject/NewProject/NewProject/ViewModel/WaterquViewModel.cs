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
    public class WaterquViewModel : ViewModelBase
    {
        private IEnumerable<RiceGrowingAdvisor> Waterqudetail;
        public WaterquViewModel()
        {
            var DB = new Databasemain();
            Waterqudetail = DB.GetRGA();

        }
   
        public IEnumerable<RiceGrowingAdvisor> WaterquDetail
        {
            get
            {
                return this.Waterqudetail;
            }
            set
            {
                this.Waterqudetail = value; RaisePropertyChanged(() => WaterquDetail);
            }
        }

    }


}
