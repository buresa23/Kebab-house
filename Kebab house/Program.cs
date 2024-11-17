namespace Kebab_house
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sklad sklad = new Sklad(100, 100, 100);
            Console.WriteLine(sklad.ZasobaMasa + "Masa " + sklad.ZasobaZelí + "Zelí ");

            List<Kebaby> menu = new List<Kebaby>
            {
                new Kebaby("Klasický kebab", 50, 30, 20),
                new Kebaby("Kebab s extra masem",75, 30, 20 ),
                new Kebaby("Kebab s extra zeleninou", 50, 40, 30)
            };
            
            

            
            
            
        }
    }
}
