
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
            
            people.Sort((x,y) => x.Artiklar.CompareTo(y.Artiklar));
            foreach (var s in people)
            {
                Console.WriteLine("Namn Personnunmmer Distrikt Artiklar");
                Console.WriteLine($"{s.Namn} {s.Personnummer} {s.Distrikt} {s.Artiklar}");
            }
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

