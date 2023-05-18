namespace v0518
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
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label2 = new Label();
            button5 = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(372, 78);
            button1.Name = "button1";
            button1.Size = new Size(75, 45);
            button1.TabIndex = 0;
            button1.Text = "↑";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(198, 100);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // button2
            // 
            button2.Location = new Point(300, 121);
            button2.Name = "button2";
            button2.Size = new Size(75, 46);
            button2.TabIndex = 2;
            button2.Text = "←";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(445, 121);
            button3.Name = "button3";
            button3.Size = new Size(83, 46);
            button3.TabIndex = 3;
            button3.Text = "→";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(372, 166);
            button4.Name = "button4";
            button4.Size = new Size(75, 52);
            button4.TabIndex = 4;
            button4.Text = "↓";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(105, 435);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 5;
            label2.Text = "label2";
            // 
            // button5
            // 
            button5.Location = new Point(372, 121);
            button5.Name = "button5";
            button5.Size = new Size(75, 46);
            button5.TabIndex = 6;
            button5.Text = "変化";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonFace;
            label3.Location = new Point(55, 148);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 7;
            label3.Text = "障害物１";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(156, 213);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 8;
            label4.Text = "障害物２";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(111, 295);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 9;
            label5.Text = "障害物３";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button5);
            Controls.Add(label2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label2;
        private Button button5;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}