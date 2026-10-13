namespace KontoBankoweMonety
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KontoBankowe KontoJana = new KontoBankowe("Jan", 0.5);

            Automat automat = new Automat();


            automat.wrzucMonete(KontoJana, 0.5);
            
        }
    }
}
