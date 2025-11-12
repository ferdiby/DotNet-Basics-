using System.Globalization;
using System.Linq.Expressions;

internal class Program
{
    private static void Main(string[] args)
    {
        // WORK HAS DONE

        #region Variables
        //Console.WriteLine(typeof(string));
        //Console.WriteLine(typeof(int));
        //Console.WriteLine(short.MaxValue);
        //double result = Math.Pow(2, 15);
        //Console.WriteLine(result);
        //(int yas, bool medeniHal, string isim) kisi = (32, false, "ferdi");
        //Console.WriteLine(kisi.isim);
        //const int yas = 32;
        //yas = 35; // it won't work
        //int yas2 = 34;
        //yas2 = 36;
        //Console.WriteLine(yas2);
        #endregion
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
        //object name3 = "bayram";
        //string name4 = (string) name3;
        //Console.WriteLine(name4);
        // var keyword-dynamic keyword

        // Type-Conversion 
        //string medeniHal = "true";
        //bool medeniHal2 = bool.Parse(medeniHal);
        //ternary operator
        //string evliMiDegilMi = medeniHal2 ? "Sen evlisin" : "Evli değilsin";
        //Console.WriteLine(evliMiDegilMi);

        //string tcKimlikNo = "12345";
        //int tcKimlikUser = int.Parse(tcKimlikNo);
        //Console.WriteLine(tcKimlikUser+7);

        //bool medeniHal3 = Convert.ToBoolean(medeniHal);
        //Console.WriteLine(medeniHal3);

        //tostring()
        //int x = 765;
        //string y = x.ToString();
        //Console.WriteLine(y+"ay");

        //ASCII values -- Implicit Coverion
        //char c = '%';
        //int b = (int)c;
        //char d = '-';
        //int e = (int)d;
        //Console.WriteLine(b+d);

        //Explicit Conversion
        //int x = 65;
        //char y = (char)x;
        //Console.WriteLine(y);

        //Logic operators

        //bool decisionUser = false;
        //int decResult = ! decisionUser ? 7 : 20;
        //Console.WriteLine(decResult);

        //String a = "ayşe";
        //string b = a;
        //Console.WriteLine(a+b);

        //int x = 5;
        //string y = x.ToString();
        //Console.WriteLine(y+4);
        //Console.WriteLine(default(int)); //0
        //Console.WriteLine(default(double)); //0
        //Console.WriteLine(default(string)); //null
        //Console.WriteLine(default(char)); //nul
        //Console.WriteLine(default(DateTime)); 
        //Console.WriteLine(default(bool)); //false
        //Console.WriteLine(default(Type)); //null
        //Type t = typeof(DateTime);
        #region try-catch example

        //try
        //{
        //    Console.Write("1. değeri girin: ");
        //    int num1 = int.Parse(Console.ReadLine());
        //    Console.Write("2. değeri girin: ");
        //    int num2 = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Toplam: "+(num1+num2));
        //}
        //catch 
        //{
        //    Console.WriteLine("Lütfen sayı girin..");
        //}

        #endregion
        #region Factorial example
        //Console.Write("Put a number: ");
        //int number = int.Parse(Console.ReadLine());
        //decimal result = 1m;

        //if (number == 0)
        //{
        //    Console.WriteLine($"{number}!= " + result);
        //}
        //else if (number < 0)
        //{
        //    Console.WriteLine("Factorial can not calculate negative values..");

        //}
        //else
        //{
        //    for (int i = 1; i <= number; i++)
        //    {
        //        result *= i;
        //    }
        //    Console.WriteLine($"{number}!= " + result);
        //} 
        #endregion
        //    int a = 1;
        //a:
        //    Console.WriteLine("You shouldn't use --");
        //    Console.WriteLine("go to");
        //    Console.WriteLine(a++);
        //    goto a;
        #region Arrays

        //Array numbers = new[] { 3, 1, 2, 4, 5 };
        //int[] numbers2 = new int[5];

        //Array.Sort(numbers);
        //Array.Reverse(numbers);
        //numbers2 = (int[])numbers.Clone();
        //foreach (int i in numbers) 
        //    Console.Write(i);
        //Console.WriteLine("");
        //foreach (int i in numbers2)
        //    Console.Write(i);

        //int[] numbers3 = { 1, 2, 3, 4, 5 };
        //for (int i = 0; i < numbers3.Length; i++) 
        //    Console.WriteLine(numbers3[i]);

        //int[,] numbers4 =
        //{
        //    {1,2,3},
        //    {4,5,6},

        //};

        //Console.WriteLine(numbers4);

        //for(int i=0;i<numbers4.GetLength(0);i++){
        //    for (int j = 0; j < numbers4.GetLength(1); j++)
        //    {
        //        Console.Write(numbers4[i,j] +" ");
        //    }
        //    Console.WriteLine();
        //}


        #endregion




    }

    #region Geriye değer döndürmeyen ve Parametre almayan method
    private void Method1()
    {
        Console.WriteLine("Geriye değer döndürmeyen ve Parametre almayan method");
    }
    #endregion

    #region Geriye değer döndürmeyen ve Parametre alan method

    private void Method2(int number)
    {
        Console.WriteLine(number);
    }

    #endregion

    #region Geriye değer döndüren ve Parametre almayan method

    private int Method3()
    {
        return 3;

    }

    #endregion

    #region Geriye değer döndüren ve Parametre alan method

    private int Method4(int number)
    {
        return number;
    }
    #endregion
}