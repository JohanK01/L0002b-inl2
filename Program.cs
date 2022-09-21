List<SalesMen> people = new List<SalesMen>();
bool status = true;
while (status)
{
    Console.WriteLine("Lägga in säljare: 1");
    Console.WriteLine("Visa lista över säljare: 2");
    Console.WriteLine("Avsluta program: 3");

    int navigate = Int32.Parse(Console.ReadLine());
    Console.Clear();

    switch (navigate)
    {
        case 1:
            //Här lägger man in personer i en List<T>
            Console.WriteLine("Namn, Personnummer, Distrikt, Artiklar sålda");
            people.Add(new SalesMen()
            {
                Namn = Console.ReadLine(),
                Personnummer = Int32.Parse(Console.ReadLine()),
                Distrikt = Console.ReadLine(),
                Artiklar = Int32.Parse(Console.ReadLine())
            });
            Console.Clear();

            break;
        case 2:
            //här soteras alla utifrån hur mycket dem har sålt
            Console.WriteLine("Namn Personnunmmer Distrikt Artiklar");

            //här skrivs resultatet ner i en fil
            string fileName = "Resultat.txt";
            FileStream fs = null;
            fs = new FileStream(fileName, FileMode.OpenOrCreate);
            StreamWriter tw = new StreamWriter(fs);

            //sortering 
            people.Sort((x, y) => x.Artiklar.CompareTo(y.Artiklar));

            int lvl1 = people.FindAll(x => x.Artiklar < 50).Count();
            foreach (var p in people.FindAll(x => x.Artiklar < 50))
            {

                Console.WriteLine($"{p.Namn} {p.Personnummer} {p.Distrikt} {p.Artiklar}");
                tw.WriteLine($"{p.Namn} {p.Personnummer} {p.Distrikt} {p.Artiklar}")


            }
            Console.WriteLine($"{lvl1} under 50");

            int lvl2 = people.FindAll(x => x.Artiklar >= 50 && x.Artiklar <= 99).Count();
            foreach (var p in people.FindAll(x => x.Artiklar >= 50 && x.Artiklar <= 99))
            {
                Console.WriteLine($"{p.Namn} {p.Personnummer} {p.Distrikt} {p.Artiklar}");
                tw.WriteLine($"{p.Namn} {p.Personnummer} {p.Distrikt} {p.Artiklar}");


            }
            Console.WriteLine($"{lvl2} mellan 50-99");

            int lvl3 = people.FindAll(x => x.Artiklar >= 100 && x.Artiklar <= 199).Count();
            foreach (var p in people.FindAll(x => x.Artiklar >= 100 && x.Artiklar <= 199))
            {
                Console.WriteLine($"{p.Namn} {p.Personnummer} {p.Distrikt} {p.Artiklar}");
                tw.WriteLine($"{p.Namn} {p.Personnummer} {p.Distrikt} {p.Artiklar}");


            }
            Console.WriteLine($"{lvl3} mellan 100-199");

            int lvl4 = people.FindAll(x => x.Artiklar > 200).Count();
            foreach (var p in people.FindAll(x => x.Artiklar > 200))
            {
                Console.WriteLine($"{p.Namn} {p.Personnummer} {p.Distrikt} {p.Artiklar}");
                tw.WriteLine($"{p.Namn} {p.Personnummer} {p.Distrikt} {p.Artiklar}");

            }
            Console.WriteLine($"{lvl4} över 200");

            //här stängs Resultat.txt filen
            tw.Close();
            break;

        case 3:
            status = false;
            break;

        default:
            break;
    }
}



public class SalesMen
{
    public string Namn { get; set; }
    public int Personnummer { get; set; }
    public string Distrikt { get; set; }
    public int Artiklar { get; set; }

}

