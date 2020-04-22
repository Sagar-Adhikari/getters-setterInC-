using System;

namespace begineer_guide
{
    class Program
    {
        static void Main(string[] args)
        {
            //Getters and Setters.....

            Movie avengers = new Movie("Once upon a time in holyhood", "Joss Whedon", "PG-13");
            Movie shrek = new Movie("Shrek", "Adam Adamson", "PG");
            Console.WriteLine(avengers.Rating);
            Console.ReadLine();


            //Book book1 = new Book();
            //book1.title = "sagar";
            //book1.author = "adhikari";
            //book1.pages = 400;
            //Console.WriteLine(book1.pages);


            //string secret = "sagar";
            //string guess = "";
            //int guessCount = 0;
            //int guessLimit = 3;
            //bool outOfGuesses = false;

            //while (guess != secret && !outOfGuesses)
            //{ 
            //    if (guessCount < guessLimit)
            //    {
            //        Console.Write("Enter the guess:");
            //        guess = Console.ReadLine();
            //        guessCount++;
            //    }
            //    else
            //    {
            //        outOfGuesses = true;
            //    }
             
            //}
            //if (outOfGuesses)
            //{
            //    Console.WriteLine("you loose!");
            //}
            //else
            //{
            //    Console.WriteLine("you win");
            //}
        
           
        }
    }
}

