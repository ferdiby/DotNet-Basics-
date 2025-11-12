using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace OOP3
{
    internal class BasvuruManager
    {
        public void BasvuruYap(IKrediService iKM, List<ILoggerService> loggerService)
        {
            iKM.Hesapla();
            foreach (var service in loggerService)
            {
                service.Log();
            }
        }

        public void KrediBilgilendirme(List<IKrediService> krediler)
        {
            foreach (var obj in krediler)
            {
                if (obj.KrediPuan > 10)
                    obj.Bilgilendir();
                else
                    Console.WriteLine("Krediye uygun değil");
            }

        }
    }
}
