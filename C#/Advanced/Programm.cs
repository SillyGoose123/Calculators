using System.Text.RegularExpressions;

internal class Program
{
    private static void Main()
    {
        Console.WriteLine("Welcome to Calc in C#!");
        Console.WriteLine("Type \"exit\" to exit.");

        while (true)
        {
            try
            {
                Console.Write(">");
                string input = Console.ReadLine()!.Trim();

                if (input.Contains("exit")) Environment.Exit(0);

                // error check
                if (input.IndexOfAny(GetAllOperators()) == -1) throw new Exception("No or not supported Opperator.");

                Console.WriteLine("=" + Calc(input));
            }
            catch (Exception e)
            {
                Console.WriteLine($"An Error Occured: {e.Message}");
            }


        }
    }

    static int Calc(string input)
    {
        string[] tokens = Tokenize(input);
        foreach (var item in tokens) Console.WriteLine(item);
        tokens = Array.FindAll(tokens, token => !string.IsNullOrEmpty(token));

        tokens = ResolveHigherOperators(tokens);

        return ResolvePlusMinus(tokens);
    }


    enum Operators
    {
        Add = '+',
        Substract = '-',
        Multiply = '*',
        Divide = '/',
        Modulo = '%',
    }


    static char[] GetAllOperators()
    {
        return [.. Enum.GetValues(typeof(Operators))
                        .Cast<Operators>()
                        .Select(d => (char)d)];
    }

    static string[] Tokenize(string input)
    {
        return Regex.Split(input, "(" + String.Join("|", [.. GetAllOperators().Select(d => Regex.Escape(d.ToString()))]) + ")");
    }

    static Operators getOperator(string input)
    {
        char opToken = input[0];
        if (!Enum.IsDefined(typeof(Operators), (int)opToken))
        {
            throw new Exception("Excpected Opperator at " + opToken);
        }
        return (Operators)opToken;
    }

    static int ResolvePlusMinus(string[] tokens)
    {
        int cache = Convert.ToInt32(tokens[0]);
        for (int i = 1; i < tokens.Length; i += 2)
        {
            cache = MakeOp(cache, Convert.ToInt32(tokens[i + 1]), getOperator(tokens[i]));
        }

        return cache;
    }

    static string[] ResolveHigherOperators(string[] inputTokens)
    {
        string[] tokens = inputTokens;

        for (int i = 1; i < tokens.Length; i += 2)
        {
            Operators op = getOperator(tokens[i]);

            if (op == Operators.Add || op == Operators.Substract)
            {
                continue;
            }

            tokens[i] = ((char)(i > 2 ? getOperator(tokens[i - 2]) : Operators.Add)).ToString();
            tokens[i + 1] = MakeOp(Convert.ToInt32(tokens[i - 1]), Convert.ToInt32(tokens[i + 1]), op).ToString();
            tokens[i - 1] = "0";
        }

        return tokens;
    }


    static int MakeOp(int chache, int item, Operators op)
    {
        return op switch
        {
            Operators.Substract => chache - item,
            Operators.Multiply => chache * item,
            Operators.Divide => chache / item,
            Operators.Modulo => chache % item,
            _ => chache + item, // add case
        };
    }

}
