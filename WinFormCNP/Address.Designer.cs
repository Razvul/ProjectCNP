
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
            this.comboBox_Orase.Location = new System.Drawing.Point(93, 106);
            this.comboBox_Orase.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_Orase.Name = "comboBox_Orase";
            this.comboBox_Orase.Size = new System.Drawing.Size(160, 24);
            this.comboBox_Orase.TabIndex = 0;
            // 
            // label_nume_prenume
            // 
            this.label_nume_prenume.AutoSize = true;
            this.label_nume_prenume.Location = new System.Drawing.Point(22, 28);
            this.label_nume_prenume.Name = "label_nume_prenume";
            this.label_nume_prenume.Size = new System.Drawing.Size(46, 17);
            this.label_nume_prenume.TabIndex = 1;
            this.label_nume_prenume.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // AddressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 475);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_nume_prenume);
            this.Controls.Add(this.comboBox_Orase);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddressForm";
            this.Text = "AddressForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Orase;
        private System.Windows.Forms.Label label_nume_prenume;
        private System.Windows.Forms.Label label2;
    }
}