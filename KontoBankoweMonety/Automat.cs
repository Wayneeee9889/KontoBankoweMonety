using System;
using System.Collections.Generic;
using System.Text;

namespace KontoBankoweMonety
{
    internal class Automat
    {

        private int _iloscmonet;

        public int IloscMonet
        {
            get { return _iloscmonet; }
        }



        public void wrzucMonete(KontoBankowe konto, double moneta)
        {
            switch (moneta)
            {
                case 1.0:
                    konto.Saldo = +1.0;
                    break;
                case 2.0:
                    konto.Saldo = +2.0;
                    break;
                case 5.0:
                    konto.Saldo = +5.0;
                    break;
                case 0.5:
                    konto.Saldo = +0.5;
                    break;
                case 0.2:
                    konto.Saldo = +0.2;
                    break;
                case 0.1:
                    konto.Saldo = +0.1;
                    break;
                default:
                    Console.WriteLine("niema takiej monety!");
                    break;
            }
        }
    }
}
