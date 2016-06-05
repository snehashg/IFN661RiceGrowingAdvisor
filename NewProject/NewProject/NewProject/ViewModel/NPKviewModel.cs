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
    public class NPKViewModel : ViewModelBase
    {
        private IEnumerable<RiceGrowingAdvisor> NPKdetail;
        public NPKViewModel()
        {
            var DB = new Databasemain();
            NPKdetail = DB.GetRGA();

        }
        
        public IEnumerable<RiceGrowingAdvisor> NPKDetail
        {
            get
            {
                return this.NPKdetail;
            }
            set
            {
                this.NPKdetail = value; RaisePropertyChanged(() => NPKDetail);
            }
        }

    }


}
