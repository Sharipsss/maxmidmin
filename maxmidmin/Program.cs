using System;

namespace MMM
{
    class MaxMidMin
    {
        public static void Main(string[] args)
        {
            int[] numbers = { 0, 0, 0 };
            int dval = numbers[0];
            int[] statuses = { dval, 0, 2147483647 };
            if (args.Length == 3)
            {
                for (int n = 0; n < 3; n++)
                {
                    numbers[n] = Int32.Parse(args[n]);
                }

                for (int i = 0; i < 3; i++)
                {
                    if (numbers[i] >= statuses[0])
                    {
                        statuses[0] = numbers[i];
                    }

                    if (numbers[i] <= statuses[2])
                    {
                        statuses[2] = numbers[i];
                    }
                }

                statuses[1] = (numbers[0] + numbers[1] + numbers[2]) - (statuses[0] + statuses[2]);
                Console.WriteLine("MAX: {0}\nMID: {1}\nMIN: {2}", statuses[0], statuses[1], statuses[2]);
            }
        }
    }
}