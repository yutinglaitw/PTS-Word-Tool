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
        private static Dictionary<char, List<char>> dict_bi_prefix;
        private static Dictionary<char, List<char>> dict_bi_suffix;

        public Form1()
        {
            InitializeComponent();

            dict_bi_prefix = new Dictionary<char, List<char>>();
            dict_bi_suffix = new Dictionary<char, List<char>>();

            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(@"dict\bigram.txt");
            while ((line = file.ReadLine()) != null)
            {
                if (line.Length == 2)
                {
                    if (!dict_bi_suffix.ContainsKey(line[0]))
                    {
                        dict_bi_suffix.Add(line[0], new List<char>());
                    }
                    if (!dict_bi_prefix.ContainsKey(line[1]))
                    {
                        dict_bi_prefix.Add(line[1], new List<char>());
                    }

                    dict_bi_suffix[line[0]].Add(line[1]);
                    dict_bi_prefix[line[1]].Add(line[0]);
                }
            }
            file.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
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

        private void radioButton_word_1to4_CheckedChanged(object sender, EventArgs e)
        {
            textBox_word_c0.Location = new Point(193, 47);
            textBox_word_c1.Location = new Point(35, 157);
            textBox_word_c2.Location = new Point(141, 157);
            textBox_word_c3.Location = new Point(247, 157);
            textBox_word_c4.Location = new Point(353, 157);

            textBox_word_c0.Text = "";
            textBox_word_c1.Text = "";
            textBox_word_c2.Text = "";
            textBox_word_c3.Text = "";
            textBox_word_c4.Text = "";
        }

        private void radioButton_word_4to1_CheckedChanged(object sender, EventArgs e)
        {
            textBox_word_c0.Location = new Point(193, 157);
            textBox_word_c1.Location = new Point(35, 47);
            textBox_word_c2.Location = new Point(141, 47);
            textBox_word_c3.Location = new Point(247, 47);
            textBox_word_c4.Location = new Point(353, 47);

            textBox_word_c0.Text = "";
            textBox_word_c1.Text = "";
            textBox_word_c2.Text = "";
            textBox_word_c3.Text = "";
            textBox_word_c4.Text = "";
        }

        private void button_word_question_Click(object sender, EventArgs e)
        {
            textBox_word_c0.Text = "";
            button_word_question.Enabled = false;

            Random rand = new Random();

            // Select random char
            List<char> candidate = new List<char>();

            while (candidate.Count < 4) 
            {
                if (radioButton_word_1to4.Checked)
                {
                    char answer = dict_bi_suffix.Keys.ToList()[rand.Next(dict_bi_suffix.Count)];
                    candidate = dict_bi_suffix[answer];
                }
                else 
                {
                    char answer = dict_bi_prefix.Keys.ToList()[rand.Next(dict_bi_prefix.Count)];
                    candidate = dict_bi_prefix[answer];
                }
            }


            // Select random words
            List<int> rand_set = new List<int>();

            while (rand_set.Count < 4) 
            {
                int num = rand.Next(candidate.Count);
                if (!rand_set.Contains(num))
                {
                    rand_set.Add(num);
                }
            }

            textBox_word_c1.Text = candidate[rand_set[0]].ToString();
            textBox_word_c2.Text = candidate[rand_set[1]].ToString();
            textBox_word_c3.Text = candidate[rand_set[2]].ToString();
            textBox_word_c4.Text = candidate[rand_set[3]].ToString();

            button_word_question.Enabled = true;
        }

        private List<char> search_word_matching(Dictionary<char, List<char>> dict) 
        {
            List<char> answer = new List<char>();

            foreach (KeyValuePair<char, List<char>> p in dict)
            {
                if (p.Value.Contains(textBox_word_c1.Text[0])
                    && p.Value.Contains(textBox_word_c2.Text[0])
                    && p.Value.Contains(textBox_word_c3.Text[0])
                    && p.Value.Contains(textBox_word_c4.Text[0]))
                {
                    answer.Add(p.Key);
                }
            }

            return answer;
        }

        private void button_word_answer_Click(object sender, EventArgs e)
        {
            // Clean textbox
            richTextBox_word.Text = "";
            textBox_word_c0.Text = "";

            // Check textbox
            if (String.IsNullOrEmpty(textBox_word_c1.Text) || String.IsNullOrEmpty(textBox_word_c2.Text)
                || String.IsNullOrEmpty(textBox_word_c3.Text) || String.IsNullOrEmpty(textBox_word_c4.Text)) 
            {
                richTextBox_word.ForeColor = Color.Red;
                richTextBox_word.Text = "題目不完整！";
                return; 
            }

            // Search answer
            List<char> answer = new List<char>();

            if (radioButton_word_1to4.Checked)
            {
                answer = search_word_matching(dict_bi_suffix);
            }
            else
            {
                answer = search_word_matching(dict_bi_prefix);
            }

            // Display answer
            if (answer.Count > 1) 
            {
                richTextBox_word.ForeColor = Color.Red;
                richTextBox_word.Text = "有多個符合答案！" + String.Join(", ", answer.ToArray());
            }
            else if (answer.Count == 1)
            {
                textBox_word_c0.ForeColor = Color.Green;
                textBox_word_c0.Text = answer[0].ToString();
            }
            else 
            {
                richTextBox_word.ForeColor = Color.Red;
                richTextBox_word.Text = "找不到符合條件的字！";
            }

        }

    }
}
