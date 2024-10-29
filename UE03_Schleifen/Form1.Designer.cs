namespace UE03_Schleifen
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
            button2 = new Button();
            label3 = new Label();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(45, 68);
            button1.Name = "button1";
            button1.Size = new Size(338, 74);
            button1.TabIndex = 0;
            button1.Text = "For loop";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(410, 82);
            label1.Name = "label1";
            label1.Size = new Size(38, 50);
            label1.TabIndex = 1;
            label1.Text = "?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(875, 82);
            label2.Name = "label2";
            label2.Size = new Size(38, 50);
            label2.TabIndex = 3;
            label2.Text = "?";
            // 
            // button2
            // 
            button2.Location = new Point(521, 75);
            button2.Name = "button2";
            button2.Size = new Size(338, 74);
            button2.TabIndex = 2;
            button2.Text = "While loop";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(1336, 75);
            label3.Name = "label3";
            label3.Size = new Size(38, 50);
            label3.TabIndex = 5;
            label3.Text = "?";
            // 
            // button3
            // 
            button3.Location = new Point(982, 68);
            button3.Name = "button3";
            button3.Size = new Size(338, 74);
            button3.TabIndex = 4;
            button3.Text = "do while loop";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1654, 789);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(label2);
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
        private Label label2;
        private Button button2;
        private Label label3;
        private Button button3;
    }
}
