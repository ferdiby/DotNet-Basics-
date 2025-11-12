using OOP2;

//TuzelMusteri mehmetBey = new TuzelMusteri();
//mehmetBey.Id  = 38;
//mehmetBey.MusteriNo = "12345";

//CustomerManager musteriManager = new CustomerManager();
//musteriManager.Ekle(mehmetBey);
//Musteri m1 = new GercekMusteri();
//Musteri m2 = new TuzelMusteri();
//GercekMusteri g = new Musteri(); // It is not possible







//---------------------------------------------------------------------
//new C();
//B bObej = new B();
//bObej.Who();
//A cisim = new A();
//cisim.en = 4;
//cisim.boy = 5;

//Console.WriteLine(cisim.Alan());






// Most important phenomenon about Inheritance 
class A
{
    public int en;
    public int boy;
    public A()
    {
        Console.WriteLine("A dan nesne üretildi");
    }

    public void Who()
    {
        Console.WriteLine("Ben bir A yım");
    }

    public int Alan()
    {
        if (this.en == 0 & this.boy == 0)
            return 0;
        else
        {
            int a = this.en;
            int b = this.boy;
            return a * b;
        }

    }
}

class B : A
{
    public B()
    {
        Console.WriteLine("B den nesen üretildi");
    }

    public void Who()
    {
        Console.WriteLine("Ben bir B yim");
    }
}

class C : B
{
    public C()
    {
        Console.WriteLine("C den nesne üretildi");
    }
}