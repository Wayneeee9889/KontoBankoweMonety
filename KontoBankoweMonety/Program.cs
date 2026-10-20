namespace KontoBankoweMonety
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KontoBankowe KontoJana = new KontoBankowe("Jan");

            Automat automat = new Automat();


            automat.wrzucMonete(KontoJana, "5");
            KontoJana.wyswietlInfo();
            automat.wrzucMonete(KontoJana, "5");
            KontoJana.wyswietlInfo();
        }
    }
}
