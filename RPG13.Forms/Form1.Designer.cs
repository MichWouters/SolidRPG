﻿namespace RPG13.Forms
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
            txtLogging = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtLogging
            // 
            txtLogging.Location = new Point(14, 7);
            txtLogging.Multiline = true;
            txtLogging.Name = "txtLogging";
            txtLogging.Size = new Size(774, 391);
            txtLogging.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(15, 409);
            button1.Name = "button1";
            button1.Size = new Size(773, 29);
            button1.TabIndex = 1;
            button1.Text = "Start Game";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(txtLogging);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLogging;
        private Button button1;
    }
}
