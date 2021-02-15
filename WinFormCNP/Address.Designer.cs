
namespace WinFormCNP
{
    partial class Address
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
            this.comboBox_Orase = new System.Windows.Forms.ComboBox();
            this.label_nume_prenume = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox_Orase
            // 
            this.comboBox_Orase.FormattingEnabled = true;
            this.comboBox_Orase.Location = new System.Drawing.Point(70, 86);
            this.comboBox_Orase.Name = "comboBox_Orase";
            this.comboBox_Orase.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Orase.TabIndex = 0;
            // 
            // label_nume_prenume
            // 
            this.label_nume_prenume.AutoSize = true;
            this.label_nume_prenume.Location = new System.Drawing.Point(16, 23);
            this.label_nume_prenume.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_nume_prenume.Name = "label_nume_prenume";
            this.label_nume_prenume.Size = new System.Drawing.Size(35, 13);
            this.label_nume_prenume.TabIndex = 1;
            this.label_nume_prenume.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // Address
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 391);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_nume_prenume);
            this.Controls.Add(this.comboBox_Orase);
            this.MaximumSize = new System.Drawing.Size(600, 500);
            this.MinimumSize = new System.Drawing.Size(350, 300);
            this.Name = "Address";
            this.Text = "Address";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Orase;
        private System.Windows.Forms.Label label_nume_prenume;
        private System.Windows.Forms.Label label2;
    }
}