 namespace Bibliotheksverwaltung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bibliothek bibliothek = new Bibliothek();
            bibliothek.BuchHinzufuegen("Der Herr der Ringe", "J.R.R. Tolkin", true);
            bibliothek.BuchHinzufuegen("Harry Potter", "J.K. Rowling", false);
            bibliothek.BuchHinzufuegen("Die unendliche Geschichte", "Michael Ende", true);
            bibliothek.BuchHinzufuegen("Der kleine Prinz", "Antoine de Saint-Exupéry", true);
            bibliothek.BuchHinzufuegen("1984", "George Orwell", false);
            bibliothek.BuchHinzufuegen("Die Verwandlung", "Franz Kafka", true);
            bibliothek.BuchHinzufuegen("Faust", "Johann Wolfgang von Goethe", true);
            


            
            string auswahl = "";
            while (auswahl != "5")
            {
                
                Console.WriteLine("1. Buch hinzufügen");
                Console.WriteLine("2. Bücher anzeigen");
                Console.WriteLine("3. Buch ausleihen");
                Console.WriteLine("4. Buch zurückgeben");
                Console.WriteLine("5. Beenden");
                Console.WriteLine("Was wollen sie Tun?");
                auswahl = Console.ReadLine();

                switch (auswahl)
                {
                    case "1":
                    {
                      Console.WriteLine("geben Sie den Namen des Buches ein:");
                      string name = Console.ReadLine();
                      Console.WriteLine("geben Sie den Autor des Buches ein:");
                      string autor = Console.ReadLine();
                      Console.WriteLine("ist das Buch verfügbar? (true/false)");
                      bool verfuegbarkeit = bool.Parse(Console.ReadLine()!);
                      bibliothek.BuchHinzufuegen(name, autor, verfuegbarkeit);
                    } break;
                      
                    case "2":
                    {
                     bibliothek.BuecherAnzeigen();
                    }break;




                    case "3":
                    {
                     Console.WriteLine("geben Sie den Titel des Buches ein, das Sie ausleihen möchten:");
                     string titelAusleihen = Console.ReadLine();
                     Console.WriteLine("Eingegeben: {0}", titelAusleihen);
                     bibliothek.BuchAusleihen(titelAusleihen);
                    }break;






                        case "4":
                    {
                     Console.WriteLine("gebene sie den Titel des Buches ein, das Sie zurückgeben möchten:");
                     string titelZurueckgeben = Console.ReadLine();
                     bibliothek.BuchZurueckgeben(titelZurueckgeben);
                    }break;

                    case "5":
                    {
                     Console.WriteLine("Programm wird beendet.");
                    }break;
                }
            }
        }
    }
 }


