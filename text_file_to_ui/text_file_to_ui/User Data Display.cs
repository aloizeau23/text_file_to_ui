using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using static System.Windows.Forms.LinkLabel;

namespace text_file_to_ui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                // Read all lines
                string[] lines = File.ReadAllLines(filePath);
                int add1 = 0;
                foreach (string line in lines)
                {
                    // Seperate Data Name and their Value
                    string[] parts = line.Split('=');

                    if (parts.Length == 2)
                    {
                        string Name = parts[0].Trim();
                        string value = parts[1].Trim();

                        switch (Name)
                        {
                            case "Name":
                                textBox1.Text = value;
                                break;
                            case "Surname":
                                textBox2.Text = value;
                                break;
                            case "Year of birth":
                                textBox3.Text = value;
                                break;
                            case "City of origin":
                                textBox4.Text = value;
                                break;
                            case "Faculty":
                                textBox5.Text = value;
                                break;
                            case "Role":
                                textBox6.Text = value;
                                break;
                            case "Favorite course":
                                textBox7.Text = value;
                                break;
                            case "File accessed times":
                                textBox8.Text = value;
                                int.TryParse(value, out add1);
                                add1++;
                                break;
                        }
                    }
                }
                // Update of the line File accessed times with incrementation
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] parts = lines[i].Split('=');

                    if (parts.Length == 2 && parts[0].Trim() == "File accessed times")
                    {
                        lines[i] = "File accessed times=" + add1.ToString();
                        break;
                    }
                }

                // Update of the file for writeing the incrementation
                File.WriteAllLines(filePath, lines);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void label6_Click(object sender, EventArgs e)
                {

                }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
