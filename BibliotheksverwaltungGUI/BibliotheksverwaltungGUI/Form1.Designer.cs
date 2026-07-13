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
            listBox1 = new ListBox();
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
            button1.Location = new Point(438, 12);
            button1.Name = "button1";
            button1.Size = new Size(88, 43);
            button1.TabIndex = 4;
            button1.Text = "Buch hinzufügen";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(190, 137);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(118, 214);
            listBox1.TabIndex = 5;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1277, 674);
            Controls.Add(listBox1);
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
        private ListBox listBox1;
    }
}
