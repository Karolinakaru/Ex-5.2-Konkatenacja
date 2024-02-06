internal class Program
{
    private static void Main()
    {
        string firstString, secondString, linkedString;
        Console.WriteLine("Enter the first string and press ENTER");
        firstString = Console.ReadLine();
        Console.WriteLine("Enter the second string press ENTER");
        secondString = Console.ReadLine();
        Console.WriteLine("Concatenated strings are:");
        linkedString = string.Concat(firstString, " ", secondString);//concatenate two text strings
        Console.WriteLine(linkedString);
        Console.ReadKey();
    }
}