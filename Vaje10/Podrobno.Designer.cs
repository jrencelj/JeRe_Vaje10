namespace Vaje10
{
    partial class Podrobno
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
            this.naslov_label = new System.Windows.Forms.Label();
            this.opis_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // naslov_label
            // 
            this.naslov_label.AutoSize = true;
            this.naslov_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.naslov_label.Location = new System.Drawing.Point(12, 9);
            this.naslov_label.Name = "naslov_label";
            this.naslov_label.Size = new System.Drawing.Size(106, 37);
            this.naslov_label.TabIndex = 0;
            this.naslov_label.Text = "label1";
            // 
            // opis_textBox
            // 
            this.opis_textBox.Location = new System.Drawing.Point(19, 70);
            this.opis_textBox.Multiline = true;
            this.opis_textBox.Name = "opis_textBox";
            this.opis_textBox.Size = new System.Drawing.Size(752, 288);
            this.opis_textBox.TabIndex = 1;
            // 
            // Podrobno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.opis_textBox);
            this.Controls.Add(this.naslov_label);
            this.Name = "Podrobno";
            this.Text = "Podrobno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label naslov_label;
        private System.Windows.Forms.TextBox opis_textBox;
    }
}