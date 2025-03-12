using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magic_number = randomGenerator.Next(1, 101);    
        int guess_number = 0;

        Console.WriteLine($"What is the magic number? {magic_number}");

        while(guess_number != magic_number){
            Console.Write("What is your guess? ");
            guess_number = int.Parse(Console.ReadLine());
            //guess_number = Convert.ToInt32(Console.ReadLine());

            if(guess_number > magic_number){
                Console.WriteLine("Lower");
            }
            else if(guess_number < magic_number){
                Console.WriteLine("Higher");
            }
            else{
                Console.WriteLine("You guessed it!");                
            }


        }
    }
}