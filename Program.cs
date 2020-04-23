using System;

namespace c_
{
    class Program
    {
        static void Main(string[] args)
        {
            int guess;
            string level;
            int randomNumber;
            int guessesremaining;

            string[] levels = new string[] {"EASY", "MEDIUM" ,"HARD"};

            Console.Write("This is a guessing game ");

            Console.WriteLine("Please choose the level you wnat to play");
            Console.WriteLine("EASY ,MEDIUM , HARD");
            Console.Write("Enter your choice exactly as above: ");
            level = Console.ReadLine();
            
            ////////// level EASY/////////
            if (level == levels[0])
            {             
                for (int i = 0; i <= 6; i++)
                {
                    Console.WriteLine("Input your guess");
                    guessesremaining =6-i;
                    Console.WriteLine("Guessesremaining:" + guessesremaining);
                    guess = int.Parse(Console.ReadLine());
                    Random random = new Random();
                    randomNumber = random.Next(1, 11);
                   
                    if (guess != randomNumber  && guessesremaining ==0)
                    {
                        Console.WriteLine("GAME OVER ");
                    }
                    else if (guess == randomNumber)
                    {
                        Console.WriteLine("You got it right");
                        break;
                    }
                    else if (guess != randomNumber)
                    {
                        Console.WriteLine("You are wrong");
                    }
                }
            }
            /////////level MEDIUM//////
            if (level == levels[1])
            {             
                for (int i = 0; i <= 4; i++)
                {
                    Console.WriteLine("Input your guess");
                    guessesremaining = 4-i;
                    Console.WriteLine("Guessesremaining:" + guessesremaining);
                    guess = int.Parse(Console.ReadLine());
                    Random random = new Random();
                    randomNumber = random.Next(1, 21);
                    if (guess != randomNumber && guessesremaining == 0)
                    {
                        Console.WriteLine("GAME OVER");
                    }
                    else if (guess == randomNumber )
                    {
                        Console.WriteLine("You got it right");
                        break;
                    }
                    else if (guess != randomNumber)
                    {
                        Console.WriteLine("You got it wrong");
                    }
                }
            }
            //////////level hard
            if (level == levels[2])
            {             
                for (int i = 0; i <= 3; i++)
                {
                    Console.WriteLine("Input your guess");
                    guessesremaining = 3-i;
                    Console.WriteLine("Guessesremaining:" + guessesremaining);
                    guess = int.Parse(Console.ReadLine());
                    Random random = new Random();
                    randomNumber = random.Next(1, 51);
                    if (guess != randomNumber && guessesremaining == 0  )
                    {
                        Console.WriteLine(" GAME OVER ");
                    }
                    else if (guess == randomNumber)
                    {
                        Console.WriteLine("You got it right");
                        break;
                    }
                    else if (guess != randomNumber)
                    {
                        Console.WriteLine("You got it wrong");
                    }
                }
            }
        }
    }
}

