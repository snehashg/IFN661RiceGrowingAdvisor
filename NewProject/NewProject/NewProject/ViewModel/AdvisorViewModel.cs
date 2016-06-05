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
    public class AdvisorViewModel : ViewModelBase
    {
        private IEnumerable<RiceGrowingAdvisor> Adviosrdetail;
        public AdvisorViewModel()
        {
            var DB = new Databasemain();
            Adviosrdetail = DB.GetRGA();

        }
        //private String _humdetail;
        // public string NPK { get { return _npk; } set { _npk = value; RaisePropertyChanged(() => NPK); } }
        public IEnumerable<RiceGrowingAdvisor> AdviosrDetail
        {
            get
            {
                return this.Adviosrdetail;
            }
            set
            {
                this.Adviosrdetail = value; RaisePropertyChanged(() => AdviosrDetail);
            }
        }

    }


}
