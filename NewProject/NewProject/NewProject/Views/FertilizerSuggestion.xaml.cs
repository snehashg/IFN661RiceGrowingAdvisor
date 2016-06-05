using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewProject.ViewModel;
using NewProject;
using Xamarin.Forms;

namespace NewProject
{
    public partial class FertilizerSuggestion : ContentPage
    {
        public FertilizerSuggestion()
        {
            InitializeComponent();
        }

        void OnButtonClicked(object sender, EventArgs args)
        {
            DisplayAlert("Alert", "Your suggestion has been sent.", "OK");
        }
    }
}

