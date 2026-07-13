using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotheksverwaltungGUI
{
        internal class Buch
        {
            // Klasse Buch mit den Eigenschaften Titel, Autor und Verfügbarkeit
            public string Titel { get; set; }
            public string Autor { get; set; }
            public bool Verfügbarkeit { get; set; }

            // Konstruktor der Klasse Buch
            public Buch(string titel, string autor, bool verfügbarkeit)
            {
                this.Titel = titel;
                this.Autor = autor;
                this.Verfügbarkeit = verfügbarkeit;
            }

            // Default-Konstruktor der Klasse Buch
            public Buch()
            {
                this.Titel = "";
                this.Autor = "";
                this.Verfügbarkeit = false;
            }


        }
}

