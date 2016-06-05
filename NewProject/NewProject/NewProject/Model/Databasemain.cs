using System;
using System.Collections.Generic;
using System.Linq;
using SQLite;
using Xamarin.Forms;
using SQLitePCL;


namespace NewProject
{
    public class Databasemain
    {
       

        public SQLiteConnection DB;

        public Databasemain()
        {
            DB = DependencyService.Get<ISQLite>().GetConnection();

            RiceGrowingAdvisorInit(DB);
        }

        public IEnumerable<RiceGrowingAdvisor> GetRGA()
        {
            return (from t in DB.Table<RiceGrowingAdvisor>() select t).ToList();
        }

        public void RiceGrowingAdvisorInit(SQLiteConnection DB)
        {

            
            
                DB.DropTable<RiceGrowingAdvisor>();
                // DB.CreateTable<RiceGrowingAdvisor>();

            
            DB.CreateTable<RiceGrowingAdvisor>();
            var NewRGA = new RiceGrowingAdvisor();
            NewRGA.StandardWL = 2.5;
            NewRGA.NpkTitle = "NPK values for the soil";
            NewRGA.CurrentWL = 2;
            NewRGA.NValue = 70;
            NewRGA.PValue = 20;
            NewRGA.KValue = 10;
            NewRGA.fertilizer1 = 50;
            NewRGA.fertilizer2 = 25;
            NewRGA.fertilizer3 = 30;
            NewRGA.CurrentTemperature = 31;
            NewRGA.MinTemperature = 20;
            NewRGA.MaxTemperature = 27;
            NewRGA.Suggestion1 = "The use of Plant Residues";
            NewRGA.Suggestion2 = "Soil temperature is high use Organic Matter to reduce the temperature";
            NewRGA.Suggestion3 = "Current water level is  below to the Standard set, please irrigate more water!";
            NewRGA.Suggestion4 = "The gradual way to reduce ph level is to add fishes in the water storage!";
            NewRGA.Suggestion5 = "Increase the water level!";
            NewRGA.Suggestion = "It is suggested to use less water for irrigation since the humidity of air is high";
            NewRGA.PerciValue = 0;
            NewRGA.WindValue = 23;
            NewRGA.HumValue = 94;
            NewRGA.ContentMO = 6;
            NewRGA.ContentNI = 5;
            NewRGA.ContentPH = 6;
            NewRGA.SContentMO = 5;
            NewRGA.SContentNI = 4;
            NewRGA.SContentPH = 7;
            NewRGA.StandardMOI = 40;
            NewRGA.CurrentMOI = 30;
            NewRGA.PDIMG = "pd_1.png";
            NewRGA.Message = "Display the Messages recieved here";
            DB.Insert(NewRGA);





        }

        

    }
}

