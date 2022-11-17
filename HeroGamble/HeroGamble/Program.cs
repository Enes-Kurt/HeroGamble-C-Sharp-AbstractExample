using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroGabmle
{
    public abstract class Karakter
    {
        protected Random RastgeleSayı = new Random();
        public string _KarakterAdı
        { get; set; }
        public string _KarakterSınıfı
        { get; set; }

        public void EkranaYaz()
        {
            Console.WriteLine($"Karakterin Büyü Hasarı:  {BüyüHasarı()}");
            Console.WriteLine($"Karakterin Büyü Defansı: {BüyüDefansı()}");
            Console.WriteLine($"Karakterin Fiziksel Hasarı: {FizikselHasar()}");
            Console.WriteLine($"Karakterin Fiziksel Defansı: {FizikselDefans()}");
            Console.WriteLine($"Karakterin Can Puanı: {CanPuanı()}");
            int YıldızPuanı = BüyüHasarı() + FizikselHasar() + FizikselDefans() + BüyüDefansı() + CanPuanı();
            if (_KarakterSınıfı == "Büyücü" && YıldızPuanı > 360)
            {
                Console.WriteLine($"Karakterin 5 yıldızlı {_KarakterSınıfı}.");
            }
            else if (_KarakterSınıfı == "Büyücü" && YıldızPuanı > 330)
            {
                Console.WriteLine($"Karakterin 4 yıldızlı {_KarakterSınıfı}.");
            }
            else if (_KarakterSınıfı == "Büyücü" && YıldızPuanı > 290)
            {
                Console.WriteLine($"Karakterin 3 yıldızlı {_KarakterSınıfı}.");
            }
            else if (_KarakterSınıfı == "Büyücü" && YıldızPuanı > 250)
            {
                Console.WriteLine($"Karakterin 2 yıldızlı {_KarakterSınıfı}.");
            }
            else if (_KarakterSınıfı == "Büyücü" && YıldızPuanı > 210)
            {
                Console.WriteLine($"Karakterin 1 yıldızlı {_KarakterSınıfı}.");
            }
            else if (_KarakterSınıfı == "Savaşçı" && YıldızPuanı > 375)
            {
                Console.WriteLine($"Karakterin 5 yıldızlı {_KarakterSınıfı}.");
            }
            else if (_KarakterSınıfı == "Savaşçı" && YıldızPuanı > 335)
            {
                Console.WriteLine($"Karakterin 4 yıldızlı {_KarakterSınıfı}.");
            }
            else if (_KarakterSınıfı == "Savaşçı" && YıldızPuanı > 290)
            {
                Console.WriteLine($"Karakterin 3 yıldızlı {_KarakterSınıfı}.");
            }
            else if (_KarakterSınıfı == "Savaşçı" && YıldızPuanı > 245)
            {
                Console.WriteLine($"Karakterin 2 yıldızlı {_KarakterSınıfı}.");
            }
            else if (_KarakterSınıfı == "Savaşçı" && YıldızPuanı > 200)
            {
                Console.WriteLine($"Karakterin 1 yıldızlı {_KarakterSınıfı}.");
            }

        }

        abstract public int BüyüHasarı();
        abstract public int FizikselHasar();
        abstract public int BüyüDefansı();
        abstract public int FizikselDefans();
        abstract public int CanPuanı();

    }




    public class Büyücü : Karakter
    {

        override public int BüyüHasarı()
        {

            return RastgeleSayı.Next(80, 100);
        }
        override public int FizikselHasar()
        {
            return RastgeleSayı.Next(40, 80);
        }
        override public int BüyüDefansı()
        {
            return RastgeleSayı.Next(60, 100);
        }
        override public int FizikselDefans()
        {
            return RastgeleSayı.Next(10, 50);
        }
        override public int CanPuanı()
        {
            return RastgeleSayı.Next(20, 50);
        }


    }
    public class Savaşçı : Karakter
    {

        override public int BüyüHasarı()
        {

            return RastgeleSayı.Next(10, 30);
        }
        override public int FizikselHasar()
        {
            return RastgeleSayı.Next(60, 100);
        }
        override public int BüyüDefansı()
        {
            return RastgeleSayı.Next(20, 70);
        }
        override public int FizikselDefans()
        {
            return RastgeleSayı.Next(60, 100);
        }
        override public int CanPuanı()
        {
            return RastgeleSayı.Next(50, 100);
        }


    }


    internal class Program
    {

        static private void Olustur(int a)
        {
            if (a == 1)
            {

                Karakter karakter = new Büyücü();
                karakter._KarakterSınıfı = "Büyücü";
                karakter.EkranaYaz();
            }
            else if (a == 2)
            {
                Karakter karakter = new Savaşçı();
                karakter._KarakterSınıfı = "Savaşçı";
                karakter.EkranaYaz();
            }
            else Console.WriteLine("Hatalı giriş yaptınız. Lütfen 1 yada 2 şeklinde giriş yapınız.");
        }


        static void Main(string[] args)
        {
        bas:
            Console.WriteLine("Karakter Sınıfı Seçiniz");
            Console.WriteLine("1- Büyücü \n2- Savaşçı");
            int a = Convert.ToInt32(Console.ReadLine());
            Program.Olustur(a);
            Console.WriteLine("--------------------");

            Console.WriteLine("Tekar denemek istermisiniz...? y/n");
            if (Console.ReadLine() == "y") goto bas;

        }

    }
}

