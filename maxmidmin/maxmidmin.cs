namespace MMM
{
    class MaxMidMin
    {
        public static void CountMaxMidMin(int[] numbers)
        {
            int dval = numbers[0];
            int[] statuses = { dval, 0, 2147483647 };

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
            Console.Write("Press any key to continue...");
            Console.ReadKey();
        }

        public static void Main (string[] args)
        {
            int[] numbers = { 0, 0, 0 };
            if (args.Length == 3)
            {
                for (int n = 0; n < 3; n++)
                {
                    numbers[n] = Int32.Parse(args[n]);
                }

                CountMaxMidMin(numbers);
            }
            else
            {
                Console.WriteLine("Optimal usage: maxmidmin [integers a, b, c]");

                for (int i = 0; i < 3; i++)
                {
                    Console.Write("Enter {0} value: ", i + 1);
                    numbers[i] = Int32.Parse(Console.ReadLine());
                }

                CountMaxMidMin(numbers);
            }
        }
    }
}