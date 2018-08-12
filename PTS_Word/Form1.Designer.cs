namespace PTS_Word
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_idiom_search = new System.Windows.Forms.TabPage();
            this.label_idiom = new System.Windows.Forms.Label();
            this.textBox_idiom4 = new System.Windows.Forms.TextBox();
            this.textBox_idiom3 = new System.Windows.Forms.TextBox();
            this.textBox_idiom2 = new System.Windows.Forms.TextBox();
            this.textBox_idiom1 = new System.Windows.Forms.TextBox();
            this.richTextBox_idiom_msg = new System.Windows.Forms.RichTextBox();
            this.button_idiom_search = new System.Windows.Forms.Button();
            this.tabPage_word_search = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage_idiom_search.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_idiom_search);
            this.tabControl1.Controls.Add(this.tabPage_word_search);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(760, 538);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.TabStop = false;
            // 
            // tabPage_idiom_search
            // 
            this.tabPage_idiom_search.Controls.Add(this.label_idiom);
            this.tabPage_idiom_search.Controls.Add(this.textBox_idiom4);
            this.tabPage_idiom_search.Controls.Add(this.textBox_idiom3);
            this.tabPage_idiom_search.Controls.Add(this.textBox_idiom2);
            this.tabPage_idiom_search.Controls.Add(this.textBox_idiom1);
            this.tabPage_idiom_search.Controls.Add(this.richTextBox_idiom_msg);
            this.tabPage_idiom_search.Controls.Add(this.button_idiom_search);
            this.tabPage_idiom_search.Location = new System.Drawing.Point(4, 22);
            this.tabPage_idiom_search.Name = "tabPage_idiom_search";
            this.tabPage_idiom_search.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_idiom_search.Size = new System.Drawing.Size(752, 512);
            this.tabPage_idiom_search.TabIndex = 0;
            this.tabPage_idiom_search.Text = "《隻字片語》查詢";
            this.tabPage_idiom_search.UseVisualStyleBackColor = true;
            // 
            // label_idiom
            // 
            this.label_idiom.AutoSize = true;
            this.label_idiom.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_idiom.Location = new System.Drawing.Point(27, 31);
            this.label_idiom.Name = "label_idiom";
            this.label_idiom.Size = new System.Drawing.Size(254, 31);
            this.label_idiom.TabIndex = 6;
            this.label_idiom.Text = "《隻字片語》填詞查詢";
            // 
            // textBox_idiom4
            // 
            this.textBox_idiom4.BackColor = System.Drawing.SystemColors.Info;
            this.textBox_idiom4.Font = new System.Drawing.Font("華康正顏楷體W5", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_idiom4.Location = new System.Drawing.Point(472, 101);
            this.textBox_idiom4.Margin = new System.Windows.Forms.Padding(20);
            this.textBox_idiom4.MaxLength = 1;
            this.textBox_idiom4.Name = "textBox_idiom4";
            this.textBox_idiom4.Size = new System.Drawing.Size(82, 87);
            this.textBox_idiom4.TabIndex = 5;
            this.textBox_idiom4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_idiom4.Click += new System.EventHandler(this.textBox_idiom4_Click);
            // 
            // textBox_idiom3
            // 
            this.textBox_idiom3.BackColor = System.Drawing.SystemColors.Info;
            this.textBox_idiom3.Font = new System.Drawing.Font("華康正顏楷體W5", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_idiom3.Location = new System.Drawing.Point(350, 101);
            this.textBox_idiom3.Margin = new System.Windows.Forms.Padding(20);
            this.textBox_idiom3.MaxLength = 1;
            this.textBox_idiom3.Name = "textBox_idiom3";
            this.textBox_idiom3.Size = new System.Drawing.Size(82, 87);
            this.textBox_idiom3.TabIndex = 4;
            this.textBox_idiom3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_idiom3.Click += new System.EventHandler(this.textBox_idiom3_Click);
            // 
            // textBox_idiom2
            // 
            this.textBox_idiom2.BackColor = System.Drawing.SystemColors.Info;
            this.textBox_idiom2.Font = new System.Drawing.Font("華康正顏楷體W5", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_idiom2.Location = new System.Drawing.Point(228, 101);
            this.textBox_idiom2.Margin = new System.Windows.Forms.Padding(20);
            this.textBox_idiom2.MaxLength = 1;
            this.textBox_idiom2.Name = "textBox_idiom2";
            this.textBox_idiom2.Size = new System.Drawing.Size(82, 87);
            this.textBox_idiom2.TabIndex = 3;
            this.textBox_idiom2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_idiom2.Click += new System.EventHandler(this.textBox_idiom2_Click);
            // 
            // textBox_idiom1
            // 
            this.textBox_idiom1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox_idiom1.Font = new System.Drawing.Font("華康正顏楷體W5", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_idiom1.Location = new System.Drawing.Point(106, 101);
            this.textBox_idiom1.Margin = new System.Windows.Forms.Padding(20);
            this.textBox_idiom1.MaxLength = 1;
            this.textBox_idiom1.Name = "textBox_idiom1";
            this.textBox_idiom1.Size = new System.Drawing.Size(82, 87);
            this.textBox_idiom1.TabIndex = 2;
            this.textBox_idiom1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_idiom1.Click += new System.EventHandler(this.textBox_idiom1_Click);
            // 
            // richTextBox_idiom_msg
            // 
            this.richTextBox_idiom_msg.BackColor = System.Drawing.Color.White;
            this.richTextBox_idiom_msg.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.richTextBox_idiom_msg.Location = new System.Drawing.Point(106, 238);
            this.richTextBox_idiom_msg.Name = "richTextBox_idiom_msg";
            this.richTextBox_idiom_msg.Size = new System.Drawing.Size(570, 222);
            this.richTextBox_idiom_msg.TabIndex = 1;
            this.richTextBox_idiom_msg.TabStop = false;
            this.richTextBox_idiom_msg.Text = "";
            // 
            // button_idiom_search
            // 
            this.button_idiom_search.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_idiom_search.Location = new System.Drawing.Point(594, 126);
            this.button_idiom_search.Name = "button_idiom_search";
            this.button_idiom_search.Size = new System.Drawing.Size(82, 47);
            this.button_idiom_search.TabIndex = 0;
            this.button_idiom_search.Text = "搜尋";
            this.button_idiom_search.UseVisualStyleBackColor = true;
            this.button_idiom_search.Click += new System.EventHandler(this.button_idiom_search_Click);
            // 
            // tabPage_word_search
            // 
            this.tabPage_word_search.Location = new System.Drawing.Point(4, 22);
            this.tabPage_word_search.Name = "tabPage_word_search";
            this.tabPage_word_search.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_word_search.Size = new System.Drawing.Size(752, 512);
            this.tabPage_word_search.TabIndex = 1;
            this.tabPage_word_search.Text = "《字字珠璣》查詢";
            this.tabPage_word_search.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "《一字千金》練習工具";
            this.tabControl1.ResumeLayout(false);
            this.tabPage_idiom_search.ResumeLayout(false);
            this.tabPage_idiom_search.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_idiom_search;
        private System.Windows.Forms.TabPage tabPage_word_search;
        private System.Windows.Forms.TextBox textBox_idiom1;
        private System.Windows.Forms.RichTextBox richTextBox_idiom_msg;
        private System.Windows.Forms.Button button_idiom_search;
        private System.Windows.Forms.Label label_idiom;
        private System.Windows.Forms.TextBox textBox_idiom4;
        private System.Windows.Forms.TextBox textBox_idiom3;
        private System.Windows.Forms.TextBox textBox_idiom2;
    }
}

