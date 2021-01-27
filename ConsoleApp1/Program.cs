using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using PayaTest.Models;
namespace PayaTest
{
    class Program
    {

        string jsonResult = string.Empty;
        static void Main(string[] args)
        {
            DataParser dp = new DataParser();
            Films filmData = dp.ParseFilmData();

            Console.WriteLine("EpisodeId:" + '\t' + "Film Title");
            for (int f = 0; f < filmData.results.Length; f++) {
                Console.WriteLine(filmData.results[f].episode_id + ":" + '\t' + filmData.results[f].title);
            }

            string strInput = string.Empty;
            int EpisodeId = -1;
            do
            {
                Console.WriteLine();
                Console.Write("Enter the EpisodeId for the Film: ");
                strInput = Console.ReadLine();
                if (Int32.TryParse(strInput, out EpisodeId) && filmData.results.Where(k => k.episode_id == EpisodeId).Count() > 0)
                    break;
                else
                    Console.WriteLine("Please enter a valid Film EpisodeId");
                
            } while (true);

            Console.WriteLine("1: characters");
            Console.WriteLine("2: planets");
            Console.WriteLine("3: starships");
            Console.WriteLine("4: vehicles");
            Console.WriteLine("5: species");

            int ObjId = 0;
            do
            {
                Console.WriteLine();
                Console.Write("Enter the number against the data: ");
                strInput = Console.ReadLine();
                if (Int32.TryParse(strInput, out ObjId) && ObjId >= 1 && ObjId <= 5)
                    break;
                else
                    Console.WriteLine("Please enter a valid number");

            } while (true);

            switch (ObjId) {
                case 1:
                    foreach (var obj in dp.GetCharacter(EpisodeId, filmData)) {
                        obj.Print2Console();
                    }

                    break;
                case 2:
                    foreach (var obj in dp.GetPlanets(EpisodeId, filmData))
                    {
                        obj.Print2Console();
                    }
                    break;
                case 3:
                    foreach (var obj in dp.GetStarShips(EpisodeId, filmData))
                    {
                        obj.Print2Console();
                    }
                    break;
                case 4:
                    List<vehicles> vehs = dp.GetVehicles(EpisodeId, filmData);
                    foreach (var obj in vehs)
                    {
                        obj.Print2Console();
                    }
                    break;
                case 5:
                    foreach (var obj in dp.GetSpecies(EpisodeId, filmData))
                    {
                        obj.Print2Console();
                    }
                    break;

            }

            Console.ReadLine();

        }


    }
}
