namespace KontoBankoweMonety
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KontoBankowe KontoJana = new KontoBankowe("Jan" , 1234);

            Automat automat = new Automat();


            automat.Wplac(KontoJana, 1234, "5");
            KontoJana.StanKonta();

            automat.Wplac(KontoJana, 1234,  "0.50");
            KontoJana.StanKonta();

            automat.Wplac(KontoJana, 1234, "0,5");
            KontoJana.StanKonta();

            automat.Wplac(KontoJana, 1234, "0,560");
            KontoJana.StanKonta();

            automat.Wplac(KontoJana, 1234, "");

            KontoBankowe KontoB = new KontoBankowe("sdadd", 2987 );

            KontoB.StanKonta();


        }
    }
}
