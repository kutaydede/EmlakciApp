using System;

namespace Personel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var p = new personel();
            Console.WriteLine("Adınızı Giriniz");
            p.Ad = Console.ReadLine();
            Console.WriteLine("Soyadınızı Gİriniz");
            p.Soyad = Console.ReadLine();
            Console.WriteLine("Giriş Yılınız Giriniz");
            p.Girisyil = int.Parse(Console.ReadLine());

            Console.WriteLine(p.PersonelBilgi());
        }
    }
    class personel
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }

        private double maas;
        public double Maas { get => maas; }


        private int girisyil;

        public int Girisyil
        {
            get { return girisyil; }
            set
            {
                girisyil = value;
                this.maas = 10000 + ((DateTime.Now.Year - girisyil) * 1000);
            }
        }
        public string PersonelBilgi() => $"{this.Ad} {this.Soyad} adlı personel'in maaşı : {this.maas} ";



    }

}
