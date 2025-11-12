using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class IhtiyacKrediManager : IKrediService
    {
        //public IhtiyacKrediManager()
        //{
        //    Console.WriteLine("İhtiyaç kredisi");
        //}

        public int KrediPuan { get; set; }
        public string Name { get; set; } = "para";

        public void Hesapla()
        {
            Console.WriteLine("ihtiyaç kredisi hesaplandı");
        }

        public void Hesapla2()
        {
            Console.WriteLine("2. ihtiyaç kredisi hesaplandı");
        }

        public void Bilgilendir()
        {
            Console.WriteLine($"{this.Name} kredisi alınabilir");
        }
    }
}
