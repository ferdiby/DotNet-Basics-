using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        #region String

        //List<string> cities = new List<string>() { "ankara", "istanbul", "tekirdağ", "bursa", "maraş" };
        //foreach (string city in cities)
        //{
        //    if (city.Length > 7)
        //        Console.WriteLine(city);
        //}

        //string name = "murat";
        //List<char> sortedName = new List<char>();

        //foreach (char c in name)
        //{
        //    sortedName.Add(c);
        //}

        //sortedName.Sort();

        //foreach (var item in sortedName)
        //{
        //    Console.Write($"{item}");
        //}
        //string city = "ağrı";
        //string city2 = "diyarbakır";
        //string format
        //Console.WriteLine("Benim şehrim : {0}, Senin şehrin: {1}",city,city2);
        //string interpolation
        //Console.WriteLine($"Benim şehrim : {city}\nSenin şehrin: {city2}");

        ArrayList ferdilist = new ArrayList() { "ferd", "mur", "nere", 2, 4, true };
        ferdilist.Add("vvfveb");
        
        //foreach (var item in ferdilist)
        //{
        //    Console.WriteLine(item);

        //}
        Console.WriteLine(ferdilist.IndexOf("nere"));



        #endregion

    }
}