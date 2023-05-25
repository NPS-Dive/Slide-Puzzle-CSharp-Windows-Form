namespace WinFormsApp_05_SlidePuzzle
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
        protected override void Dispose ( bool disposing )
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
        private void InitializeComponent ()
            {
            groupBox1 = new GroupBox();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.AppWorkspace;
            groupBox1.Controls.Add(button9);
            groupBox1.Controls.Add(button8);
            groupBox1.Controls.Add(button7);
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(14, 14);
            groupBox1.Margin = new Padding(5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5);
            groupBox1.Size = new Size(255, 269);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button9
            // 
            button9.Font = new Font("Comic Sans MS", 30F, FontStyle.Bold, GraphicsUnit.Point);
            button9.ForeColor = Color.RosyBrown;
            button9.Location = new Point(170, 186);
            button9.Name = "button9";
            button9.Size = new Size(75, 75);
            button9.TabIndex = 8;
            button9.UseVisualStyleBackColor = true;
            button9.Visible = false;
            button9.Click += button9_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Comic Sans MS", 30F, FontStyle.Bold, GraphicsUnit.Point);
            button8.ForeColor = Color.RosyBrown;
            button8.Location = new Point(89, 186);
            button8.Name = "button8";
            button8.Size = new Size(75, 75);
            button8.TabIndex = 7;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Comic Sans MS", 30F, FontStyle.Bold, GraphicsUnit.Point);
            button7.ForeColor = Color.RosyBrown;
            button7.Location = new Point(8, 186);
            button7.Name = "button7";
            button7.Size = new Size(75, 75);
            button7.TabIndex = 6;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Comic Sans MS", 30F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = Color.RosyBrown;
            button6.Location = new Point(170, 105);
            button6.Name = "button6";
            button6.Size = new Size(75, 75);
            button6.TabIndex = 5;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Comic Sans MS", 30F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.RosyBrown;
            button5.Location = new Point(89, 105);
            button5.Name = "button5";
            button5.Size = new Size(75, 75);
            button5.TabIndex = 4;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Comic Sans MS", 30F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.RosyBrown;
            button4.Location = new Point(8, 105);
            button4.Name = "button4";
            button4.Size = new Size(75, 75);
            button4.TabIndex = 3;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Comic Sans MS", 30F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.RosyBrown;
            button3.Location = new Point(170, 24);
            button3.Name = "button3";
            button3.Size = new Size(75, 75);
            button3.TabIndex = 2;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Comic Sans MS", 30F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.RosyBrown;
            button2.Location = new Point(89, 24);
            button2.Name = "button2";
            button2.Size = new Size(75, 75);
            button2.TabIndex = 1;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Comic Sans MS", 30F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.RosyBrown;
            button1.Location = new Point(8, 24);
            button1.Name = "button1";
            button1.Size = new Size(75, 75);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(291, 296);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Slide Puzzle | IPBSES";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            }

        #endregion

        private GroupBox groupBox1;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button9;
        }
    }