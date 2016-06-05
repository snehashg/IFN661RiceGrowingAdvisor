using System;
using SQLite;


namespace NewProject
{
    public class RiceGrowingAdvisor
    {
       
        
        public double StandardWL { get; set; }
        public double CurrentWL { get; set; }
        public int ContentMO { get; set; }
        public int SContentMO { get; set; }
        public int SContentNI { get; set; }
        public int ContentNI { get; set; }
        public int ContentPH { get; set; }
        public int SContentPH { get; set; }
        public string NpkTitle { get; set; }
        public int NValue { get; set; }
        public int PValue { get; set; }
        public int KValue { get; set; }
        public int fertilizer1 { get; set; }
        public int fertilizer2 { get; set; }
        public int fertilizer3 { get; set; }
        public float CurrentTemperature { get; set; }
        public float MinTemperature { get; set; }
        public string Suggestion { get; set; }
        public float MaxTemperature { get; set; }
        public string Suggestion1 { get; set; }
        public string Suggestion2 { get; set; }
        public string Suggestion3 { get; set; }
        public string Suggestion4 { get; set; }
        public string Suggestion5 { get; set; }
        public int PerciValue { get; set; }
        public int HumValue { get; set; }
        public int WindValue { get; set; }
        public int StandardMOI { get; set; }
        public int CurrentMOI { get; set; }
        public string PDIMG { get; set; }
        public string Message { get; set; }

    }
}
