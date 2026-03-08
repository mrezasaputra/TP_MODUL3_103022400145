namespace TP_MODUL3_103022400145
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
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            buttonTambah = new Button();
            buttonSamaDengan = new Button();
            labelHasil = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 18F);
            button1.Location = new Point(166, 145);
            button1.Name = "button1";
            button1.Size = new Size(101, 98);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 18F);
            button2.Location = new Point(273, 145);
            button2.Name = "button2";
            button2.Size = new Size(101, 98);
            button2.TabIndex = 1;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 18F);
            button3.Location = new Point(380, 145);
            button3.Name = "button3";
            button3.Size = new Size(101, 98);
            button3.TabIndex = 2;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 18F);
            button4.Location = new Point(166, 249);
            button4.Name = "button4";
            button4.Size = new Size(101, 98);
            button4.TabIndex = 3;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 18F);
            button5.Location = new Point(273, 249);
            button5.Name = "button5";
            button5.Size = new Size(101, 98);
            button5.TabIndex = 4;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 18F);
            button6.Location = new Point(380, 249);
            button6.Name = "button6";
            button6.Size = new Size(101, 98);
            button6.TabIndex = 5;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 18F);
            button7.Location = new Point(166, 353);
            button7.Name = "button7";
            button7.Size = new Size(101, 98);
            button7.TabIndex = 6;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 18F);
            button8.Location = new Point(273, 353);
            button8.Name = "button8";
            button8.Size = new Size(101, 98);
            button8.TabIndex = 7;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 18F);
            button9.Location = new Point(380, 353);
            button9.Name = "button9";
            button9.Size = new Size(101, 98);
            button9.TabIndex = 8;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Font = new Font("Segoe UI", 18F);
            button10.Location = new Point(273, 457);
            button10.Name = "button10";
            button10.Size = new Size(101, 98);
            button10.TabIndex = 9;
            button10.Text = "0";
            button10.UseVisualStyleBackColor = true;
            // 
            // buttonTambah
            // 
            buttonTambah.Font = new Font("Segoe UI", 18F);
            buttonTambah.Location = new Point(166, 457);
            buttonTambah.Name = "buttonTambah";
            buttonTambah.Size = new Size(101, 98);
            buttonTambah.TabIndex = 10;
            buttonTambah.Text = "+";
            buttonTambah.UseVisualStyleBackColor = true;
            // 
            // buttonSamaDengan
            // 
            buttonSamaDengan.Font = new Font("Segoe UI", 18F);
            buttonSamaDengan.Location = new Point(380, 457);
            buttonSamaDengan.Name = "buttonSamaDengan";
            buttonSamaDengan.Size = new Size(101, 98);
            buttonSamaDengan.TabIndex = 11;
            buttonSamaDengan.Text = "=";
            buttonSamaDengan.UseVisualStyleBackColor = true;
            // 
            // labelHasil
            // 
            labelHasil.Font = new Font("Segoe UI", 18F);
            labelHasil.Location = new Point(166, 49);
            labelHasil.Name = "labelHasil";
            labelHasil.Size = new Size(315, 93);
            labelHasil.TabIndex = 12;
            labelHasil.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(663, 578);
            Controls.Add(labelHasil);
            Controls.Add(buttonSamaDengan);
            Controls.Add(buttonTambah);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Kalkulator Sederhana";
            ResumeLayout(false);
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
        private Button buttonTambah;
        private Button buttonSamaDengan;
        private Label labelHasil;
    }
}
