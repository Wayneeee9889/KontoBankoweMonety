namespace KontoBankoweMonety
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KontoBankowe KontoJana = new KontoBankowe("Jan" , 1234);

            Automat automat = new Automat();


            automat.wrzucMonete(KontoJana, 1234, "5");
            KontoJana.wyswietlInfo();
            automat.wrzucMonete(KontoJana, 1234,  "0,50");
            KontoJana.wyswietlInfo();
            automat.wrzucMonete(KontoJana, 1254, "0,50");
            KontoJana.wyswietlInfo();
            automat.wrzucMonete(KontoJana, 1234, "0,560");
            KontoJana.wyswietlInfo();
            
        }
    }
}
