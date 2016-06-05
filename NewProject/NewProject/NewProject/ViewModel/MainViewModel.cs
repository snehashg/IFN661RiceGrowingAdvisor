
using GalaSoft.MvvmLight;
using System;

namespace MVVMPatern
{
  
    public class MainViewModel : ViewModelBase
    {
        
        public MainViewModel(NewProject.Model.Demo demo)
        {
            PageTitle = demo.title;
           
           
        }

        private string _title;
        public string PageTitle { get { return _title; } set { _title = value; RaisePropertyChanged(() => PageTitle);  }  }
       
       

        public static NewProject.Model.Demo GetDemo()
        {

            var demo = new NewProject.Model.Demo()
            {
                title = "Rice Growing Advisors",
                
               
            };
            return demo;
        }

    }
}