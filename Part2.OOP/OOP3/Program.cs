using OOP3;

//// new IKrediManager(); //interfaces can not make an object!!
IKrediService kM = new IhtiyacKrediManager();
IKrediService kM2 = new TasitKrediManager();
////kM.Hesapla();
//Console.WriteLine("--------------------------------");
//new BasvuruManager().BasvuruYap(kM2);
BasvuruManager basvuruManager = new BasvuruManager();
ILoggerService fileLoggerService = new FileLoggerService();
ILoggerService dbLoggerService = new DatabaseLoggerService();
List<ILoggerService> loggerList = new List<ILoggerService>() { fileLoggerService, dbLoggerService };
basvuruManager.BasvuruYap(kM, loggerList);
Console.WriteLine("--------------------------------");
new BasvuruManager().BasvuruYap(kM2,new List<ILoggerService>(){dbLoggerService,fileLoggerService});

//Console.WriteLine("--------------------------------");
//kM.KrediPuan = 12;
//kM2.KrediPuan = 7;
//List<IKrediService> krediler = new List<IKrediService>(){kM,kM2};
//basvuruManager.KrediBilgilendirme(krediler);

