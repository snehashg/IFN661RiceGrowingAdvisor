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
    public class WaterlevelViewModel : ViewModelBase
    {
        private IEnumerable<RiceGrowingAdvisor> Waterlvdetail;
        public WaterlevelViewModel()
        {
            var DB = new Databasemain();
            Waterlvdetail = DB.GetRGA();

        }
        
        public IEnumerable<RiceGrowingAdvisor> WaterlvDetail
        {
            get
            {
                return this.Waterlvdetail;
            }
            set
            {
                this.Waterlvdetail = value; RaisePropertyChanged(() => WaterlvDetail);
            }
        }

    }


}
