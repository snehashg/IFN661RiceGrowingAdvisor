using System;
using System.Collections.Generic;
using System.Linq;
using SQLite;
using Xamarin.Forms;
using SQLitePCL;

namespace NewProject
{
    public class Fertilizer
    {
        public SQLiteConnection Fdb;

        public Fertilizer()
        {
            Fdb = DependencyService.Get<ISQLite>().GetConnection();
            Fdb.CreateTable<FertilizerAdvisor>();
            FertilizerAdvisorInit(Fdb);
        }

        public IEnumerable<FertilizerAdvisor> GetFart()
        {
            return (from f in Fdb.Table<FertilizerAdvisor>()
                    select f).ToList();
        }

        public void FertilizerAdvisorInit(SQLiteConnection Fdb)
        {
            // Create DB table for fertilizer advisor
            Fdb.DropTable<FertilizerAdvisor>();
            Fdb.CreateTable<FertilizerAdvisor>();

            var NewFart = new FertilizerAdvisor();
            NewFart.FID = 1;
            NewFart.Nitro = 90;
            NewFart.Phos = 6;
            NewFart.Pota = 4;
            NewFart.Urea = 20;
            NewFart.AN = 40;
            NewFart.AS = 40;
            Fdb.Insert(NewFart);
        }
    }
}

