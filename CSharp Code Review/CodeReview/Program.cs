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
            var app = new Program();
            app.run();
        }
        //{
        //    //use salutation class for an 'walmart' Greeter   
        //    //Salutation oldGuy = new Salutation("Welcome to Walmart",
        //    //    "Thanks for shopping at Walmart");
        //    ////Get the old guy to talk.... 
        //    //Console.WriteLine(oldGuy.Greet());
        //    //Console.WriteLine(oldGuy.SayFarewell());

        //    //Captain Luke bacard greets the staff
        //    Salutation klingonCommander = new Salutation("nuqneH!", "Qapla'!");
        //    //How to get Bacard to say those things
        //    Console.WriteLine(klingonCommander.Greet());
        //    Console.WriteLine(klingonCommander.SayFarewell());
        //    Console.ReadLine();
        //}
        //Our "Program" is really the heart of our "application"
        //So, lets treat it like an object
        //We'll use a property that holds a bunch of salutation objects
        public List<Salutation> Speakers { get; private set; } 
        public Program()
        {
            //The job of a constructor is to make sure that all the
            //properties/fields of the object are set to "meaningful values"
            Speakers = new List<Salutation>();
            Speakers.Add(new Salutation ("Welcome to Walmart", "Thanks for shopping at Walmart"));
            Speakers.Add(new Salutation("nuqneH!", "Qapla'!"));

        }
        public void run()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("you have entered a large building. Two being stand before you.");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("Who do you want to speak to? Person A or B? ");
            string userInput = Console.ReadLine().ToUpper();
            while(userInput != "A" && userInput != "B")
            {
                Console.Write("Try again: ");
                userInput = Console.ReadLine().ToUpper();

            }
            Console.ResetColor();
            switch(userInput)
            {
                case "A":
                    Speak(Speakers[0]);
                    break;
                case "B":
                    Speak(Speakers[1]);
                    break;

            }
            //Console.ReadLine();
        }
        private void Speak(Salutation speaker)
        {
            Console.WriteLine(speaker.Greet());
            Console.WriteLine(speaker.SayFarewell());

        }
      
    }
}
