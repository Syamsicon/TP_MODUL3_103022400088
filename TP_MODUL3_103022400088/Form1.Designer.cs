namespace TP_MODUL3_103022400088
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
            LblOutput = new Label();
            panelBtn = new Panel();
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
            panelBtn.SuspendLayout();
            SuspendLayout();
            // 
            // LblOutput
            // 
            LblOutput.BorderStyle = BorderStyle.FixedSingle;
            LblOutput.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblOutput.Location = new Point(12, 12);
            LblOutput.Name = "LblOutput";
            LblOutput.Size = new Size(360, 50);
            LblOutput.TabIndex = 0;
            LblOutput.Text = "0";
            LblOutput.TextAlign = ContentAlignment.MiddleRight;
            LblOutput.Click += label1_Click;
            // 
            // panelBtn
            // 
            panelBtn.Controls.Add(button12);
            panelBtn.Controls.Add(button11);
            panelBtn.Controls.Add(button10);
            panelBtn.Controls.Add(button9);
            panelBtn.Controls.Add(button8);
            panelBtn.Controls.Add(button7);
            panelBtn.Controls.Add(button6);
            panelBtn.Controls.Add(button5);
            panelBtn.Controls.Add(button4);
            panelBtn.Controls.Add(button3);
            panelBtn.Controls.Add(button2);
            panelBtn.Controls.Add(button1);
            panelBtn.Location = new Point(12, 80);
            panelBtn.Name = "panelBtn";
            panelBtn.Size = new Size(360, 360);
            panelBtn.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(100, 80);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(130, 0);
            button2.Name = "button2";
            button2.Size = new Size(100, 80);
            button2.TabIndex = 1;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(260, 0);
            button3.Name = "button3";
            button3.Size = new Size(100, 80);
            button3.TabIndex = 2;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(0, 90);
            button4.Name = "button4";
            button4.Size = new Size(100, 80);
            button4.TabIndex = 3;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(130, 90);
            button5.Name = "button5";
            button5.Size = new Size(100, 80);
            button5.TabIndex = 4;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(260, 90);
            button6.Name = "button6";
            button6.Size = new Size(100, 80);
            button6.TabIndex = 5;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(0, 180);
            button7.Name = "button7";
            button7.Size = new Size(100, 80);
            button7.TabIndex = 6;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(130, 180);
            button8.Name = "button8";
            button8.Size = new Size(100, 80);
            button8.TabIndex = 7;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(260, 180);
            button9.Name = "button9";
            button9.Size = new Size(100, 80);
            button9.TabIndex = 8;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Location = new Point(0, 270);
            button10.Name = "button10";
            button10.Size = new Size(100, 80);
            button10.TabIndex = 9;
            button10.Text = "+";
            button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.Location = new Point(130, 270);
            button11.Name = "button11";
            button11.Size = new Size(100, 80);
            button11.TabIndex = 10;
            button11.Text = "0";
            button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            button12.Location = new Point(260, 270);
            button12.Name = "button12";
            button12.Size = new Size(100, 80);
            button12.TabIndex = 11;
            button12.Text = "=";
            button12.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 453);
            Controls.Add(panelBtn);
            Controls.Add(LblOutput);
            Name = "Form1";
            Text = "Form1";
            panelBtn.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label LblOutput;
        private Panel panelBtn;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button12;
        private Button button11;
        private Button button10;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
    }
}
