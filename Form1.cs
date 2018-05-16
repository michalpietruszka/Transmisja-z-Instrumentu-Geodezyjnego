using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        string InputData = String.Empty;

        delegate void SetTextCallback(string text);

        public Form1()
        {
            InitializeComponent();
 
            string[] ports = SerialPort.GetPortNames();
 
            foreach (string port in ports)
            {
                comboBox1.Items.Add(port);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            port.BaudRate = Convert.ToInt32(comboBox2.SelectedItem.ToString());
            port.DataBits = Convert.ToInt32(comboBox3.SelectedItem.ToString());
            if (comboBox4.SelectedItem.ToString() == "None")
                port.StopBits = System.IO.Ports.StopBits.None;
            if (comboBox4.SelectedItem.ToString() == "One")
                port.StopBits = System.IO.Ports.StopBits.One;
            if (comboBox5.SelectedItem.ToString() == "Mark")
                port.Parity = System.IO.Ports.Parity.Mark;
            if (comboBox5.SelectedItem.ToString() == "None")
                port.Parity = System.IO.Ports.Parity.None;
            port.PortName = comboBox1.SelectedItem.ToString();
        }

        private void port_DataReceived_1(object sender, SerialDataReceivedEventArgs e)
        {
            richtextBox1.Clear();
            InputData = port.ReadExisting();
            if (InputData != String.Empty)
            {
                SetText(InputData);
            }
        }

        private void SetText(string text)
        {
            if (this.richtextBox1.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else this.richtextBox1.Text += text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void cleanbox_Click(object sender, EventArgs e)
        {
            richtextBox1.Clear();
        }

        private void zapis_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt";
            saveFileDialog.AddExtension = true;

            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            { 
                richtextBox1.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.PlainText);
                MessageBox.Show("Zapisano poprawnie", "Zapisywanie", MessageBoxButtons.OK);
             }
        }

        private void zamknijProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Napewno chcesz zamknąć program ?", "Zamykanie", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        OpenFileDialog ofd = new OpenFileDialog();

        private void odczytajZPlikuToolStripMenuItem_Click(object sender, EventArgs e)
        {
                poleStatusu.Text = ofd.SafeFileName;
                ofd.Filter = "Text Files|*.txt";

                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    richtextBox1.LoadFile(ofd.FileName, RichTextBoxStreamType.PlainText);
        }

        private void openport_Click_1(object sender, EventArgs e)
        {
            poleStatusu.Text = port.PortName + ", " + port.BaudRate;
            try
            {
                port.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived_1);
                port.Open();
            }
            catch
            {
                MessageBox.Show(" Port nie może być otwarty!", "RS232Terminal ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBox1.SelectedText = "";
                poleStatusu.Text = "Wybierz inny Port!";
            }
        }

        private void closeport_Click_1(object sender, EventArgs e)
        {
            port.Close();
        }

    }
}
