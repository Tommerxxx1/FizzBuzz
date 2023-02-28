namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast et tal:");
            int heltal = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 1; i < heltal; i++)
            {
                if (i % 3 == 0 && i % 7 == 0 || i % 5 == 0 && i % 7 == 0)
                {
                    if (i % 3 == 0 && i % 7 == 0)
                    {
                        Console.WriteLine("BuzzJazz");
                    }
                    else
                    {
                        Console.WriteLine("FizzJazz");
                    }
                }
                
                else if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                    {
                    Console.WriteLine("Buzz");    
                    }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 7 == 0)
                {
                    Console.WriteLine("Jazz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            


        }
    }
}