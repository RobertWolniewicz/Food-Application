namespace Food_Application
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.FindBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.QuantityBox = new System.Windows.Forms.TextBox();
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.MasBox = new System.Windows.Forms.TextBox();
            this.Deleytbutton = new System.Windows.Forms.Button();
            this.Editbuttom = new System.Windows.Forms.Button();
            this.SaveButtom = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Infolabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new System.Drawing.Point(12, 12);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(350, 514);
            this.listBox2.TabIndex = 0;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // FindBox
            // 
            this.FindBox.Location = new System.Drawing.Point(420, 12);
            this.FindBox.Name = "FindBox";
            this.FindBox.Size = new System.Drawing.Size(339, 23);
            this.FindBox.TabIndex = 1;
            this.FindBox.Text = "Wyszukaj";
            this.FindBox.TextChanged += new System.EventHandler(this.FindBox_TextChanged);
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(420, 288);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(339, 23);
            this.NameBox.TabIndex = 2;
            // 
            // QuantityBox
            // 
            this.QuantityBox.Location = new System.Drawing.Point(536, 380);
            this.QuantityBox.Name = "QuantityBox";
            this.QuantityBox.Size = new System.Drawing.Size(100, 23);
            this.QuantityBox.TabIndex = 3;
            // 
            // PriceBox
            // 
            this.PriceBox.Location = new System.Drawing.Point(684, 380);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(100, 23);
            this.PriceBox.TabIndex = 4;
            // 
            // MasBox
            // 
            this.MasBox.Location = new System.Drawing.Point(394, 380);
            this.MasBox.Name = "MasBox";
            this.MasBox.Size = new System.Drawing.Size(100, 23);
            this.MasBox.TabIndex = 5;
            // 
            // Deleytbutton
            // 
            this.Deleytbutton.Location = new System.Drawing.Point(420, 51);
            this.Deleytbutton.Name = "Deleytbutton";
            this.Deleytbutton.Size = new System.Drawing.Size(147, 67);
            this.Deleytbutton.TabIndex = 6;
            this.Deleytbutton.Text = "Usuń składnik";
            this.Deleytbutton.UseVisualStyleBackColor = true;
            this.Deleytbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Editbuttom
            // 
            this.Editbuttom.Location = new System.Drawing.Point(612, 51);
            this.Editbuttom.Name = "Editbuttom";
            this.Editbuttom.Size = new System.Drawing.Size(147, 67);
            this.Editbuttom.TabIndex = 7;
            this.Editbuttom.Text = "Edytuj Składnik";
            this.Editbuttom.UseVisualStyleBackColor = true;
            this.Editbuttom.Click += new System.EventHandler(this.button2_Click);
            // 
            // SaveButtom
            // 
            this.SaveButtom.Location = new System.Drawing.Point(510, 437);
            this.SaveButtom.Name = "SaveButtom";
            this.SaveButtom.Size = new System.Drawing.Size(147, 56);
            this.SaveButtom.TabIndex = 8;
            this.SaveButtom.Text = "Dodaj nowy składnik";
            this.SaveButtom.UseVisualStyleBackColor = true;
            this.SaveButtom.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(564, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nazwa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(420, 343);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Masa (kg)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(575, 343);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ilość";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(715, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Cena (zł)";
            // 
            // Infolabel
            // 
            this.Infolabel.AutoSize = true;
            this.Infolabel.Location = new System.Drawing.Point(575, 181);
            this.Infolabel.Name = "Infolabel";
            this.Infolabel.Size = new System.Drawing.Size(0, 15);
            this.Infolabel.TabIndex = 14;
            // 
            // Form2
            // 
            this.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.ClientSize = new System.Drawing.Size(923, 557);
            this.Controls.Add(this.Infolabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SaveButtom);
            this.Controls.Add(this.Editbuttom);
            this.Controls.Add(this.Deleytbutton);
            this.Controls.Add(this.MasBox);
            this.Controls.Add(this.PriceBox);
            this.Controls.Add(this.QuantityBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.FindBox);
            this.Controls.Add(this.listBox2);
            this.Name = "Form2";
            this.Text = "Składniki";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public ListBox listBox2;
        public TextBox FindBox;
        public TextBox NameBox;
        public TextBox QuantityBox;
        public TextBox PriceBox;
        public TextBox MasBox;
        public Button Deleytbutton;
        public Button Editbuttom;
        public Button SaveButtom;
        public Label label1;
        public Label label2;
        public Label label3;
        public Label label4;
        public Label Infolabel;
    }
}