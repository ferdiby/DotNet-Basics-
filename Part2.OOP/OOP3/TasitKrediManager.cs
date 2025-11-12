using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class TasitKrediManager:IKrediService
    {
        //public TasitKrediManager()
        //{
        //    Console.WriteLine("Taşıt kredisi");
        //}
        public int KrediPuan { get; set; }
        public string Name { get; set; } = "araba";

        public void Hesapla()
        {
            Console.WriteLine("taşıt kredisi hesaplandı");
        }

        public void Bilgilendir()
        {
            Console.WriteLine($"{this.Name} kredisi alınabilir");
        }
    }
}
