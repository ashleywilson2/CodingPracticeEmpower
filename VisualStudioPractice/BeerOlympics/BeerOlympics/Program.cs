using System;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using System.Data.SqlClient;

namespace BeerOlympics
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Projects\Empower\CodingPracticeEmpower\VisualStudioPractice\BeerOlympics\ContestantInfo\";
            var fileSpace = new FileSystemDatabase(@"C:\Projects\Empower\CodingPracticeEmpower\VisualStudioPractice\BeerOlympics\ContestantInfo\");
            var database = new SqlDatabase("Server=.\\S2017E;Database=BeerOlympics;Trusted_Connection=True;");

            //var contestant1 = new Contestant("Ashley", 15, "Murica", 100, "Dizzy Bat");
            //var contestant2 = new Contestant("Justin", 25, "Murica", 100, "Slip N Slide");
            //var contestant3 = new Contestant("Trafton", 25, "Murica", 100, "Shotgun N Cornhole");
            //var contestant4 = new Contestant("Jessie", 15, "Murica", 100, "Dizzy Bat");
            //var contestant5 = new Contestant("Kelly", 20, "Murica", 100, "Shotgun N Cornhole");

           
        }

        static void AddContestant(IDatabase database, Contestant contestant)
        {
            database.Create(contestant);
        }

        static void UpdateContestant(IDatabase database, Contestant contestant)
        {
            database.Update(contestant);
        }

        static void DeleteContestant(IDatabase database, int Id)
        {
            database.Delete(Id);
        }
    }
}
