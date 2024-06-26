namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "Win";
            string guess = "";
            int point = 0;
            
            while (guess != secretWord && point < 3)
            {
                Console.Write("Guess the word:");
                guess = Console.ReadLine();
                point++;
            }
            if (guess != secretWord)
            { Console.WriteLine("You Lose!"); }
            else { Console.WriteLine("You Win!"); }
            
            Console.ReadLine();
        }
    }
}
