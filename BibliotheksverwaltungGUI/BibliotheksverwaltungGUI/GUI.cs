using Bibliotheksverwaltung.Core;
using System.Windows.Forms.Design.Behavior;

namespace BibliotheksverwaltungGUI
{
    public partial class Form1 : Form
    {
        private Bibliothek bibliothek = new Bibliothek();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }




        private void buech_entfernen(object sender, EventArgs e)
        {
            int selectedIndex = BuecherAnzeige.SelectedIndex;

            if (selectedIndex != -1)
            {
                Buch ausgewaehltesBuch = bibliothek.Buecher[selectedIndex];

                bibliothek.BuchEntfernen(ausgewaehltesBuch.Titel);

                AnzeigeAktualisieren();
            }
        }

        private void buch_hinzufügen(object sender, EventArgs e)
        {
            string titel = txtTitel.Text;
            string autor = txtAutor.Text;
            bibliothek.BuchHinzufuegen(titel, autor, true);
            txtTitel.Clear();
            txtAutor.Clear();
            AnzeigeAktualisieren();
        }

        private void BuecherAnzeige_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void AnzeigeAktualisieren()
        {
            BuecherAnzeige.Items.Clear();

            foreach (var buch in bibliothek.Buecher)
            {
                BuecherAnzeige.Items.Add($"{buch.Titel} - {buch.Autor}");
            }
        }
        public Buch BuchSuchen(string titel)
        {
            foreach (var buch in bibliothek.Buecher)
            {
                if (buch.Titel == titel)
                {
                    return buch;
                }
            }

            return null;
        }



        private void Such_box_TextChanged(object sender, EventArgs e)
        {
            string titel = TxtSuche.Text;
            Buch gefundenesBuch = BuchSuchen(titel);
        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            
            string titel = TxtSuche.Text;
            Buch gefundenesBuch = BuchSuchen(titel);
            MessageBox.Show("Das Buch " + gefundenesBuch.Titel + " wurde gefunden.");
            TxtSuche.Clear();
        }

    }
}

