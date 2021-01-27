using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayaTest.Models
{
    public class Films
    {
        public int count { set; get; }
        public string next { set; get; }
        public string previous { set; get; }

        public FilmDetail[] results { set; get; }
    }

    public interface DataObject {
        void Print2Console();
    }

    public class FilmDetail : DataObject
    {
        public string title { set; get; }
        public int episode_id { set; get; }
        public string opening_crawl { set; get; }
        public string director { set; get; }
        public string producer { set; get; }
        public string release_date { set; get; }

        //public System.Collections.Generic.Dictionary<int, string> characters = new Dictionary<int, string>();
        //public System.Collections.Generic.Dictionary<int, string> planets = new Dictionary<int, string>();
        //public System.Collections.Generic.Dictionary<int, string> starships = new Dictionary<int, string>();
        //public System.Collections.Generic.Dictionary<int, string> vehicles = new Dictionary<int, string>();
        //public System.Collections.Generic.Dictionary<int, string> species = new Dictionary<int, string>();

        public string[] characters { set; get; }
        public string[] planets { set; get; }
        public string[] starships { set; get; }
        public string[] vehicles { set; get; }
        public string[] species { set; get; }

        public DateTime Created { set; get; }
        public DateTime Edited { set; get; }
        public string url { get; set; }

        public void Print2Console()
        {
            Console.WriteLine("title: " + title);
            Console.WriteLine("episode_id: " + episode_id);
            Console.WriteLine("opening_crawl: " + opening_crawl);
            Console.WriteLine("director: " + director);
            Console.WriteLine("producer: " + producer);
            Console.WriteLine("release_date: " + release_date);
            Console.WriteLine("Created: " + Created);
            Console.WriteLine("Edited: " + Edited);
            Console.WriteLine("url: " + url);
            Console.WriteLine("------------------------------------------------------------");
        }
    }
    public class character : DataObject
    {
        public string name { set; get; }
        public string height { set; get; }
        public string mass { set; get; }
        public string hair_color { set; get; }
        public string skin_color { set; get; }
        public string eye_color { set; get; }
        public string birth_year { set; get; }
        public string gender { set; get; }
        public string homeworld { set; get; }
        public string[] films { set; get; }
        public string[] species { set; get; }
        public string[] vehicles { set; get; }
        public string[] starships { set; get; }

        public void Print2Console()
        {
            Console.WriteLine("name: " + name);
            Console.WriteLine("height: " + height);
            Console.WriteLine("mass: " + mass);
            Console.WriteLine("hair_color: " + hair_color);
            Console.WriteLine("skin_color: " + skin_color);
            Console.WriteLine("eye_color: " + eye_color);
            Console.WriteLine("birth_year: " + birth_year);
            Console.WriteLine("gender: " + gender);
            Console.WriteLine("homeworld: " + homeworld);
            Console.WriteLine("------------------------------------------------------------");
        }
    }

    public class species : DataObject
    {
        public string name { set; get; }
        public string classification { set; get; }
        public string designation { set; get; }
        public string average_height { set; get; }
        public string skin_colors { set; get; }
        public string hair_colors { set; get; }
        public string eye_colors { set; get; }
        public string average_lifespan { set; get; }
        public string homeworld { set; get; }
        public string language { set; get; }
        public string[] people { set; get; }
        public string[] films { set; get; }

        public void Print2Console()
        {
            Console.WriteLine("name: " + name);
            Console.WriteLine("classification: " + classification);
            Console.WriteLine("designation: " + designation);
            Console.WriteLine("average_height: " + average_height);
            Console.WriteLine("skin_colors: " + skin_colors);
            Console.WriteLine("hair_colors: " + hair_colors);
            Console.WriteLine("eye_colors: " + eye_colors);
            Console.WriteLine("average_lifespan: " + average_lifespan);
            Console.WriteLine("homeworld: " + homeworld);
            Console.WriteLine("language: " + language);
            Console.WriteLine("------------------------------------------------------------");
        }
    }
    public class vehicles : DataObject
    {
        public string name { set; get; }
        public string model { set; get; }
        public string manufacturer { set; get; }
        public string cost_in_credits { set; get; }
        public string length { set; get; }
        public string crew { set; get; }
        public string passengers { set; get; }
        public string cargo_capacity { set; get; }
        public string consumables { set; get; }
        public string vehicle_class { set; get; }
        public string[] Pilots { set; get; }
        public string[] Films { set; get; }

        public void Print2Console()
        {
            Console.WriteLine("name: " + name);
            Console.WriteLine("model: " + model);
            Console.WriteLine("manufacturer: " + manufacturer);
            Console.WriteLine("cost_in_credits: " + cost_in_credits);
            Console.WriteLine("length: " + length);
            Console.WriteLine("crew: " + crew);
            Console.WriteLine("passengers: " + passengers);
            Console.WriteLine("cargo_capacity: " + cargo_capacity);
            Console.WriteLine("consumables: " + consumables);
            Console.WriteLine("vehicle_class: " + vehicle_class);
            Console.WriteLine("------------------------------------------------------------");
        }
    }
    public class starships : DataObject
    {
        public string name { set; get; }
        public string model { set; get; }
        public string manufacturer { set; get; }
        public string cost_in_credits { set; get; }
        public string length { set; get; }
        public string max_atmosphering_speed { set; get; }
        public string crew { set; get; }
        public string passengers { set; get; }
        public string cargo_capacity { set; get; }
        public string consumables { set; get; }
        public string hyperdrive_rating { set; get; }
        public string MGLT { set; get; }
        public string starship_class { set; get; }
        public string[] Pilots { set; get; }
        public string[] Films { set; get; }

        public void Print2Console()
        {
            Console.WriteLine("name: " + name);
            Console.WriteLine("model: " + model);
            Console.WriteLine("manufacturer: " + manufacturer);
            Console.WriteLine("cost_in_credits: " + cost_in_credits);
            Console.WriteLine("length: " + length);
            Console.WriteLine("max_atmosphering_speed: " + max_atmosphering_speed);
            Console.WriteLine("crew: " + crew);
            Console.WriteLine("passengers: " + passengers);
            Console.WriteLine("cargo_capacity: " + cargo_capacity);
            Console.WriteLine("consumables: " + consumables);
            Console.WriteLine("hyperdrive_rating: " + hyperdrive_rating);
            Console.WriteLine("MGLT: " + MGLT);
            Console.WriteLine("starship_class: " + starship_class);
            Console.WriteLine("------------------------------------------------------------");
        }
    }

    public class planets : DataObject
    {
        public string name { set; get; }
        public string rotation_period { set; get; }
        public string orbital_period { set; get; }
        public string diameter { set; get; }
        public string climate { set; get; }
        public string gravity { set; get; }
        public string terrain { set; get; }
        public string surface_water { set; get; }
        public string population { set; get; }
        public string[] residents { set; get; }
        public string[] films { set; get; }

        public void Print2Console()
        {
            Console.WriteLine("name: " + name);
            Console.WriteLine("rotation_period: " + rotation_period);
            Console.WriteLine("orbital_period: " + orbital_period);
            Console.WriteLine("diameter: " + diameter);
            Console.WriteLine("climate: " + climate);
            Console.WriteLine("gravity: " + gravity);
            Console.WriteLine("terrain: " + terrain);
            Console.WriteLine("surface_water: " + surface_water);
            Console.WriteLine("population: " + population);
            Console.WriteLine("------------------------------------------------------------");
        }
    }
}
