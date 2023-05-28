namespace AsyncInAwaitBaza
{
    partial class okno
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
            this.isci_button = new System.Windows.Forms.Button();
            this.rezultat = new System.Windows.Forms.TextBox();
            this.podrocjeComboBox = new System.Windows.Forms.ComboBox();
            this.nobelLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // isci_button
            // 
            this.isci_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isci_button.Location = new System.Drawing.Point(40, 331);
            this.isci_button.Name = "isci_button";
            this.isci_button.Size = new System.Drawing.Size(150, 50);
            this.isci_button.TabIndex = 0;
            this.isci_button.Text = "Išči";
            this.isci_button.UseVisualStyleBackColor = true;
            this.isci_button.Click += new System.EventHandler(this.Isci);
            // 
            // rezultat
            // 
            this.rezultat.Location = new System.Drawing.Point(312, 12);
            this.rezultat.Multiline = true;
            this.rezultat.Name = "rezultat";
            this.rezultat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.rezultat.Size = new System.Drawing.Size(476, 426);
            this.rezultat.TabIndex = 1;
            // 
            // podrocjeComboBox
            // 
            this.podrocjeComboBox.FormattingEnabled = true;
            this.podrocjeComboBox.Location = new System.Drawing.Point(40, 194);
            this.podrocjeComboBox.Name = "podrocjeComboBox";
            this.podrocjeComboBox.Size = new System.Drawing.Size(150, 28);
            this.podrocjeComboBox.TabIndex = 2;
            // 
            // nobelLabel
            // 
            this.nobelLabel.AutoSize = true;
            this.nobelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nobelLabel.Location = new System.Drawing.Point(53, 49);
            this.nobelLabel.Name = "nobelLabel";
            this.nobelLabel.Size = new System.Drawing.Size(106, 37);
            this.nobelLabel.TabIndex = 3;
            this.nobelLabel.Text = "Nobel";
            // 
            // okno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nobelLabel);
            this.Controls.Add(this.podrocjeComboBox);
            this.Controls.Add(this.rezultat);
            this.Controls.Add(this.isci_button);
            this.Name = "okno";
            this.Text = "Okno";
            this.Load += new System.EventHandler(this.OknoNalozi);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button isci_button;
        private System.Windows.Forms.TextBox rezultat;
        private System.Windows.Forms.ComboBox podrocjeComboBox;
        private System.Windows.Forms.Label nobelLabel;
    }
}

