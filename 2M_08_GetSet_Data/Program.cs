namespace _2M_08_GetSet_Data
{
    class Uczen
    {
        public int id { get; private set; }
        public string imie { get; private set; }
        public string nazwisko { get; private set; }
        public DateTime dataUr { get; private set; }
        public bool czyDorosly { get
            {
                DateTime dzis = DateTime.Today;
                var d2 = dzis - dataUr;
                bool czyDorosly = false;
                var lat18 = dzis - dzis.AddYears(-18);
                var ileLat = dzis - dataUr;
                if (ileLat >= lat18)
                    czyDorosly = true;
                return czyDorosly;
            } 
        }
        public Uczen(int Nr, string Imie ,
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
           // string dorosly = czyDorosly ? "dorosły" : "nie dorosły";
            return $"{id}\t{imie} {nazwisko} " 
               + $"{dataUr.ToString("yyyy-MM-dd")} " 
               + $"{(czyDorosly ? "dorosły" : "nie dorosły")}";
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
            Console.Write("czas do końca zajęć: ");
            //tu kod

        }
    }
}