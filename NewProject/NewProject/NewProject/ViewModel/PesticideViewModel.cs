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
    public class PesticideViewModel : ViewModelBase
    {
        private IEnumerable<RiceGrowingAdvisor> Pesticidedetail;
        public PesticideViewModel()
        {
            var DB = new Databasemain();
            Pesticidedetail = DB.GetRGA();

        }
        
        public IEnumerable<RiceGrowingAdvisor> PesticideDetail
        {
            get
            {
                return this.Pesticidedetail;
            }
            set
            {
                this.Pesticidedetail = value; RaisePropertyChanged(() => PesticideDetail);
            }
        }

    }


}
