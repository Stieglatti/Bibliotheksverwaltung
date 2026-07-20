using Bibliotheksverwaltung.Core;
namespace Bibliotheksverwaltung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bücher zur Bibliothek hinzufügen
            Bibliothek bibliothek = new Bibliothek();
            bibliothek.BuchHinzufuegen("Der Herr der Ringe", "J.R.R. Tolkin", true);
            bibliothek.BuchHinzufuegen("Harry Potter", "J.K. Rowling", false);
            bibliothek.BuchHinzufuegen("Die unendliche Geschichte", "Michael Ende", true);
            bibliothek.BuchHinzufuegen("Der kleine Prinz", "Antoine de Saint-Exupéry", true);
            bibliothek.BuchHinzufuegen("1984", "George Orwell", false);
            bibliothek.BuchHinzufuegen("Die Verwandlung", "Franz Kafka", true);
            bibliothek.BuchHinzufuegen("Faust", "Johann Wolfgang von Goethe", true);



            // Menü für die Bibliotheksverwaltung
            string auswahl = "";
            while (auswahl != "7")
            {
                Console.WriteLine("Was wollen sie Tun?");
                Console.WriteLine("1. Buch hinzufügen");
                Console.WriteLine("2. Bücher anzeigen");
                Console.WriteLine("3. Buch ausleihen");
                Console.WriteLine("4. Buch zurückgeben");
                Console.WriteLine("5. Buch entfernen");
                Console.WriteLine("6. Buch suchen");
                Console.WriteLine("7. Beenden");
                
                auswahl = Console.ReadLine();

                // Auswahl des Benutzers verarbeiten
                switch (auswahl)
                {
                    // Buch hinzufügen
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

                    // Bücher anzeigen
                    case "2":
                    {
                     bibliothek.BuecherAusgabe();
                    }break;

                    // Buch ausleihen
                    case "3":
                    {
                     Console.WriteLine("geben Sie den Titel des Buches ein, das Sie ausleihen möchten:");
                     string titelAusleihen = Console.ReadLine();
                     Console.WriteLine("Eingegeben: {0}", titelAusleihen);
                     bibliothek.BuchAusleihen(titelAusleihen);
                    }break;

                    // Buch zurückgeben
                    case "4":
                    {
                     Console.WriteLine("Gebene sie den Titel des Buches ein, das Sie zurückgeben möchten:");
                     string titelZurueckgeben = Console.ReadLine();
                     bibliothek.BuchZurueckgeben(titelZurueckgeben);
                    }break;

                     case "5":
                     {
                            Console.WriteLine("Welches Buch sollte entfernt werden bitte geben sie den Titel ein");
                            string BuchEntfernen = Console.ReadLine();
                            bibliothek.BuchEntfernen(BuchEntfernen);
                     }break;

                     case"6":
                     { 
                      Console.WriteLine("Titel eingeben:");
                      string titelsuche = Console.ReadLine();
                      bibliothek.BuchSuchen(titelsuche);

                     }break;

                    // Beenden des Programms
                    case "7":
                    {
                     Console.WriteLine("Programm wird beendet.");
                    }break;
                }
            }
        }
    }
 }


