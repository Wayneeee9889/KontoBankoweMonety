using System;
using System.Collections.Generic;
using System.Text;

namespace KontoBankoweMonety
{
    internal class KontoBankowe
    {


        //KontoBankowe kontoBankowe = new KontoBankowe("Jan Kowalski", 0.2);
        //kontoBankowe.wplac(0.1);

        //Console.Writeline(_saldo);
        private decimal _saldo;
        private string _wlasciciel;




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

        public KontoBankowe(string nowyWlasciciel)
        {
            _wlasciciel = nowyWlasciciel;
        }
// numer musi być generowany wraz z utworzeniem konta

        public void wyswietlInfo()
        {
            Console.WriteLine($"Wlaściciel: {_wlasciciel}  |Saldo: {_saldo} ");
        }
    }
}
