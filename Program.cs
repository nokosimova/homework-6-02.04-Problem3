using System;

namespace Proj3
{
    class Program
    {
        static void Main(string[] args)
        {
            Country c1 = new Country("Tajikistan","Dushanbe","Emomali Rahmon","Middle Asia",9,"tajik");
            Country c2 = new Country("Russian Federation","Moscow","Vladimir Putin","Eurasia",147,"russian");
            Country c3 = new Country("Turkey","Ankara","R.T.Erdogan","Near East",83,"tukrish");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            c1.GetInfo();
            Console.ForegroundColor = ConsoleColor.Blue;
            c2.GetInfo();
            Console.ForegroundColor = ConsoleColor.Red;
            c3.GetInfo();

        }
        class Country
        {
            public string Name{get; set;}
            public string Capital{get; set;}
            public string President{get; set;}
            public string Continent{get; set;}
            public int Population{get; set;}
            public string Language{get; set;}
            
            public Country(string n, string cap, string pr, string con, int pop, string lan)
            {
                this.Name = n;
                this.Capital = cap;
                this.President = pr;
                this.Continent = con;
                this.Population = pop;
                this.Language = lan;

            }
             public void GetInfo()
            {
                Console.WriteLine("--------------------\n");
                Console.WriteLine($"{this.Name} is a country located in {this.Continent}");
                Console.WriteLine($"{this.Capital} is the capital of {this.Name}");
                Console.WriteLine($"There are {this.Population}million people living in {this.Name}");
                Console.WriteLine($"The president of {this.Name} is {this.President}");
                Console.WriteLine($"Native language is {this.Language}");
            }


        }
    }
}
