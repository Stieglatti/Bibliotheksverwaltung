using Bibliotheksverwaltung.Core;

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

        private void button1_Click(object sender, EventArgs e)
        {
            string titel = txtTitel.Text;
            string autor = txtAutor.Text;
            bibliothek.BuchHinzufuegen(titel, autor, true);
            MessageBox.Show("Buch erfolgreich hinzugefügt.");

            // Macht das Textfeld wieder leer, nachdem das Buch hinzugefügt wurde
            txtAutor.Clear();
            txtTitel.Clear();
            // Fügt den Titel des Buches zur ListBox hinzu
            listBox1.Items.Add(titel);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
