using System;

namespace tProj
{
    class Program
    {
        static void Main(string[] args)
        {
            int N1;
            int N2;
            char Op1;
            int sum;
            char rerun;

            do
            {
                Console.WriteLine("Please enter a number");
                N1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter an Operator-\n Enter + for Addition \n Enter - for Subtraction \n Enter / Division \n Enter * for Multiplication \n [WILL ONLY ACCEPT 1st CHARACTER INPUT]");
                Op1 = Console.ReadLine()[0];

                if (!Op1.Equals('+') && !Op1.Equals('-') && !Op1.Equals('*') && !Op1.Equals('/'))
                {
                    Console.WriteLine("Invalid Input");

                }
                else
                {
                    Console.WriteLine("Please enter 2nd number");
                    N2 = int.Parse(Console.ReadLine());


                    if (Op1 == '+')
                    {
                        sum = N1 + N2;
                        Console.WriteLine("Your Answer is: {0}", sum);
                    }

                    if (Op1 == '-')
                    {
                        sum = N1 - N2;
                        Console.WriteLine("Your Answer is: {0}", sum);
                    }

                    if (Op1 == '/')
                    {
                        sum = N1 / N2;
                        Console.WriteLine("Your Answer is: {0}", sum);
                    }

                    if (Op1 == '*')
                    {
                        sum = N1 * N2;
                        Console.WriteLine("Your Answer is: {0}", sum);
                    }

                }


                Console.WriteLine("Do You Want to Use Again? - Y/N");
                rerun = Console.ReadLine()[0];
            

            } while (rerun == 'y');

        }
    }
}
