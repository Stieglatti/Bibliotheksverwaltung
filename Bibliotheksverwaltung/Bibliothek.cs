using System;
using System.Collections.Generic;
using System.Text;

namespace Bibliotheksverwaltung
{
    internal class Bibliothek
    {
        // Liste von Büchern in der Bibliothek
        List<Buch> buecherListe = new List<Buch>();

        // Methode zum Hinzufügen eines Buches zur Bibliothek
        public void BuchHinzufuegen(string titel, string autor, bool verfügbarkeit)
        {
            // Erstellen eines neuen Buchobjekts und Hinzufügen zur Bücherliste
            Buch buch = new Buch(titel, autor, verfügbarkeit);
            buecherListe.Add(buch);

        }
        
        // Methode zum Anzeigen aller Bücher in der Bibliothek
        public void BuecherAnzeigen()
        {
            // Durchlaufen der Bücherliste und Anzeigen der Informationen jedes Buches
            foreach (Buch buch in buecherListe)
            {
                // Ausgabe der Buchinformationen in der Konsole
                Console.WriteLine("Titel: {0}, Autor: {1}, Verfügbarkeit: {2}", buch.Titel, buch.Autor, buch.Verfügbarkeit);
            }
        }
        
        // Methode zum Ausleihen eines Buches
        public void BuchAusleihen(string titel)
        {
            // Durchsuchen der Bücherliste nach dem Buch mit dem angegebenen Titel
            foreach (Buch buch in buecherListe)
            {
                // Überprüfen, ob das Buch verfügbar ist
                if (buch.Titel == titel && buch.Verfügbarkeit == true)
                {
                    // Das Buch ist verfügbar, daher wird es ausgeliehen
                    buch.Verfügbarkeit = false;
                    Console.WriteLine("Das Buch '{0}' wurde erfolgreich ausgeliehen.", titel);
                    return;
                }
            }
            // Wenn das Buch nicht verfügbar ist, wird eine entsprechende Meldung ausgegeben
            Console.WriteLine("Das Buch '{0}' ist nicht verfügbar.", titel);
        }
        
        
        // Methode zum Zurückgeben eines Buches
        public void BuchZurueckgeben(string titel)
        {
            foreach (Buch buch in buecherListe)
            {
                // Überprüfen, ob das Buch mit dem angegebenen Titel gefunden wurde und ob es ausgeliehen ist
                if (buch.Titel == titel && buch.Verfügbarkeit == false)
                {
                    // Das Buch wird zurückgegeben und die Verfügbarkeit wird auf true gesetzt
                    Console.WriteLine("Das Buch '{0}' wurde erfolgreich zurückgegeben.", titel);
                    buch.Verfügbarkeit = true;
                    return;
                }
                
                   
            }
        }





    }
}    
