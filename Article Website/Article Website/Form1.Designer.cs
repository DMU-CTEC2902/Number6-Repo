namespace Article_Website
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Music = new System.Windows.Forms.Label();
            this.Exercise = new System.Windows.Forms.Label();
            this.Sports = new System.Windows.Forms.Label();
            this.Gaming = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Music
            // 
            this.Music.AutoSize = true;
            this.Music.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Music.Location = new System.Drawing.Point(96, 38);
            this.Music.Name = "Music";
            this.Music.Size = new System.Drawing.Size(81, 29);
            this.Music.TabIndex = 0;
            this.Music.Text = "Music";
            // 
            // Exercise
            // 
            this.Exercise.AutoSize = true;
            this.Exercise.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exercise.Location = new System.Drawing.Point(350, 38);
            this.Exercise.Name = "Exercise";
            this.Exercise.Size = new System.Drawing.Size(114, 29);
            this.Exercise.TabIndex = 1;
            this.Exercise.Text = "Exercise";
            // 
            // Sports
            // 
            this.Sports.AutoSize = true;
            this.Sports.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sports.Location = new System.Drawing.Point(222, 38);
            this.Sports.Name = "Sports";
            this.Sports.Size = new System.Drawing.Size(89, 29);
            this.Sports.TabIndex = 2;
            this.Sports.Text = "Sports";
            // 
            // Gaming
            // 
            this.Gaming.AutoSize = true;
            this.Gaming.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gaming.Location = new System.Drawing.Point(495, 38);
            this.Gaming.Name = "Gaming";
            this.Gaming.Size = new System.Drawing.Size(103, 29);
            this.Gaming.TabIndex = 3;
            this.Gaming.Text = "Gaming";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Gaming);
            this.Controls.Add(this.Sports);
            this.Controls.Add(this.Exercise);
            this.Controls.Add(this.Music);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Music;
        private System.Windows.Forms.Label Exercise;
        private System.Windows.Forms.Label Sports;
        private System.Windows.Forms.Label Gaming;
    }
}

