using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StartProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            Urun urun2 = new Urun();

            urun1.Adi = "Elma";
            urun1.Fiyati = 50;
            urun1.Aciklama = "Amasya elması";

            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            List<Urun> urunList = new List<Urun>() { urun1, urun2 };

            //foreach (var urun in urunList)
            //{
            //    Console.Write($"{urun.Adi}--{urun.Fiyati}--{urun.Aciklama}");
            //    Console.WriteLine();
            //}

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);



        }
    }
}
