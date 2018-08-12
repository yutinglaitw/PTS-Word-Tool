using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTS_Word
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox_idiom1_Click(object sender, EventArgs e)
        {
            textBox_idiom1.Text = "";
        }

        private void textBox_idiom2_Click(object sender, EventArgs e)
        {
            textBox_idiom2.Text = "";
        }

        private void textBox_idiom3_Click(object sender, EventArgs e)
        {
            textBox_idiom3.Text = "";
        }

        private void textBox_idiom4_Click(object sender, EventArgs e)
        {
            textBox_idiom4.Text = "";
        }

        private void button_idiom_search_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox_idiom1.Text) && String.IsNullOrEmpty(textBox_idiom2.Text)
                && String.IsNullOrEmpty(textBox_idiom3.Text) && String.IsNullOrEmpty(textBox_idiom4.Text))
            {
                richTextBox_idiom_msg.ForeColor = Color.DarkSlateBlue;
                richTextBox_idiom_msg.Text = "請至少填入一個字";
                return;
            }
            try
            {
                richTextBox_idiom_msg.ForeColor = Color.Green;
                richTextBox_idiom_msg.Text = "";

                string line;
                int count = 0;
                System.IO.StreamReader file = new System.IO.StreamReader(@"dict\idiom.txt");
                while ((line = file.ReadLine()) != null)
                {
                    if (line.Length == 4)
                    {
                        if (!String.IsNullOrEmpty(textBox_idiom1.Text) && line[0] != textBox_idiom1.Text[0]) { continue; }
                        if (!String.IsNullOrEmpty(textBox_idiom2.Text) && line[1] != textBox_idiom2.Text[0]) { continue; }
                        if (!String.IsNullOrEmpty(textBox_idiom3.Text) && line[2] != textBox_idiom3.Text[0]) { continue; }
                        if (!String.IsNullOrEmpty(textBox_idiom4.Text) && line[3] != textBox_idiom4.Text[0]) { continue; }
                        
                        count += 1;
                        richTextBox_idiom_msg.AppendText(line + ". ");
                        if (count % 7 == 0) { richTextBox_idiom_msg.AppendText(Environment.NewLine); }
                    }
                }
                file.Close();

                if (String.IsNullOrEmpty(richTextBox_idiom_msg.Text))
                {
                    richTextBox_idiom_msg.ForeColor = Color.DarkSlateBlue;
                    richTextBox_idiom_msg.Text = "沒有符合的結果";
                }                
            }
            catch (Exception ex)
            {
                richTextBox_idiom_msg.ForeColor = Color.Red;
                richTextBox_idiom_msg.Text = ex.Message;
            }
        }
    }
}
