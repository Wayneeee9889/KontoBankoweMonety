using System;
using System.Collections.Generic;
using System.Text;

namespace KontoBankoweMonety
{
    internal class KontoBankowe
    {
        Random rnd = new Random();
       
        private decimal _saldo;
        private string _wlasciciel;
        private int _pin;
        private string _numerKonta;

     
        



        public string NumerKonta
        {
            get
            {
                return _numerKonta;
            }
            set {}
            
        }


        public decimal Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                _saldo = value;

            }
        }

        public int Pin
        {
            get
            {
                return _pin;
            }
            set
            {
                if (value.ToString().Length == 4)
                {
                    _pin = value;
                }
                else
                {
                    _pin = 0000;
                    throw new ArgumentException("Błąd: Pin ma mieć dokładnie 4 cyfry.");
                }
            }
        }

        public string Wlascicel
        {
            get
            {
                return _wlasciciel;
            }
            set
            {
                //walidacja
                if (value == string.Empty)
                {
                    throw new ArgumentException("Błąd: nazwa wlaściciela nie może być pusta!");
                }
                else
                {
                    _wlasciciel = value;
                }
            }
        }

        public KontoBankowe(string nowyWlasciciel, int ustawionyPin)
        {
            Wlascicel = nowyWlasciciel;    
            _saldo = 0;
            Pin = ustawionyPin;
            
       
            Console.WriteLine($"Ustawiono nowy pin dla konta {_wlasciciel}");


            
            int liczbaLiczbWSekwencjiNumeru = 24;

            for (int i = 0; i < liczbaLiczbWSekwencjiNumeru; i++)
            {
                var nastepnaLiczbaNumeru = rnd.Next(0, 10);
                _numerKonta = _numerKonta += nastepnaLiczbaNumeru.ToString();
            }

        }



// numer musi być generowany wraz z utworzeniem konta

        public void StanKonta()
        {
 
            Console.WriteLine($"Wlaściciel: {_wlasciciel}  |Saldo: {_saldo} |Nr konta: {_numerKonta}");
        }
    }
}
