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
    public class FertilizerViewModel : ViewModelBase
    {
        private IEnumerable<FertilizerAdvisor> Fdetail;

        public FertilizerViewModel()
        {
            var DB = new Fertilizer();
            Fdetail = DB.GetFart();
        }

        public IEnumerable<FertilizerAdvisor> FDetail
        {
            get { return this.Fdetail; }
            set { this.Fdetail = value; }
        }
    }
}

