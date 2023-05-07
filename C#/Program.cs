using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Calc in C#!");
        Console.WriteLine("Type \"exit\" to exit.");

        while (true)
        {
            try
            {
                Console.Write(">");
                string input = Console.ReadLine();

                if (input.Contains("exit")){
                    Environment.Exit(0);
                }

                if (input.Contains("+")) {
                    Console.WriteLine(seperateInts(input, "+"))
                        ;
                } else if (input.Contains("-")) {
                    Console.WriteLine(seperateInts(input, "-"));

                } else if (input.Contains("/")) {
                    Console.WriteLine(seperateInts(input, "/"));

                }  else if (input.Contains("*")) {
                    Console.WriteLine(seperateInts(input, "*"));

                } else if (input.Contains("%")) {
                    Console.WriteLine(seperateInts(input, "%"));
                } else
                {
                    Console.WriteLine("No operator or not supported operator.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("You typed shit.");
            }


        }
    }
    public static int seperateInts(String input, String regex)
    {
        int[] add = { Int32.Parse(input.Split(regex)[0]), Int32.Parse(input.Split(regex)[1]) };

        switch (regex)
        {
            case "+":
                return add[0] + add[1];

            case "-":
                return add[0] - add[1];

            case "/":
                return add[0] / add[1];

            case "*":
                return add[0] * add[1];

            case "%":
                return add[0] % add[1];
        }
        return 0;
    }
}
