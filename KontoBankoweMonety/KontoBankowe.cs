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
        private double _saldo;
        private string _wlasciciel;




        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                _saldo = Saldo;

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

        public KontoBankowe(string nowyWlasciciel, double Saldo)
        {
            _wlasciciel = nowyWlasciciel;
            _saldo = Saldo;
        }

        public void wyswietlInfo()
        {
            Console.WriteLine($"Wlaściciel: {_wlasciciel}  |Saldo: {_saldo} ");
        }
    }
}
