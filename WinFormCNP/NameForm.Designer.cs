
namespace WinFormCNP
{
    partial class NameForm
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
            this.textBox_Nume = new System.Windows.Forms.TextBox();
            this.textBox_Prenume = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_Nume
            // 
            this.textBox_Nume.Location = new System.Drawing.Point(113, 83);
            this.textBox_Nume.MaxLength = 15;
            this.textBox_Nume.Name = "textBox_Nume";
            this.textBox_Nume.Size = new System.Drawing.Size(100, 20);
            this.textBox_Nume.TabIndex = 0;
            // 
            // textBox_Prenume
            // 
            this.textBox_Prenume.Location = new System.Drawing.Point(113, 146);
            this.textBox_Prenume.MaxLength = 15;
            this.textBox_Prenume.Name = "textBox_Prenume";
            this.textBox_Prenume.Size = new System.Drawing.Size(100, 20);
            this.textBox_Prenume.TabIndex = 1;
            // 
            // NameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_Prenume);
            this.Controls.Add(this.textBox_Nume);
            this.Name = "NameForm";
            this.Text = "NameForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Nume;
        private System.Windows.Forms.TextBox textBox_Prenume;
    }
}