using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    class Program
    {
        static void Main(string[] args)
        {       
            Console.WriteLine("How many players?");
            int players;
            while(true)
                {
                String input = Console.ReadLine();
                int n;
                
                if (int.TryParse(input, out n))
                {
                    players = int.Parse(input);
                    break;
                }
                Console.WriteLine("Please enter a number.");
            }
            List<int> atBats = new List<int>();
            List<double> slugg = new List<double>();
            List<double> avg = new List<double>();
            for (int x = 0; x < players; x++)
            {
                Console.Write("How many at bats did player " + (x+1) + " have?: ");
                Boolean check = true;
                while (check == true)
                {
                    String input = Console.ReadLine();
                    int n;

                    if (int.TryParse(input, out n))
                    {
                        atBats.Add(int.Parse(input));
                        check = false;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a number.");
                    }
                }
            }
            for (int y = 0; y< players; y++)
            {
                List<int> results = new List<int>();
                for(int z = 0;z < atBats.ElementAt(y); z++)
                {
                    Console.Write("What was the result of player " + (y+1) + "'s attempt number " + (z+1) + ": ");
                    Boolean check = true;
                    while (check == true)
                    {
                        String input = Console.ReadLine();
                        int n;

                        if (int.TryParse(input, out n))
                        {
                            int num = int.Parse(input);
                            if (num >=0&&num<=4)
                            {
                                results.Add(num);
                                check = false;
                            }
                            else
                            {
                                Console.Write("Please enter a number (0,1,2,3,4): ");
                            }
                        }
                        else
                        {
                            Console.Write("Please enter a number (0,1,2,3,4): ");
                        }
                    }
                }
                int hits = 0;
                for (int z = 0; z < atBats.ElementAt(y); z++)
                {
                    if (results.ElementAt(z) != 0)
                    {
                        hits++;
                    }
                }
                double average = (double)hits/atBats.ElementAt(y);
                int bases = 0;
                for (int z = 0; z < atBats.ElementAt(y); z++)
                {
                    bases = bases + results.ElementAt(z);
                }
                double slug = (double)bases / atBats.ElementAt(y);
                slugg.Add(slug);
                avg.Add(average);

            }
            Console.WriteLine("Player\tAt Bats\tAverage\tSugging %");
            Console.WriteLine("=======\t=======\t=======\t=======");
            for (int a = 0; a < players; a++)
            {
                Console.WriteLine((a+1) + "\t"+atBats.ElementAt(a)+"\t"+avg.ElementAt(a)+"\t"+slugg.ElementAt(a));
            } Console.ReadLine();

        }
    }
}
