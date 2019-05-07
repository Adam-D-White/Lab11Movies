using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lab11Movies
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Movie starWars = new Movie("Star Wars", "SciFi");
            Movie theTerminator = new Movie("The Terminator", "SciFi");
            Movie avengersEndGame = new Movie("Avengers End Game", "Family");
            Movie spiderManIntoTheSpiderVerse = new Movie("Spider Man Into The Spiderverse", "Family");
            Movie dieHard = new Movie("Die Hard", "Action");
            Movie commando = new Movie("Commando", "Action");
            Movie jaws = new Movie("Jaws", "Horror");
            Movie alien = new Movie("Alien", "Horror");
            Movie pineAppleExpress = new Movie("Pineapple Express", "Comedy");
            Movie baseketball = new Movie("Baseketball", "Comedy");

            List<Movie> SciFi = new List<Movie> { starWars, theTerminator };
            List<Movie> Family = new List<Movie> { avengersEndGame, spiderManIntoTheSpiderVerse };
            List<Movie> Action = new List<Movie> { dieHard, commando };
            List<Movie> Horror = new List<Movie> { jaws, alien };
            List<Movie> Comedy = new List<Movie> { pineAppleExpress, baseketball };


            Console.WriteLine("Welcome to the Movie List Program!\n" +
                "");

            
            Console.WriteLine("There are 10 movies in the list\nWhat category would you like to see? \nPlease Enter:  \nSciFi \nFamily \nAction \nHorror \nComedy");
            //list categories

           
           




            switch (Console.ReadLine())
            {
                case "SciFi":
                    foreach (Movie movie in SciFi)
                    {
                        Console.WriteLine($"{ movie.Title}");
                    };
                    break;
                case "Family":
                    foreach (Movie movie in Family)
                    {
                        Console.WriteLine($"{ movie.Title}");
                    };
                    break;
                case "Action":
                    foreach (Movie movie in Action)
                    {
                        Console.WriteLine($"{ movie.Title}");
                    };
                    break;
                case "Horror":
                    foreach (Movie movie in Horror)
                    {
                        Console.WriteLine($"{ movie.Title}");
                    };
                    break;
                case "Comedy":
                    foreach (Movie movie in Comedy)
                    {
                        Console.WriteLine($"{ movie.Title}");
                    };
                    break;
                default:
                    break;
            }

           




        }

        
    }
}





    



        

