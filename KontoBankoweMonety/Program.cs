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

            automat.Wplac(KontoJana, 1254, "0,50");
            KontoJana.StanKonta();

            automat.Wplac(KontoJana, 1234, "0,560");
            KontoJana.StanKonta();

            automat.Wplac(KontoJana, 1234, "6");

            KontoBankowe KontoB = new KontoBankowe("", 298 );

            KontoB.StanKonta();


        }
    }
}
