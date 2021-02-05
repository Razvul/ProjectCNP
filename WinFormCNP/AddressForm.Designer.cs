
namespace WinFormCNP
{
    partial class AddressForm
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
            // AddressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox_Orase);
            this.Name = "AddressForm";
            this.Text = "AddressForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Orase;
    }
}