using System;
using System.Collections.Generic;
using System.Text;

namespace Bibliotheksverwaltung.Core
{
    public class Bibliothek
    {
        // Liste von Büchern in der Bibliothek
         List<Buch> BuecherListe = new List<Buch>();

        public List<Buch> Buecher
        {
            get { return BuecherListe; }
        }


        // Methode zum Hinzufügen eines Buches zur Bibliothek
        public void BuchHinzufuegen(string titel, string autor, bool verfügbarkeit)
        {
            // Erstellen eines neuen Buchobjekts und Hinzufügen zur Bücherliste
            Buch buch = new Buch(titel, autor, verfügbarkeit);
            BuecherListe.Add(buch);

        }
        
        // Methode zum Anzeigen aller Bücher in der Bibliothek
        public void BuecherAusgabe()
        {
            // Durchlaufen der Bücherliste und Anzeigen der Informationen jedes Buches
            foreach (Buch buch in BuecherListe)
            {
                // Ausgabe der Buchinformationen in der Konsole
                Console.WriteLine("Titel: {0}, Autor: {1}, Verfügbarkeit: {2}", buch.Titel, buch.Autor, buch.Verfügbarkeit);
            }
        }
        
        // Methode zum Ausleihen eines Buches
        public void BuchAusleihen(string titel)
        {
            // Durchsuchen der Bücherliste nach dem Buch mit dem angegebenen Titel
            foreach (Buch buch in BuecherListe)
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
            foreach (Buch buch in BuecherListe)
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
        public void BuchSuchen(string titelsuche)
        {
            
            foreach (Buch buch in BuecherListe)
            {
                // schaut ob der Titel exestiert und ob es Veerfügbar ist 
                if (buch.Titel == titelsuche && buch.Verfügbarkeit == true)
                {
                    Console.WriteLine("Buch {0} gefunden!",titelsuche);
                }
                    
            }
                Console.WriteLine("Das Buch {0} ist leider nicht verfügbar", titelsuche);
                
        }

        
        public void BuchEntfernen(string titel)
        {
            // for schleife startet bei buechliste 0 so lange i kleiner als buecherListe.Count ist geht er  durch die Liste
            for (int i = 0; i < BuecherListe.Count; i++)
            {
                // Wenn der Buchtitel gefunden wurde wird das buch aus der buecherliste entfernt
                if (BuecherListe[i].Titel == titel)
                {
                    BuecherListe.RemoveAt(i);
                    Console.WriteLine("Das Buch '{0}' wurde entfernt.", titel);
                    return;
                }
            }
            
            Console.WriteLine("Das Buch '{0}' wurde nicht gefunden.", titel);
        }



    }
}


