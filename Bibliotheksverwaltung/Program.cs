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
            bibliothek.BuecherAnzeigen();   
        }
    }
}
