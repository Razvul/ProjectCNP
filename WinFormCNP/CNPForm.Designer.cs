
namespace WinFormCNP
{
    partial class CNPForm
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
            this.comboBox_Judete = new System.Windows.Forms.ComboBox();
            this.comboBox_Luni = new System.Windows.Forms.ComboBox();
            this.comboBox_Zile = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBox_Judete
            // 
            this.comboBox_Judete.FormattingEnabled = true;
            this.comboBox_Judete.Location = new System.Drawing.Point(512, 34);
            this.comboBox_Judete.Name = "comboBox_Judete";
            this.comboBox_Judete.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Judete.TabIndex = 0;
            // 
            // comboBox_Luni
            // 
            this.comboBox_Luni.FormattingEnabled = true;
            this.comboBox_Luni.Location = new System.Drawing.Point(512, 103);
            this.comboBox_Luni.Name = "comboBox_Luni";
            this.comboBox_Luni.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Luni.TabIndex = 1;
            // 
            // comboBox_Zile
            // 
            this.comboBox_Zile.FormattingEnabled = true;
            this.comboBox_Zile.Location = new System.Drawing.Point(512, 189);
            this.comboBox_Zile.Name = "comboBox_Zile";
            this.comboBox_Zile.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Zile.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox_Zile);
            this.Controls.Add(this.comboBox_Luni);
            this.Controls.Add(this.comboBox_Judete);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Judete;
        private System.Windows.Forms.ComboBox comboBox_Luni;
        private System.Windows.Forms.ComboBox comboBox_Zile;
    }
}

