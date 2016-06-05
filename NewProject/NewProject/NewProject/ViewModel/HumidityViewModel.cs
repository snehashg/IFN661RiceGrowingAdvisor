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
    public class HumdityViewModel : ViewModelBase
    {
        private IEnumerable<RiceGrowingAdvisor> Humdetail;
        public HumdityViewModel()
        {
            var DB = new Databasemain();
            Humdetail = DB.GetRGA();

        }
        
        public IEnumerable<RiceGrowingAdvisor> HumDetail
        {
            get
            {
                return this.Humdetail;
            }
            set
            {
                this.Humdetail = value; RaisePropertyChanged(() => HumDetail);
            }
        }

    }


}
