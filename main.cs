using System;

class Program
{
    const string Occupation = "work";
    const string workNumber = "000-000-0101";
    const string cellNumber = "000-000-0189";
    const string phoneType = "cell";

    public static void Main(string[] args)
    {
        Console.WriteLine("Lucinda Potter");
        Console.WriteLine("6/24/1992");
        Console.WriteLine(concatContactCell(Occupation, workNumber));
        Console.WriteLine(concatContactWork(phoneType, cellNumber));

        Console.WriteLine(" ");
        
        Console.WriteLine("John Smith");
        Console.WriteLine("8/15/1978");
        Console.WriteLine("work 000-111-0101");
        Console.WriteLine("cell 000-111-0189");
        
        Console.WriteLine(" ");
        
        Console.WriteLine("Chris Johnson");
        Console.WriteLine("12/01/1987");
        Console.WriteLine("work 000-222-0101");
        Console.WriteLine("cell 000-222-0189");

        Console.WriteLine(" ");

        Console.WriteLine("Robert Hall");
        Console.WriteLine("2/27/1949");
        Console.WriteLine("work 000-444-0101");
        Console.WriteLine("cell 000-444-0189");

        Console.WriteLine(" "); 
        
    }

    public static string concatContactCell(string job, string number)
    {
        return job + " " + number;
    }

    public static string concatContactWork(string phone, string number)
    {
        return phone + " " + number;
    }

}