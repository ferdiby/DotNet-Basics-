using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine(typeof(string));
        //Console.WriteLine(typeof(int));
        //Console.WriteLine(short.MaxValue);
        //double result = Math.Pow(2, 15t);
        //Console.WriteLine(result);
        //(int yas, bool medeniHal, string isim) kisi = (32, false, "ferdi");
        //Console.WriteLine(kisi.isim);
        //const int yas = 32;  
        ////yas = 35; // it won't work
        //int yas2 = 34;
        //yas2 = 36;
        //Console.WriteLine(yas2);
        #region A job
        //todo please make shure what you want
        #endregion
        // Deep copy
        //int a = 5;
        //int b = a;
        //a = 23;
        //Console.WriteLine(a);
        //Console.WriteLine(b);
        //// Boxing 
        //string name = "ferdi";
        //object name2 = name;
        //Console.WriteLine(name2);

        // Unboxing
        object name3 = "bayram";
        string name4 = (string) name3;
        Console.WriteLine(name4);


    }
}