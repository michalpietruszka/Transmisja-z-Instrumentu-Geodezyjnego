namespace WindowsFormsApplication3
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.port = new System.IO.Ports.SerialPort(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.poleStatusu = new System.Windows.Forms.TextBox();
            this.richtextBox1 = new System.Windows.Forms.RichTextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.zapiszDoPlikuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odczytajZPlikuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wyczyśćOknoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zamknijProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // port
            // 
            this.port.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.port_DataReceived_1);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 155);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "COM";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // poleStatusu
            // 
            this.poleStatusu.Location = new System.Drawing.Point(12, 291);
            this.poleStatusu.Name = "poleStatusu";
            this.poleStatusu.Size = new System.Drawing.Size(121, 20);
            this.poleStatusu.TabIndex = 3;
            // 
            // richtextBox1
            // 
            this.richtextBox1.Location = new System.Drawing.Point(139, 42);
            this.richtextBox1.Name = "richtextBox1";
            this.richtextBox1.Size = new System.Drawing.Size(720, 367);
            this.richtextBox1.TabIndex = 6;
            this.richtextBox1.Text = "";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "9600",
            "800"});
            this.comboBox2.Location = new System.Drawing.Point(12, 42);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 8;
            this.comboBox2.Text = "Prędkość";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "8",
            "4"});
            this.comboBox3.Location = new System.Drawing.Point(12, 69);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 9;
            this.comboBox3.Text = "Bity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Wybrano:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zapiszDoPlikuToolStripMenuItem,
            this.odczytajZPlikuToolStripMenuItem,
            this.wyczyśćOknoToolStripMenuItem,
            this.zamknijProgramToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(871, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // zapiszDoPlikuToolStripMenuItem
            // 
            this.zapiszDoPlikuToolStripMenuItem.Name = "zapiszDoPlikuToolStripMenuItem";
            this.zapiszDoPlikuToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.zapiszDoPlikuToolStripMenuItem.Text = "Zapisz do pliku";
            this.zapiszDoPlikuToolStripMenuItem.Click += new System.EventHandler(this.zapis_Click);
            // 
            // odczytajZPlikuToolStripMenuItem
            // 
            this.odczytajZPlikuToolStripMenuItem.Name = "odczytajZPlikuToolStripMenuItem";
            this.odczytajZPlikuToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.odczytajZPlikuToolStripMenuItem.Text = "Odczytaj z pliku";
            this.odczytajZPlikuToolStripMenuItem.Click += new System.EventHandler(this.odczytajZPlikuToolStripMenuItem_Click);
            // 
            // wyczyśćOknoToolStripMenuItem
            // 
            this.wyczyśćOknoToolStripMenuItem.Name = "wyczyśćOknoToolStripMenuItem";
            this.wyczyśćOknoToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.wyczyśćOknoToolStripMenuItem.Text = "Wyczyść okno";
            this.wyczyśćOknoToolStripMenuItem.Click += new System.EventHandler(this.cleanbox_Click);
            // 
            // zamknijProgramToolStripMenuItem
            // 
            this.zamknijProgramToolStripMenuItem.Name = "zamknijProgramToolStripMenuItem";
            this.zamknijProgramToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.zamknijProgramToolStripMenuItem.Text = "Zamknij program";
            this.zamknijProgramToolStripMenuItem.Click += new System.EventHandler(this.zamknijProgramToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(58, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Otwórz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.openport_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(58, 211);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Zamknij";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.closeport_Click_1);
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "None",
            "One"});
            this.comboBox4.Location = new System.Drawing.Point(12, 98);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 14;
            this.comboBox4.Text = "Bity stopu";
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "Mark ",
            "None"});
            this.comboBox5.Location = new System.Drawing.Point(12, 128);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(121, 21);
            this.comboBox5.TabIndex = 15;
            this.comboBox5.Text = "Bit parzystości";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 421);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.richtextBox1);
            this.Controls.Add(this.poleStatusu);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Terminal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort port;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label odebrane;
        private System.Windows.Forms.TextBox poleStatusu;
        private System.Windows.Forms.RichTextBox richtextBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem zapiszDoPlikuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odczytajZPlikuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wyczyśćOknoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zamknijProgramToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
    }
}

