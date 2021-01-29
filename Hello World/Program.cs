using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Language?");
        string language = Console.ReadLine();

        switch (language)
        {
            case "en":
                Console.WriteLine("Hello World!");
                break;

            case "bg":
                Console.WriteLine("Здравей свят!");
                break;

            default:
                Console.WriteLine("This language is not added yet!");
                break;
        }
    }
}
