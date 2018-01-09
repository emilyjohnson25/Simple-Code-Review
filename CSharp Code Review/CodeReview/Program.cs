using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeReview
{
    class Program
    {
        static void Main(string[] args)
        {
            //use salutation class for an 'walmart' Greeter   
            Salutation oldGuy = new Salutation("Welcome to Walmart",
                "Thanks for shopping at Walmart");
            //Get the old guy to talk.... 
            Console.WriteLine(oldGuy.Greet());
            Console.WriteLine(oldGuy.SayFarewell());
                  
        }
    }
}
