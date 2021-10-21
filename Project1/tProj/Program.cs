using System;

namespace tProj
{
    class Program
    {
        static void Main(string[] args)
        {
            int N1;
            int N2;
            int Op1;
            int sum;
            char rerun;

            do
            {
                Console.WriteLine("Please enter a number");
                N1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter an Operator-\n 1. Addition \n 2. Subtraction \n 3. Division \n 4. Multiplication");
                Op1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter 2nd number");
                N2 = int.Parse(Console.ReadLine());

                if (Op1 == 1)
                {
                    sum = N1 + N2;
                    Console.WriteLine("Your Answer is- {0}", sum);
                }

                if (Op1 == 2)
                {
                    sum = N1 - N2;
                    Console.WriteLine("Your Answer is- {0}", sum);
                }

                if (Op1 == 3)
                {
                    sum = N1 / N2;
                    Console.WriteLine("Your Answer is- {0}", sum);
                }

                if (Op1 == 4)
                {
                    sum = N1 * N2;
                    Console.WriteLine("Your Answer is- {0}", sum);
                }

                if (Op1 >= 5)
                {

                    Console.WriteLine("Invalid Imput");
                }


                Console.WriteLine("Do You Want to Use Again? - Y/N");
                rerun = Console.ReadLine()[0];
            

            } while (rerun == 'y');

        }
    }
}
