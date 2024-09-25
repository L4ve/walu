namespace waluty
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            toolTip1 = new ToolTip(components);
            textBox4 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            groupBox1 = new GroupBox();
            radioButton5 = new RadioButton();
            groupBox2 = new GroupBox();
            label3 = new Label();
            groupBox3 = new GroupBox();
            radioButton6 = new RadioButton();
            radioButton7 = new RadioButton();
            radioButton8 = new RadioButton();
            radioButton9 = new RadioButton();
            radioButton10 = new RadioButton();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 20F);
            button1.Location = new Point(244, 44);
            button1.Name = "button1";
            button1.Size = new Size(249, 228);
            button1.TabIndex = 0;
            button1.Text = "Zamień";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(12, 44);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(217, 23);
            textBox4.TabIndex = 4;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 10;
            label1.Text = "Kwota: ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(610, 181);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 11;
            label2.Click += label2_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(0, 83);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(55, 19);
            radioButton1.TabIndex = 12;
            radioButton1.TabStop = true;
            radioButton1.Text = "EURO";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(0, 108);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(47, 19);
            radioButton2.TabIndex = 13;
            radioButton2.TabStop = true;
            radioButton2.Text = "RUB";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(0, 133);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(48, 19);
            radioButton3.TabIndex = 14;
            radioButton3.TabStop = true;
            radioButton3.Text = "HUF";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(1, 58);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(47, 19);
            radioButton4.TabIndex = 15;
            radioButton4.TabStop = true;
            radioButton4.Text = "USD";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton5);
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Location = new Point(12, 89);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(78, 171);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Waluty";
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(1, 33);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(47, 19);
            radioButton5.TabIndex = 16;
            radioButton5.TabStop = true;
            radioButton5.Text = "PLN";
            radioButton5.UseVisualStyleBackColor = true;
            radioButton5.CheckedChanged += radioButton5_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(519, 44);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(269, 228);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 30F);
            label3.Location = new Point(20, 80);
            label3.Name = "label3";
            label3.Size = new Size(191, 54);
            label3.TabIndex = 0;
            label3.Text = "Wartość...";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(radioButton6);
            groupBox3.Controls.Add(radioButton7);
            groupBox3.Controls.Add(radioButton8);
            groupBox3.Controls.Add(radioButton9);
            groupBox3.Controls.Add(radioButton10);
            groupBox3.Location = new Point(128, 89);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(78, 171);
            groupBox3.TabIndex = 18;
            groupBox3.TabStop = false;
            groupBox3.Text = "Waluty";
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(1, 33);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(47, 19);
            radioButton6.TabIndex = 16;
            radioButton6.TabStop = true;
            radioButton6.Text = "PLN";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            radioButton7.AutoSize = true;
            radioButton7.Location = new Point(1, 58);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(47, 19);
            radioButton7.TabIndex = 15;
            radioButton7.TabStop = true;
            radioButton7.Text = "USD";
            radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            radioButton8.AutoSize = true;
            radioButton8.Location = new Point(0, 133);
            radioButton8.Name = "radioButton8";
            radioButton8.Size = new Size(48, 19);
            radioButton8.TabIndex = 14;
            radioButton8.TabStop = true;
            radioButton8.Text = "HUF";
            radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            radioButton9.AutoSize = true;
            radioButton9.Location = new Point(0, 83);
            radioButton9.Name = "radioButton9";
            radioButton9.Size = new Size(55, 19);
            radioButton9.TabIndex = 12;
            radioButton9.TabStop = true;
            radioButton9.Text = "EURO";
            radioButton9.UseVisualStyleBackColor = true;
            // 
            // radioButton10
            // 
            radioButton10.AutoSize = true;
            radioButton10.Location = new Point(0, 108);
            radioButton10.Name = "radioButton10";
            radioButton10.Size = new Size(47, 19);
            radioButton10.TabIndex = 13;
            radioButton10.TabStop = true;
            radioButton10.Text = "RUB";
            radioButton10.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 301);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox4);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ToolTip toolTip1;
        private TextBox textBox4;
        private Label label1;
        private Label label2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label3;
        private RadioButton radioButton5;
        private GroupBox groupBox3;
        private RadioButton radioButton6;
        private RadioButton radioButton7;
        private RadioButton radioButton8;
        private RadioButton radioButton9;
        private RadioButton radioButton10;
    }
}
