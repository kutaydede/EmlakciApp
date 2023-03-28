using System;

namespace EmlakciLİb
{
    public class Ev
    {

        private int odasayisi;//field
        private int katno;
        private string semt;
        private string buyukluk;

        private double alan;

        public double Alan
        {
            get
            {
                return alan;
            }
            set
            {
                alan = value;
                if (alan < 70)
                {
                    buyukluk = "Küçük Ev";
                }
                else if (alan > 70 && alan < 120)
                {
                    buyukluk = "Orta Büyüklükte Ev";
                }
                else
                {
                    buyukluk = "Büyük Ev";
                }

            }
        }


        public int Katno { get => katno; set => katno = value; }
        public string Semt { get => semt; set => semt = value.ToUpper(); }
        public string Buyukluk { get => buyukluk; }

        public void SetOdaSayisi(int odasayisi) => this.odasayisi = Math.Abs(odasayisi);

        public int GetOdaSayisi() => odasayisi;

        public string EvBilgileri() => $"Alan :{this.Alan}\nOda Sayısı :{this.odasayisi}\nKat No : {this.Katno}\nSemt :{this.Semt}\nBüyüklük :{this.buyukluk}";


    }
}
