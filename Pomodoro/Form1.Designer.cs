namespace Pomodoro
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
            BakingACake = new TextBox();
            label1 = new Label();
            numericUpDown1 = new NumericUpDown();
            Timecount = new Label();
            button1 = new Button();
            button2 = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ShortBreak = new NumericUpDown();
            LongBreak = new NumericUpDown();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ShortBreak).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LongBreak).BeginInit();
            SuspendLayout();
            // 
            // BakingACake
            // 
            BakingACake.Location = new Point(11, 14);
            BakingACake.Multiline = true;
            BakingACake.Name = "BakingACake";
            BakingACake.Size = new Size(769, 42);
            BakingACake.TabIndex = 0;
            BakingACake.Text = "Baking a Cake";
            BakingACake.TextChanged += BakingACake_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 78);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 2;
            label1.Text = "Time";
            // 
            // numericUpDown1
            // 
            numericUpDown1.AccessibleName = "Duration";
            numericUpDown1.Location = new Point(89, 76);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(52, 23);
            numericUpDown1.TabIndex = 3;
            numericUpDown1.Value = new decimal(new int[] { 25, 0, 0, 0 });
            // 
            // Timecount
            // 
            Timecount.AutoSize = true;
            Timecount.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Timecount.Location = new Point(289, 177);
            Timecount.Name = "Timecount";
            Timecount.Size = new Size(191, 86);
            Timecount.TabIndex = 4;
            Timecount.Text = "25:00";
            // 
            // button1
            // 
            button1.Location = new Point(219, 320);
            button1.Name = "button1";
            button1.Size = new Size(144, 53);
            button1.TabIndex = 5;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(390, 320);
            button2.Name = "button2";
            button2.Size = new Size(144, 53);
            button2.TabIndex = 6;
            button2.TabStop = false;
            button2.Text = "Stop";
            button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(147, 84);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 7;
            label3.Text = "Minutes";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 130);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 8;
            label4.Text = "Short Break :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 171);
            label5.Name = "label5";
            label5.Size = new Size(72, 15);
            label5.TabIndex = 9;
            label5.Text = "Long Break :";
            // 
            // ShortBreak
            // 
            ShortBreak.Location = new Point(109, 122);
            ShortBreak.Name = "ShortBreak";
            ShortBreak.Size = new Size(52, 23);
            ShortBreak.TabIndex = 10;
            ShortBreak.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // LongBreak
            // 
            LongBreak.Location = new Point(109, 169);
            LongBreak.Name = "LongBreak";
            LongBreak.Size = new Size(52, 23);
            LongBreak.TabIndex = 11;
            LongBreak.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(176, 130);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 12;
            label6.Text = "Minutes";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(176, 177);
            label7.Name = "label7";
            label7.Size = new Size(50, 15);
            label7.TabIndex = 13;
            label7.Text = "Minutes";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(311, 84);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 14;
            label8.Text = "label8";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(LongBreak);
            Controls.Add(ShortBreak);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Timecount);
            Controls.Add(numericUpDown1);
            Controls.Add(label1);
            Controls.Add(BakingACake);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ShortBreak).EndInit();
            ((System.ComponentModel.ISupportInitialize)LongBreak).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox BakingACake;
        private Label label1;
        private NumericUpDown numericUpDown1;
        private Label Timecount;
        private Button button1;
        private Button button2;
        private Label label3;
        private Label label4;
        private Label label5;
        private NumericUpDown ShortBreak;
        private NumericUpDown LongBreak;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}
