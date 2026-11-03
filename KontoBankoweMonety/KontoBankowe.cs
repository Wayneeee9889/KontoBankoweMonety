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
            set{}
        }

        public string Wlasciciel
        {
            get
            {
                return _wlasciciel;
            }
            set
            {
                //walidacja
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _wlasciciel = value;
                }
                else
                {
                    throw new ArgumentException("Błąd! Nazwa właciciela nie może być pusta");
                }
            }
        }

        public KontoBankowe(string nowyWlasciciel, int ustawionyPin)
        {
            Wlasciciel = nowyWlasciciel;    
            _saldo = 0;
            int liczbaDopuszczalnaPin = 4;
            if(ustawionyPin.ToString().Length < liczbaDopuszczalnaPin && ustawionyPin.ToString().Length > 4)
            {
                _pin = 0000;
                throw new ArgumentException("Pin musi zawierać 4 liczby! Ustawiono domyślnie 0000.");
            }
            else
            {
                _pin = ustawionyPin;
            }
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
