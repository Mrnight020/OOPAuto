using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UkolOOPAuto
{
    internal class Auto
    {

        private string znacka;
        private double spotrebana100km;
        private int ujetoCelkem;
        private DateTime okamzikRozjedzu;
        private double dobaJizdyCelkem;
        private bool jede;

        public bool Jede { get => jede; }

        public Auto(string znacka, double spotreba, int ujetocelkem)
        {
            this.znacka = znacka;
            spotrebana100km= spotreba;
            ujetoCelkem = ujetocelkem;
            dobaJizdyCelkem = 0;
            jede = false;
        }

        public int VratUjeteKm()
        {
            return ujetoCelkem;
        }
        public void Rozjed()
        {
            okamzikRozjedzu = DateTime.Now;
            jede = true;
        }
        public void Zastav(int ujetykilometry)
        {
            if(Jede == true)
            {
                ujetoCelkem += ujetykilometry;
                DateTime datum = DateTime.Now;
                TimeSpan sekundy = datum - okamzikRozjedzu;
                dobaJizdyCelkem += sekundy.TotalSeconds;
                jede = false;
            }
        }
        public double Celkovaspotreba()
        {
            return ((ujetoCelkem * spotrebana100km) / 100);
        }

        public override string ToString()
        {
            return String.Format("Znacka : {0}\n" +
                                 "Jede ? : {1}\n" +
                                 "rozjeto v {2}\n" +
                                 "ujete kilometry: {3}\n" +
                                 "spotrebovane palivo : {4} l \n" +
                                 "celková doba jizd : {5} s\n"+
                                 "",znacka,Jede,okamzikRozjedzu, VratUjeteKm(), Celkovaspotreba(),Math.Round(dobaJizdyCelkem,2));
        }

    }
}
