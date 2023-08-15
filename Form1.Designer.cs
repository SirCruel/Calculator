namespace Calculator
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
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            button17 = new Button();
            button18 = new Button();
            button19 = new Button();
            button20 = new Button();
            button21 = new Button();
            button22 = new Button();
            button23 = new Button();
            button24 = new Button();
            textBoxAusgabe = new TextBox();
            textBox2 = new TextBox();
            button25 = new Button();
            button27 = new Button();
            button28 = new Button();
            button29 = new Button();
            button30 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(14, 192);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(94, 62);
            button1.TabIndex = 0;
            button1.Text = "%";
            button1.UseVisualStyleBackColor = true;
            button1.Click += ProzentButton_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(115, 192);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(94, 62);
            button2.TabIndex = 1;
            button2.Text = "CE";
            button2.UseVisualStyleBackColor = true;
            button2.Click += WertLöschenButton_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(216, 192);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(94, 62);
            button3.TabIndex = 2;
            button3.Text = "C";
            button3.UseVisualStyleBackColor = true;
            button3.Click += LöschenButton_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(317, 192);
            button4.Margin = new Padding(4);
            button4.Name = "button4";
            button4.Size = new Size(94, 62);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = true;
            button4.Click += BackspaceButton_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = SystemColors.ButtonFace;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.Location = new Point(317, 262);
            button5.Margin = new Padding(4);
            button5.Name = "button5";
            button5.Size = new Size(94, 62);
            button5.TabIndex = 7;
            button5.Text = "/";
            button5.TextAlign = ContentAlignment.BottomLeft;
            button5.UseVisualStyleBackColor = true;
            button5.Click += OperatorButton_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(216, 262);
            button6.Margin = new Padding(4);
            button6.Name = "button6";
            button6.Size = new Size(94, 62);
            button6.TabIndex = 6;
            button6.Text = "²√x";
            button6.UseVisualStyleBackColor = true;
            button6.Click += WurzelButton_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Location = new Point(115, 262);
            button7.Margin = new Padding(4);
            button7.Name = "button7";
            button7.Size = new Size(94, 62);
            button7.TabIndex = 5;
            button7.Text = "x²";
            button7.UseVisualStyleBackColor = true;
            button7.Click += SqrButton_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button8.Location = new Point(14, 262);
            button8.Margin = new Padding(4);
            button8.Name = "button8";
            button8.Size = new Size(94, 62);
            button8.TabIndex = 4;
            button8.Text = "1/x";
            button8.UseVisualStyleBackColor = true;
            button8.Click += einsTeilenButton_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button9.Image = (Image)resources.GetObject("button9.Image");
            button9.Location = new Point(317, 332);
            button9.Margin = new Padding(4);
            button9.Name = "button9";
            button9.Size = new Size(94, 62);
            button9.TabIndex = 11;
            button9.Text = "*";
            button9.UseVisualStyleBackColor = true;
            button9.Click += OperatorButton_Click;
            // 
            // button10
            // 
            button10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button10.Location = new Point(216, 332);
            button10.Margin = new Padding(4);
            button10.Name = "button10";
            button10.Size = new Size(94, 62);
            button10.TabIndex = 10;
            button10.Text = "9";
            button10.UseVisualStyleBackColor = true;
            button10.Click += ZahlButton_Click;
            // 
            // button11
            // 
            button11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button11.Location = new Point(115, 332);
            button11.Margin = new Padding(4);
            button11.Name = "button11";
            button11.Size = new Size(94, 62);
            button11.TabIndex = 9;
            button11.Text = "8";
            button11.UseVisualStyleBackColor = true;
            button11.Click += ZahlButton_Click;
            // 
            // button12
            // 
            button12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button12.Location = new Point(14, 332);
            button12.Margin = new Padding(4);
            button12.Name = "button12";
            button12.Size = new Size(94, 62);
            button12.TabIndex = 8;
            button12.Text = "7";
            button12.UseVisualStyleBackColor = true;
            button12.Click += ZahlButton_Click;
            // 
            // button13
            // 
            button13.BackColor = SystemColors.ButtonFace;
            button13.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button13.ForeColor = SystemColors.ControlLightLight;
            button13.Image = (Image)resources.GetObject("button13.Image");
            button13.Location = new Point(317, 539);
            button13.Margin = new Padding(4);
            button13.Name = "button13";
            button13.Size = new Size(94, 62);
            button13.TabIndex = 23;
            button13.UseVisualStyleBackColor = false;
            button13.Click += GleichButton_Click;
            // 
            // button14
            // 
            button14.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button14.Location = new Point(216, 539);
            button14.Margin = new Padding(4);
            button14.Name = "button14";
            button14.Size = new Size(94, 62);
            button14.TabIndex = 22;
            button14.Text = ",";
            button14.UseVisualStyleBackColor = true;
            button14.Click += ZahlButton_Click;
            // 
            // button15
            // 
            button15.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button15.Location = new Point(115, 539);
            button15.Margin = new Padding(4);
            button15.Name = "button15";
            button15.Size = new Size(94, 62);
            button15.TabIndex = 21;
            button15.Text = "0";
            button15.UseVisualStyleBackColor = true;
            button15.Click += ZahlButton_Click;
            // 
            // button16
            // 
            button16.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button16.Location = new Point(14, 539);
            button16.Margin = new Padding(4);
            button16.Name = "button16";
            button16.Size = new Size(94, 62);
            button16.TabIndex = 20;
            button16.Text = "+/-";
            button16.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            button17.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button17.Image = (Image)resources.GetObject("button17.Image");
            button17.Location = new Point(317, 469);
            button17.Margin = new Padding(4);
            button17.Name = "button17";
            button17.Size = new Size(94, 62);
            button17.TabIndex = 19;
            button17.Text = "+";
            button17.UseVisualStyleBackColor = true;
            button17.Click += OperatorButton_Click;
            // 
            // button18
            // 
            button18.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button18.Location = new Point(216, 469);
            button18.Margin = new Padding(4);
            button18.Name = "button18";
            button18.Size = new Size(94, 62);
            button18.TabIndex = 18;
            button18.Text = "3";
            button18.UseVisualStyleBackColor = true;
            button18.Click += ZahlButton_Click;
            // 
            // button19
            // 
            button19.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button19.Location = new Point(115, 469);
            button19.Margin = new Padding(4);
            button19.Name = "button19";
            button19.Size = new Size(94, 62);
            button19.TabIndex = 17;
            button19.Text = "2";
            button19.UseVisualStyleBackColor = true;
            button19.Click += ZahlButton_Click;
            // 
            // button20
            // 
            button20.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button20.Location = new Point(14, 469);
            button20.Margin = new Padding(4);
            button20.Name = "button20";
            button20.Size = new Size(94, 62);
            button20.TabIndex = 16;
            button20.Text = "1";
            button20.UseVisualStyleBackColor = true;
            button20.Click += ZahlButton_Click;
            // 
            // button21
            // 
            button21.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button21.Image = (Image)resources.GetObject("button21.Image");
            button21.Location = new Point(317, 399);
            button21.Margin = new Padding(4);
            button21.Name = "button21";
            button21.Size = new Size(94, 62);
            button21.TabIndex = 15;
            button21.Text = "-";
            button21.UseVisualStyleBackColor = true;
            button21.Click += OperatorButton_Click;
            // 
            // button22
            // 
            button22.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button22.Location = new Point(216, 399);
            button22.Margin = new Padding(4);
            button22.Name = "button22";
            button22.Size = new Size(94, 62);
            button22.TabIndex = 14;
            button22.Text = "6";
            button22.UseVisualStyleBackColor = true;
            button22.Click += ZahlButton_Click;
            // 
            // button23
            // 
            button23.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button23.Location = new Point(115, 399);
            button23.Margin = new Padding(4);
            button23.Name = "button23";
            button23.Size = new Size(94, 62);
            button23.TabIndex = 13;
            button23.Text = "5";
            button23.UseVisualStyleBackColor = true;
            button23.Click += ZahlButton_Click;
            // 
            // button24
            // 
            button24.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button24.Location = new Point(14, 399);
            button24.Margin = new Padding(4);
            button24.Name = "button24";
            button24.Size = new Size(94, 62);
            button24.TabIndex = 12;
            button24.Text = "4";
            button24.UseVisualStyleBackColor = true;
            button24.Click += ZahlButton_Click;
            // 
            // textBoxAusgabe
            // 
            textBoxAusgabe.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxAusgabe.Location = new Point(15, 98);
            textBoxAusgabe.Margin = new Padding(4);
            textBoxAusgabe.Name = "textBoxAusgabe";
            textBoxAusgabe.Size = new Size(396, 27);
            textBoxAusgabe.TabIndex = 24;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.Location = new Point(15, 45);
            textBox2.Margin = new Padding(4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(396, 27);
            textBox2.TabIndex = 25;
            // 
            // button25
            // 
            button25.Location = new Point(14, 150);
            button25.Name = "button25";
            button25.Size = new Size(74, 35);
            button25.TabIndex = 26;
            button25.Text = "MC";
            button25.UseVisualStyleBackColor = true;
            button25.Click += MCButton_Click;
            // 
            // button27
            // 
            button27.Location = new Point(334, 150);
            button27.Name = "button27";
            button27.Size = new Size(75, 35);
            button27.TabIndex = 28;
            button27.Text = "MS";
            button27.UseVisualStyleBackColor = true;
            button27.Click += MSButton_Click;
            // 
            // button28
            // 
            button28.Location = new Point(254, 150);
            button28.Name = "button28";
            button28.Size = new Size(74, 35);
            button28.TabIndex = 29;
            button28.Text = "M-";
            button28.UseVisualStyleBackColor = true;
            button28.Click += MminusButton_Click;
            // 
            // button29
            // 
            button29.Location = new Point(174, 150);
            button29.Name = "button29";
            button29.Size = new Size(74, 35);
            button29.TabIndex = 30;
            button29.Text = "M+";
            button29.UseVisualStyleBackColor = true;
            button29.Click += MplusButton_Click;
            // 
            // button30
            // 
            button30.Location = new Point(94, 150);
            button30.Name = "button30";
            button30.Size = new Size(74, 35);
            button30.TabIndex = 31;
            button30.Text = "MR";
            button30.UseVisualStyleBackColor = true;
            button30.Click += MRButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(425, 619);
            Controls.Add(button30);
            Controls.Add(button29);
            Controls.Add(button28);
            Controls.Add(button27);
            Controls.Add(button25);
            Controls.Add(textBox2);
            Controls.Add(textBoxAusgabe);
            Controls.Add(button13);
            Controls.Add(button14);
            Controls.Add(button15);
            Controls.Add(button16);
            Controls.Add(button17);
            Controls.Add(button18);
            Controls.Add(button19);
            Controls.Add(button20);
            Controls.Add(button21);
            Controls.Add(button22);
            Controls.Add(button23);
            Controls.Add(button24);
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
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;
        private Button button18;
        private Button button19;
        private Button button20;
        private Button button21;
        private Button button22;
        private Button button23;
        private Button button24;
        private TextBox textBoxAusgabe;
        private TextBox textBox2;
        private Button button25;
        private Button button27;
        private Button button28;
        private Button button29;
        private Button button30;
    }
}