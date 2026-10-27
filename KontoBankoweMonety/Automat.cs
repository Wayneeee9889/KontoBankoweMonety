using System;
using System.Collections.Generic;
using System.Globalization;
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

        private readonly decimal[] _przyjmowaneMonety = new decimal[] { 5, 2, 1, 0.5m, 0.2m, 0.1m };

        public void wrzucMonete(KontoBankowe konto, int Pin, string Moneta)
        {
            string monetaUjednoliczonyzapis = Moneta.Replace(",", ".");


            if(Pin == konto.Pin){
                bool czyUdanyParse = decimal.TryParse(Moneta, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture ,out decimal wartoscMonety);

                if (!czyUdanyParse)
                {
                    Console.WriteLine("Nieudany odczyt");
                    return;
                }
                //sprawdż czy rzucona moneta jest z zakresu _przyjmowaneMonety

                foreach (decimal nominal in _przyjmowaneMonety)
                {
                    if (wartoscMonety == nominal)
                    {
                        konto.Saldo += nominal;
                        _iloscmonet++;
                        Console.WriteLine("wrzucono: " + nominal);
                    }
                    else
                    {
                        Console.WriteLine("nierozpoznana moneta");
                        return;
                    }
                }
            }
            else
            {
                Console.WriteLine("Niepoprawny pin");
            }


            //Console.WriteLine($"Wrzuconmo monetę o wartosci: {wartosc}");
        


            //switch (moneta)
            //{
            //    case 1.0:
            //        konto.Saldo += 1.0;
            //        Console.WriteLine("Wrzucono 1zł");
            //        _iloscmonet += 1;
            //        break;
            //    case 2.0:
            //        konto.Saldo += 2.0;
            //        Console.WriteLine("Wrzucono 2zł");
            //        _iloscmonet += 1;
            //        break;
            //    case 5.0:
            //        konto.Saldo += 5.0;
            //        Console.WriteLine("Wrzucono 5zł");
            //        _iloscmonet += 1;
            //        break;
            //    case 0.5:
            //        konto.Saldo += 0.5;
            //        Console.WriteLine("Wrzucono 0.50zł");
            //        _iloscmonet += 1;
            //        break;
            //    case 0.2:
            //        konto.Saldo += 0.2;
            //        Console.WriteLine("Wrzucono 0.20zł");
            //        _iloscmonet += 1;
            //        break;
            //    case 0.1:
            //        konto.Saldo += 0.1;
            //        Console.WriteLine("Wrzucono 0.10zł");
            //        _iloscmonet += 1;
            //        break;
            //    default:
            //        Console.WriteLine("niema takiej monety!");
            ////        break;
            //}
        }
    }
}
