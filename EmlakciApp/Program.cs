using EmlakciLİb;
using System;

namespace Emlakci.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region MyRegion
            /* Ev evim=new Ev();
                evim.alan = 100;
                evim.odasayisi = 2;
                evim.katno = 3;
                evim.semt = "Gazi";

                Ev evim2=new Ev();
                evim2.odasayisi = 3;
                evim2.alan = 110;
                evim2.katno = 4;
                evim2.semt = "Gazi";
                Console.WriteLine(evim.EvBilgileri());
                Console.WriteLine("*******");
                Console.WriteLine(evim2.EvBilgileri());*/
            #endregion

            var evim = new Ev();

            Console.Write("Alan giriniz :");
            evim.Alan = double.Parse(Console.ReadLine());
            Console.Write("Oda sayısı giriniz :");
            evim.SetOdaSayisi(int.Parse(Console.ReadLine()));
            Console.Write("Kat no giriniz :");
            evim.Katno = int.Parse(Console.ReadLine());
            Console.Write("Semt giriniz :");
            evim.Semt = Console.ReadLine();

            Console.WriteLine(evim.EvBilgileri());
            Console.WriteLine(evim.Buyukluk);

        }
    }

    //Fieldlar 2 farklı durumda kullanılabilir. Field'a değer atama işlemi yapılabilir ya da filed'ın değeri okunabilir.
    //SET: Fieldlara değer atama işlemi
    //GET: Fieldların değerinin okunması işlemi
    //Encapsulation-Kapsülleme: Class içinde tanımlanan üyelere değer ataması/okuması yapılırken kontrollü bir şekilde bu işlemleri yaparak hatalı değerler gelmesini engeller.


}
