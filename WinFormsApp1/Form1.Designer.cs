namespace WinFormsApp6
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox6 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox2 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox3 = new TextBox();
            label7 = new Label();
            label8 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label9 = new Label();
            button6 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(553, 73);
            button1.Name = "button1";
            button1.Size = new Size(94, 54);
            button1.TabIndex = 0;
            button1.Text = "Экспорт в Excel";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(182, 107);
            label1.Name = "label1";
            label1.Size = new Size(22, 20);
            label1.TabIndex = 1;
            label1.Text = "a(";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(181, 162);
            label2.Name = "label2";
            label2.Size = new Size(23, 20);
            label2.TabIndex = 2;
            label2.Text = "b(";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(210, 104);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(47, 27);
            textBox1.TabIndex = 3;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(352, 159);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(47, 27);
            textBox6.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(263, 107);
            label3.Name = "label3";
            label3.Size = new Size(12, 20);
            label3.TabIndex = 5;
            label3.Text = ";";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(263, 162);
            label4.Name = "label4";
            label4.Size = new Size(12, 20);
            label4.TabIndex = 6;
            label4.Text = ";";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(334, 107);
            label5.Name = "label5";
            label5.Size = new Size(12, 20);
            label5.TabIndex = 7;
            label5.Text = ";";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(334, 162);
            label6.Name = "label6";
            label6.Size = new Size(12, 20);
            label6.TabIndex = 8;
            label6.Text = ";";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(281, 104);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(47, 27);
            textBox2.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(210, 159);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(47, 27);
            textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(281, 159);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(47, 27);
            textBox5.TabIndex = 11;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(352, 104);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(47, 27);
            textBox3.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(405, 107);
            label7.Name = "label7";
            label7.Size = new Size(14, 20);
            label7.TabIndex = 13;
            label7.Text = ")";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(405, 162);
            label8.Name = "label8";
            label8.Size = new Size(14, 20);
            label8.TabIndex = 14;
            label8.Text = ")";
            // 
            // button2
            // 
            button2.Location = new Point(169, 202);
            button2.Name = "button2";
            button2.Size = new Size(122, 71);
            button2.TabIndex = 15;
            button2.Text = "Векторное произведение";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(318, 202);
            button3.Name = "button3";
            button3.Size = new Size(122, 71);
            button3.TabIndex = 16;
            button3.Text = "Скалярное произведение";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(553, 145);
            button4.Name = "button4";
            button4.Size = new Size(94, 54);
            button4.TabIndex = 17;
            button4.Text = "Экспорт в Word";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(553, 219);
            button5.Name = "button5";
            button5.Size = new Size(94, 54);
            button5.TabIndex = 18;
            button5.Text = "Экспорт в PDF";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(263, 73);
            label9.Name = "label9";
            label9.Size = new Size(0, 20);
            label9.TabIndex = 19;
            // 
            // button6
            // 
            button6.Location = new Point(553, 296);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 20;
            button6.Text = "Очистить";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button6);
            Controls.Add(label9);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(textBox3);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox6);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox6;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox2;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox3;
        private Label label7;
        private Label label8;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label9;
        private Button button6;
    }
}