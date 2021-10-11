using System;

namespace FromAtoB
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read line, and split it by whitespace into an array of strings
            string[] inputs = Console.ReadLine().Split();

            //Parse a
            int a = int.Parse(inputs[0]);

            //Parse b
            int b = int.Parse(inputs[1]);

            //Var for count
            int count = 0;

            if (a >= 1 && a <= 1000000000 && b >= 1 && b <= 1000000000)
            {


                if (a < b)
                {
                    count = b - a;
                    b = 1;
                    a = 1;


                }


                while (a != b)
                {
                    if (a < b)
                    {
                        a++;
                        count++;


                    }


                    if (a > b)
                    {

                        if (a % 2 == 0)
                        {
                            a = a / 2;
                            count++;

                        }

                        else if (a % 2 != 0)
                        {
                            a++;
                            count++;

                        }

                    }

                }
            }

            Console.WriteLine(count);
        }
    }
}
