using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceGame
{
    public partial class Form1 : Form
    {   
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader sr = new StreamReader("highScores.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        textBox1.AppendText(line + Environment.NewLine);
                    }
                }
            }
            catch (Exception s)
            {
                  MessageBox.Show("The file could not be read:");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (textBox2.Visible)
            {
                textBox2.Visible= false;
            }
            else
            {
                textBox2.Visible= true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (textBox1.Visible)
            {
                textBox1.Visible= false;
            }
            else
            {
                textBox1.ResetText();
                try
                {
                    using (StreamReader sr = new StreamReader("highScores.txt"))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            textBox1.AppendText(line + Environment.NewLine);
                        }
                    }
                }
                catch (Exception s)
                {
                    MessageBox.Show("The file could not be read:");
                }
                textBox1.Visible= true;
            }
        }
    }
}
