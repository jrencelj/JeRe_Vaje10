using System.Drawing;

namespace Vaje10
{
    partial class Okno
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
            this.filmi_rb = new System.Windows.Forms.RadioButton();
            this.serije_rb = new System.Windows.Forms.RadioButton();
            this.vsebina_gb = new System.Windows.Forms.GroupBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.vsebina_gb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // isci_button
            // 
            this.isci_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isci_button.Location = new System.Drawing.Point(540, 367);
            this.isci_button.Name = "isci_button";
            this.isci_button.Size = new System.Drawing.Size(150, 50);
            this.isci_button.TabIndex = 0;
            this.isci_button.Text = "Išči";
            this.isci_button.UseVisualStyleBackColor = true;
            this.isci_button.MouseClick += new System.Windows.Forms.MouseEventHandler(this.isci);
            // 
            // filmi_rb
            // 
            this.filmi_rb.AutoSize = true;
            this.filmi_rb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filmi_rb.Location = new System.Drawing.Point(20, 35);
            this.filmi_rb.Name = "filmi_rb";
            this.filmi_rb.Size = new System.Drawing.Size(66, 24);
            this.filmi_rb.TabIndex = 1;
            this.filmi_rb.TabStop = true;
            this.filmi_rb.Text = "Filmi";
            this.filmi_rb.UseVisualStyleBackColor = true;
            // 
            // serije_rb
            // 
            this.serije_rb.AutoSize = true;
            this.serije_rb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serije_rb.Location = new System.Drawing.Point(20, 74);
            this.serije_rb.Name = "serije_rb";
            this.serije_rb.Size = new System.Drawing.Size(74, 24);
            this.serije_rb.TabIndex = 2;
            this.serije_rb.TabStop = true;
            this.serije_rb.Text = "Serije";
            this.serije_rb.UseVisualStyleBackColor = true;
            // 
            // vsebina_gb
            // 
            this.vsebina_gb.Controls.Add(this.filmi_rb);
            this.vsebina_gb.Controls.Add(this.serije_rb);
            this.vsebina_gb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vsebina_gb.Location = new System.Drawing.Point(12, 12);
            this.vsebina_gb.Name = "vsebina_gb";
            this.vsebina_gb.Size = new System.Drawing.Size(228, 122);
            this.vsebina_gb.TabIndex = 3;
            this.vsebina_gb.TabStop = false;
            this.vsebina_gb.Text = "Vsebina";
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(282, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 28;
            this.dataGridView.Size = new System.Drawing.Size(706, 328);
            this.dataGridView.TabIndex = 4;
            this.dataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.vsebinaPodrobno);
            // 
            // Okno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.ClientSize = new System.Drawing.Size(1000, 450);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.vsebina_gb);
            this.Controls.Add(this.isci_button);
            this.Name = "Okno";
            this.Text = "Filmi";
            this.Load += new System.EventHandler(this.oknoLoad);
            this.vsebina_gb.ResumeLayout(false);
            this.vsebina_gb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button isci_button;
        private System.Windows.Forms.RadioButton filmi_rb;
        private System.Windows.Forms.RadioButton serije_rb;
        private System.Windows.Forms.GroupBox vsebina_gb;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}

