using System;
using System.Collections.Generic;
using System.Text;

namespace Bibliotheksverwaltung
{
    internal class Bibliothek
    {
        List<Buch> buecherListe = new List<Buch>();


        public void BuchHinzufuegen(string titel, string autor, bool verfügbarkeit)
        {
            Buch buch = new Buch(titel, autor, verfügbarkeit);
            buecherListe.Add(buch);
            
        }

        public void BuecherAnzeigen()
        {
            foreach (Buch buch in buecherListe)
            {
                Console.WriteLine("Titel: {0}, Autor: {1}, Verfügbarkeit: {2}", buch.Titel, buch.Autor, buch.Verfügbarkeit);
            }
        }
    }
}
