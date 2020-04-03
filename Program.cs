using System;

namespace Proj3
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        class Country
        {
            public string Name{get; set;}
            public string Capital{get; set;}
            public string President{get; set;}
            public string Continent{get; set;}
            public int Population{get; set;}
            public string Language{get; set;}

            public void GetInfo()
            {
                Console.WriteLine($"{this.Name} is a country located in {this.Continent}");
                Console.WriteLine($"{this.Capital} is the capital of {this.Name}");
                Console.WriteLine($"There are {this.Population} people living in {this.Name}");
                Console.WriteLine($"The president of {this.Name} is {this.President}");
                Console.WriteLine($"Native language is {this.Language}");
            }


        }
    }
}
