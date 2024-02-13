namespace WFAFibonacciOdev_0
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
            this.btnhesapla = new System.Windows.Forms.Button();
            this.txtsayi = new System.Windows.Forms.TextBox();
            this.lblsonuc = new System.Windows.Forms.Label();
            this.lbsonuc = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnhesapla
            // 
            this.btnhesapla.Location = new System.Drawing.Point(54, 114);
            this.btnhesapla.Name = "btnhesapla";
            this.btnhesapla.Size = new System.Drawing.Size(75, 23);
            this.btnhesapla.TabIndex = 0;
            this.btnhesapla.Text = "Hesapla";
            this.btnhesapla.UseVisualStyleBackColor = true;
            this.btnhesapla.Click += new System.EventHandler(this.btnhesapla_Click);
            // 
            // txtsayi
            // 
            this.txtsayi.Location = new System.Drawing.Point(36, 83);
            this.txtsayi.Name = "txtsayi";
            this.txtsayi.Size = new System.Drawing.Size(133, 20);
            this.txtsayi.TabIndex = 1;
            // 
            // lblsonuc
            // 
            this.lblsonuc.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblsonuc.Location = new System.Drawing.Point(515, 60);
            this.lblsonuc.Name = "lblsonuc";
            this.lblsonuc.Size = new System.Drawing.Size(146, 43);
            this.lblsonuc.TabIndex = 2;
            // 
            // lbsonuc
            // 
            this.lbsonuc.FormattingEnabled = true;
            this.lbsonuc.Location = new System.Drawing.Point(528, 186);
            this.lbsonuc.Name = "lbsonuc";
            this.lbsonuc.Size = new System.Drawing.Size(193, 134);
            this.lbsonuc.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbsonuc);
            this.Controls.Add(this.lblsonuc);
            this.Controls.Add(this.txtsayi);
            this.Controls.Add(this.btnhesapla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnhesapla;
        private System.Windows.Forms.TextBox txtsayi;
        private System.Windows.Forms.Label lblsonuc;
        private System.Windows.Forms.ListBox lbsonuc;
    }
}

