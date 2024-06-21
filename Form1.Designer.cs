namespace MyCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            label1 = new Label();
            button13 = new Button();
            button19 = new Button();
            button18 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.GrayText;
            textBox1.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.MintCream;
            textBox1.Location = new Point(12, 61);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(371, 62);
            textBox1.TabIndex = 0;
            textBox1.TextAlign = HorizontalAlignment.Right;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(143, 248);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(0, 27);
            textBox2.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Info;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Gadugi", 24F, FontStyle.Bold);
            button1.Location = new Point(13, 147);
            button1.Name = "button1";
            button1.Size = new Size(77, 68);
            button1.TabIndex = 2;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += num1;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Info;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderColor = Color.White;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Gadugi", 24F, FontStyle.Bold);
            button2.Location = new Point(110, 147);
            button2.Name = "button2";
            button2.Size = new Size(77, 68);
            button2.TabIndex = 3;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += num2;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Info;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderColor = Color.White;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Gadugi", 24F, FontStyle.Bold);
            button3.Location = new Point(208, 147);
            button3.Name = "button3";
            button3.Size = new Size(77, 68);
            button3.TabIndex = 4;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += num3;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(128, 128, 255);
            button4.BackgroundImageLayout = ImageLayout.Center;
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderColor = Color.White;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Gadugi", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.InfoText;
            button4.Location = new Point(306, 226);
            button4.Name = "button4";
            button4.Size = new Size(77, 68);
            button4.TabIndex = 5;
            button4.Text = "−";
            button4.UseVisualStyleBackColor = false;
            button4.Click += subtraction;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(128, 128, 255);
            button5.BackgroundImageLayout = ImageLayout.Center;
            button5.Cursor = Cursors.Hand;
            button5.FlatAppearance.BorderColor = Color.White;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Gadugi", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = SystemColors.InfoText;
            button5.Location = new Point(306, 306);
            button5.Name = "button5";
            button5.Size = new Size(77, 68);
            button5.TabIndex = 9;
            button5.Text = "×";
            button5.UseVisualStyleBackColor = false;
            button5.Click += multiplication;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.Info;
            button6.Cursor = Cursors.Hand;
            button6.FlatAppearance.BorderColor = Color.White;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Gadugi", 24F, FontStyle.Bold);
            button6.Location = new Point(208, 225);
            button6.Name = "button6";
            button6.Size = new Size(77, 68);
            button6.TabIndex = 8;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = false;
            button6.Click += num6;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.Info;
            button7.Cursor = Cursors.Hand;
            button7.FlatAppearance.BorderColor = Color.White;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Gadugi", 24F, FontStyle.Bold);
            button7.Location = new Point(110, 225);
            button7.Name = "button7";
            button7.Size = new Size(77, 68);
            button7.TabIndex = 7;
            button7.Text = "5";
            button7.UseVisualStyleBackColor = false;
            button7.Click += num5;
            // 
            // button8
            // 
            button8.BackColor = SystemColors.Info;
            button8.Cursor = Cursors.Hand;
            button8.FlatAppearance.BorderColor = Color.White;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Gadugi", 24F, FontStyle.Bold);
            button8.Location = new Point(13, 225);
            button8.Name = "button8";
            button8.Size = new Size(77, 68);
            button8.TabIndex = 6;
            button8.Text = "4";
            button8.UseVisualStyleBackColor = false;
            button8.Click += num4;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(128, 128, 255);
            button9.BackgroundImageLayout = ImageLayout.Center;
            button9.Cursor = Cursors.Hand;
            button9.FlatAppearance.BorderColor = Color.White;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Gadugi", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button9.ForeColor = SystemColors.InfoText;
            button9.Location = new Point(306, 386);
            button9.Name = "button9";
            button9.Size = new Size(77, 68);
            button9.TabIndex = 13;
            button9.Text = "÷";
            button9.UseVisualStyleBackColor = false;
            button9.Click += division;
            // 
            // button10
            // 
            button10.BackColor = SystemColors.Info;
            button10.Cursor = Cursors.Hand;
            button10.FlatAppearance.BorderColor = Color.White;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Font = new Font("Gadugi", 24F, FontStyle.Bold);
            button10.ForeColor = SystemColors.WindowText;
            button10.Location = new Point(208, 306);
            button10.Name = "button10";
            button10.Size = new Size(77, 68);
            button10.TabIndex = 12;
            button10.Text = "9";
            button10.UseVisualStyleBackColor = false;
            button10.Click += num9;
            // 
            // button11
            // 
            button11.BackColor = SystemColors.Info;
            button11.Cursor = Cursors.Hand;
            button11.FlatAppearance.BorderColor = Color.White;
            button11.FlatStyle = FlatStyle.Flat;
            button11.Font = new Font("Gadugi", 24F, FontStyle.Bold);
            button11.ForeColor = SystemColors.WindowText;
            button11.Location = new Point(110, 306);
            button11.Name = "button11";
            button11.Size = new Size(77, 68);
            button11.TabIndex = 11;
            button11.Text = "8";
            button11.UseVisualStyleBackColor = false;
            button11.Click += num8;
            // 
            // button12
            // 
            button12.BackColor = SystemColors.Info;
            button12.Cursor = Cursors.Hand;
            button12.FlatAppearance.BorderColor = Color.White;
            button12.FlatStyle = FlatStyle.Flat;
            button12.Font = new Font("Gadugi", 24F, FontStyle.Bold);
            button12.Location = new Point(13, 306);
            button12.Name = "button12";
            button12.Size = new Size(77, 68);
            button12.TabIndex = 10;
            button12.Text = "7";
            button12.UseVisualStyleBackColor = false;
            button12.Click += num7;
            // 
            // button14
            // 
            button14.BackColor = Color.FromArgb(128, 128, 255);
            button14.Cursor = Cursors.Hand;
            button14.FlatAppearance.BorderColor = Color.White;
            button14.FlatStyle = FlatStyle.Flat;
            button14.Font = new Font("Gadugi", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button14.ForeColor = SystemColors.InfoText;
            button14.Location = new Point(208, 385);
            button14.Name = "button14";
            button14.Size = new Size(77, 68);
            button14.TabIndex = 16;
            button14.Text = ".";
            button14.UseVisualStyleBackColor = false;
            button14.Click += decimalBtn;
            // 
            // button15
            // 
            button15.BackColor = SystemColors.Info;
            button15.Cursor = Cursors.Hand;
            button15.FlatAppearance.BorderColor = Color.White;
            button15.FlatStyle = FlatStyle.Flat;
            button15.Font = new Font("Gadugi", 24F, FontStyle.Bold);
            button15.Location = new Point(110, 385);
            button15.Name = "button15";
            button15.Size = new Size(77, 68);
            button15.TabIndex = 15;
            button15.Text = "0";
            button15.UseVisualStyleBackColor = false;
            button15.Click += num0;
            // 
            // button16
            // 
            button16.BackColor = Color.DarkRed;
            button16.Cursor = Cursors.Hand;
            button16.FlatAppearance.BorderColor = Color.DarkRed;
            button16.FlatStyle = FlatStyle.Flat;
            button16.Font = new Font("Gadugi", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button16.ForeColor = SystemColors.InactiveBorder;
            button16.Location = new Point(13, 385);
            button16.Name = "button16";
            button16.Size = new Size(77, 148);
            button16.TabIndex = 14;
            button16.Text = "AC";
            button16.UseVisualStyleBackColor = false;
            button16.Click += allClear;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(27, 21);
            label1.Name = "label1";
            label1.Size = new Size(0, 28);
            label1.TabIndex = 18;
            // 
            // button13
            // 
            button13.BackColor = Color.FromArgb(128, 128, 255);
            button13.BackgroundImageLayout = ImageLayout.Center;
            button13.Cursor = Cursors.Hand;
            button13.FlatAppearance.BorderColor = Color.White;
            button13.FlatStyle = FlatStyle.Flat;
            button13.Font = new Font("Gadugi", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button13.ForeColor = SystemColors.InfoText;
            button13.Location = new Point(306, 465);
            button13.Name = "button13";
            button13.Size = new Size(77, 68);
            button13.TabIndex = 17;
            button13.Text = "+";
            button13.UseVisualStyleBackColor = false;
            button13.Click += addition;
            // 
            // button19
            // 
            button19.BackColor = Color.FromArgb(128, 128, 255);
            button19.Cursor = Cursors.Hand;
            button19.FlatAppearance.BorderColor = Color.White;
            button19.FlatStyle = FlatStyle.Flat;
            button19.Font = new Font("Gadugi", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button19.ForeColor = SystemColors.InfoText;
            button19.Location = new Point(110, 465);
            button19.Name = "button19";
            button19.Size = new Size(175, 68);
            button19.TabIndex = 21;
            button19.Text = "=";
            button19.UseVisualStyleBackColor = false;
            button19.Click += equalBtn;
            // 
            // button18
            // 
            button18.BackColor = Color.Orange;
            button18.BackgroundImageLayout = ImageLayout.Center;
            button18.Cursor = Cursors.Hand;
            button18.FlatAppearance.BorderColor = Color.White;
            button18.FlatStyle = FlatStyle.Flat;
            button18.Font = new Font("Gadugi", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button18.Location = new Point(306, 147);
            button18.Name = "button18";
            button18.Size = new Size(77, 68);
            button18.TabIndex = 22;
            button18.Text = "⌫";
            button18.UseVisualStyleBackColor = false;
            button18.Click += backspace;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(395, 552);
            Controls.Add(button18);
            Controls.Add(button19);
            Controls.Add(label1);
            Controls.Add(button13);
            Controls.Add(button14);
            Controls.Add(button15);
            Controls.Add(button16);
            Controls.Add(button9);
            Controls.Add(button10);
            Controls.Add(button11);
            Controls.Add(button12);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            ForeColor = SystemColors.WindowText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            TransparencyKey = SystemColors.Window;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button14;
        private Button button15;
        private Button button16;
        private Label label1;
        private Button button13;
        private Button button19;
        private Button button17;
        private Button button18;
    }
}
