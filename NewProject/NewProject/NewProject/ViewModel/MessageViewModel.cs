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
    public class MessageViewModel : ViewModelBase
    {
        private IEnumerable<RiceGrowingAdvisor> Mesgdetail;

        public MessageViewModel()
        {
            var DB = new Databasemain();
            Mesgdetail = DB.GetRGA();

        }

        public IEnumerable<RiceGrowingAdvisor> MesgDetail
        {
            get { return this.Mesgdetail; }
            set { this.Mesgdetail = value; RaisePropertyChanged(() => MesgDetail); }
        }
    }
}

