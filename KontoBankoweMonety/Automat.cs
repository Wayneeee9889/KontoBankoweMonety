using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
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

        public void Wplac(KontoBankowe konto, int Pin, string Monety)
        {
            
           

            if (Pin == konto.Pin){
                string monetaUjednoliconyZapis = Monety.Replace(",", ".");
                bool czyUdanyParse = decimal.TryParse(monetaUjednoliconyZapis, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out decimal wartoscMonety);


                if (!czyUdanyParse)
                {
                    Console.WriteLine("Nieudany odczyt monety");
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
                        break;
                    }
        
                }
            }
            else
            {
                Console.WriteLine("Niepoprawny pin");
            }
        }
        public void PokazMonety()
        {
            Console.WriteLine(_iloscmonet);
        }








    }
}
