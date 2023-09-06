using System;
internal class Program
{
    private static void Main(string[] args)
    {
        int time = DateTime.Now.Hour;
        if (time <= 18)
            Console.WriteLine("İyi günler.");
        
        else if (time > 6 && time < 12)
        Console.WriteLine("Günaydın");

        else
        Console.WriteLine("İyi geceler.");
    }
}
