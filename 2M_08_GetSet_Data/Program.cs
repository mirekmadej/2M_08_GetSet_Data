namespace _2M_08_GetSet_Data
{
    class Uczen
    {
        public int id { get; private set; }
        public string imie { get; private set; }
        public string nazwisko { get; private set; }
        public DateTime dataUr { get; private set; }
        public Uczen(int Nr , string Imie ,
            string Nazwisko , 
            DateTime DataUr )
        {
            id = Nr;
            imie = Imie;
            nazwisko= Nazwisko;
            dataUr = DataUr;
        }
        public override string ToString()
        {
            return $"{id}\t{imie} {nazwisko} " +
                $"{dataUr.ToString("yyyy-MM-dd")}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Uczen u1 = new Uczen(1,"Jan", "Kot",DateTime.Now);
            Console.WriteLine(u1);
            DateTime dzis = DateTime.Now;
            DateTime dur = new DateTime(2004,01,01);
            var d2 = dzis - dur;
            bool czyDorosly = false;
            var lat18 = dzis - dzis.AddYears(-18);
            var ileLat = dzis - dur;
            if(ileLat > lat18)
                czyDorosly = true;
            Console.WriteLine(czyDorosly);
        }
    }
}