using System;
using System.Collections.Generic;
using System.Text;

namespace KontoBankoweMonety
{
    internal class KontoBankowe
    {

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
            set { }
            
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
                    Console.WriteLine("Błąd! Nazwa właćciciela nie może być pusta");
                }
            }
        }

        public KontoBankowe(string nowyWlasciciel, int pin, string numerKonta)
        {
            _wlasciciel = nowyWlasciciel;
            _pin = pin;
            
        }



// numer musi być generowany wraz z utworzeniem konta

        public void StanKonta()
        {
 
            Console.WriteLine($"Wlaściciel: {_wlasciciel}  |Saldo: {_saldo} ");
        }
    }
}
