using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class KonutKrediManager : IKrediService
    {
        public int KrediPuan { get; set; }
        public string Name { get; set; }

        public void Hesapla()
        {
            Console.WriteLine("konut kredisi hesaplandı");

        }

        public void Bilgilendir()
        {
        }
    }
}
