using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PayaTest.Models;

namespace PayaTest
{
    class DataParser
    {
        public Films ParseFilmData() {
            Films obj = null;
            DataReader rdr = new DataReader();
            string sfilmsJson = rdr.ReadData("https://swapi.dev/api/films/");
            try
            {
                obj = Newtonsoft.Json.JsonConvert.DeserializeObject<PayaTest.Models.Films>(sfilmsJson);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return obj;
        }

        public  List<Models.character> GetCharacter(int episodeid, Films filmObj)
        {
            List<Models.character> retVal = new List<Models.character>();
            DataReader rdr = new DataReader();

            FilmDetail dtl = filmObj.results.Where(e => e.episode_id == episodeid).FirstOrDefault();

            foreach (var chStr in dtl.characters) { 
                string sfilmsJson = rdr.ReadData(chStr);
                try
                {
                    character ch = Newtonsoft.Json.JsonConvert.DeserializeObject<PayaTest.Models.character>(sfilmsJson);
                    retVal.Add(ch);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return retVal;
        }

        public List<Models.species> GetSpecies(int episodeid, Films filmObj)
        {
            List<Models.species> retVal = new List<Models.species>();
            DataReader rdr = new DataReader();

            FilmDetail dtl = filmObj.results.Where(e => e.episode_id == episodeid).FirstOrDefault();

            foreach (var chStr in dtl.species)
            {
                string sfilmsJson = rdr.ReadData(chStr);
                try
                {
                    species ch = Newtonsoft.Json.JsonConvert.DeserializeObject<PayaTest.Models.species>(sfilmsJson);
                    retVal.Add(ch);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return retVal;
        }

        public List<Models.vehicles> GetVehicles(int episodeid, Films filmObj)
        {
            List<Models.vehicles> retVal = new List<Models.vehicles>();
            DataReader rdr = new DataReader();

            FilmDetail dtl = filmObj.results.Where(e => e.episode_id == episodeid).FirstOrDefault();

            foreach (var chStr in dtl.vehicles)
            {
                string sfilmsJson = rdr.ReadData(chStr);
                try
                {
                    vehicles ch = Newtonsoft.Json.JsonConvert.DeserializeObject<PayaTest.Models.vehicles>(sfilmsJson);
                    retVal.Add(ch);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return retVal;
        }

        public List<Models.starships> GetStarShips(int episodeid, Films filmObj)
        {
            List<Models.starships> retVal = new List<Models.starships>();
            DataReader rdr = new DataReader();

            FilmDetail dtl = filmObj.results.Where(e => e.episode_id == episodeid).FirstOrDefault();

            foreach (var chStr in dtl.starships)
            {
                string sfilmsJson = rdr.ReadData(chStr);
                try
                {
                    starships ch = Newtonsoft.Json.JsonConvert.DeserializeObject<PayaTest.Models.starships>(sfilmsJson);
                    retVal.Add(ch);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return retVal;
        }

        public List<Models.planets> GetPlanets(int episodeid, Films filmObj)
        {
            List<Models.planets> retVal = new List<Models.planets>();
            DataReader rdr = new DataReader();

            FilmDetail dtl = filmObj.results.Where(e => e.episode_id == episodeid).FirstOrDefault();

            foreach (var chStr in dtl.planets)
            {
                string sfilmsJson = rdr.ReadData(chStr);
                try
                {
                    planets ch = Newtonsoft.Json.JsonConvert.DeserializeObject<PayaTest.Models.planets>(sfilmsJson);
                    retVal.Add(ch);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return retVal;
        }
    }
}
