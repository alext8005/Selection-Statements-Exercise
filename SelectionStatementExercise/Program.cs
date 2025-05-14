using System.ComponentModel.Design;

namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int favNumber = r.Next(1, 10);
            
            Console.WriteLine("Guess my favorite number :");
            int userInput = int.Parse(Console.ReadLine());

            
            if (userInput == favNumber)
            {
                Console.WriteLine("You guessed it");
            }
            else if (userInput < favNumber)
            {
                Console.WriteLine("Too low");
            }
            else
            {
                Console.WriteLine("Too high");
            }


        }
        
    }
}
