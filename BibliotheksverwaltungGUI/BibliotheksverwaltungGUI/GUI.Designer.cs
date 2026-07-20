namespace BibliotheksverwaltungGUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtTitel = new TextBox();
            txtAutor = new TextBox();
            button1 = new Button();
            BuecherAnzeige = new ListBox();
            Buchenfernen = new Button();
            buch_suche = new Label();
            TxtSuche = new TextBox();
            Search_button = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(122, 15);
            label1.Name = "label1";
            label1.Size = new Size(62, 35);
            label1.TabIndex = 0;
            label1.Text = "Titel:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(109, 72);
            label2.Margin = new Padding(5);
            label2.Name = "label2";
            label2.Size = new Size(75, 42);
            label2.TabIndex = 1;
            label2.Text = "Autor:";
            label2.Click += label2_Click;
            // 
            // txtTitel
            // 
            txtTitel.Location = new Point(190, 15);
            txtTitel.Multiline = true;
            txtTitel.Name = "txtTitel";
            txtTitel.Size = new Size(118, 35);
            txtTitel.TabIndex = 2;
            txtTitel.TextChanged += textBox1_TextChanged;
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(190, 72);
            txtAutor.Multiline = true;
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(118, 36);
            txtAutor.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(374, 7);
            button1.Name = "button1";
            button1.Size = new Size(88, 43);
            button1.TabIndex = 4;
            button1.Text = "Buch hinzufügen";
            button1.UseVisualStyleBackColor = true;
            button1.Click += buch_hinzufügen;
            // 
            // BuecherAnzeige
            // 
            BuecherAnzeige.FormattingEnabled = true;
            BuecherAnzeige.Location = new Point(190, 300);
            BuecherAnzeige.Name = "BuecherAnzeige";
            BuecherAnzeige.Size = new Size(291, 169);
            BuecherAnzeige.TabIndex = 5;
            BuecherAnzeige.SelectedIndexChanged += BuecherAnzeige_SelectedIndexChanged;
            // 
            // Buchenfernen
            // 
            Buchenfernen.Location = new Point(374, 66);
            Buchenfernen.Name = "Buchenfernen";
            Buchenfernen.Size = new Size(88, 42);
            Buchenfernen.TabIndex = 6;
            Buchenfernen.Text = "Buch entfernen";
            Buchenfernen.UseVisualStyleBackColor = true;
            Buchenfernen.Click += buech_entfernen;
            // 
            // buch_suche
            // 
            buch_suche.AutoSize = true;
            buch_suche.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buch_suche.Location = new Point(61, 121);
            buch_suche.Margin = new Padding(5);
            buch_suche.Name = "buch_suche";
            buch_suche.Size = new Size(123, 25);
            buch_suche.TabIndex = 7;
            buch_suche.Text = "Buch suchen:";
            // 
            // TxtSuche
            // 
            TxtSuche.Location = new Point(190, 121);
            TxtSuche.Multiline = true;
            TxtSuche.Name = "TxtSuche";
            TxtSuche.Size = new Size(118, 32);
            TxtSuche.TabIndex = 8;
            TxtSuche.TextChanged += Such_box_TextChanged;
            // 
            // Search_button
            // 
            Search_button.Location = new Point(374, 114);
            Search_button.Name = "Search_button";
            Search_button.Size = new Size(88, 42);
            Search_button.TabIndex = 9;
            Search_button.Text = "Suchen";
            Search_button.UseVisualStyleBackColor = true;
            Search_button.Click += Search_button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1277, 674);
            Controls.Add(Search_button);
            Controls.Add(TxtSuche);
            Controls.Add(buch_suche);
            Controls.Add(Buchenfernen);
            Controls.Add(BuecherAnzeige);
            Controls.Add(button1);
            Controls.Add(txtAutor);
            Controls.Add(txtTitel);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtTitel;
        private TextBox txtAutor;
        private Button button1;
        private ListBox BuecherAnzeige;
        private Button Buchenfernen;
        private Label buch_suche;
        private TextBox TxtSuche;
        private Button Search_button;
    }
}
