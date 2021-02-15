
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
            this.textBox_Sex = new System.Windows.Forms.TextBox();
            this.label_Nume = new System.Windows.Forms.Label();
            this.label_Prenume = new System.Windows.Forms.Label();
            this.label_Sex = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_Nume
            // 
            this.textBox_Nume.Location = new System.Drawing.Point(159, 72);
            this.textBox_Nume.MaxLength = 20;
            this.textBox_Nume.Name = "textBox_Nume";
            this.textBox_Nume.Size = new System.Drawing.Size(100, 20);
            this.textBox_Nume.TabIndex = 0;
            this.textBox_Nume.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Nume_KeyPress);
            // 
            // textBox_Prenume
            // 
            this.textBox_Prenume.Location = new System.Drawing.Point(159, 139);
            this.textBox_Prenume.MaxLength = 20;
            this.textBox_Prenume.Name = "textBox_Prenume";
            this.textBox_Prenume.Size = new System.Drawing.Size(100, 20);
            this.textBox_Prenume.TabIndex = 1;
            this.textBox_Prenume.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Prenume_KeyPress);
            // 
            // textBox_Sex
            // 
            this.textBox_Sex.Location = new System.Drawing.Point(159, 202);
            this.textBox_Sex.Name = "textBox_Sex";
            this.textBox_Sex.Size = new System.Drawing.Size(100, 20);
            this.textBox_Sex.TabIndex = 2;
            // 
            // label_Nume
            // 
            this.label_Nume.AutoSize = true;
            this.label_Nume.Location = new System.Drawing.Point(73, 72);
            this.label_Nume.Name = "label_Nume";
            this.label_Nume.Size = new System.Drawing.Size(35, 13);
            this.label_Nume.TabIndex = 3;
            this.label_Nume.Text = "Nume";
            // 
            // label_Prenume
            // 
            this.label_Prenume.AutoSize = true;
            this.label_Prenume.Location = new System.Drawing.Point(76, 139);
            this.label_Prenume.Name = "label_Prenume";
            this.label_Prenume.Size = new System.Drawing.Size(49, 13);
            this.label_Prenume.TabIndex = 4;
            this.label_Prenume.Text = "Prenume";
            // 
            // label_Sex
            // 
            this.label_Sex.AutoSize = true;
            this.label_Sex.Location = new System.Drawing.Point(76, 202);
            this.label_Sex.Name = "label_Sex";
            this.label_Sex.Size = new System.Drawing.Size(25, 13);
            this.label_Sex.TabIndex = 5;
            this.label_Sex.Text = "Sex";
            // 
            // NameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 352);
            this.Controls.Add(this.label_Sex);
            this.Controls.Add(this.label_Prenume);
            this.Controls.Add(this.label_Nume);
            this.Controls.Add(this.textBox_Sex);
            this.Controls.Add(this.textBox_Prenume);
            this.Controls.Add(this.textBox_Nume);
            this.MaximumSize = new System.Drawing.Size(750, 600);
            this.MinimumSize = new System.Drawing.Size(400, 350);
            this.Name = "NameForm";
            this.Text = "NameForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Nume;
        private System.Windows.Forms.TextBox textBox_Prenume;
        private System.Windows.Forms.TextBox textBox_Sex;
        private System.Windows.Forms.Label label_Nume;
        private System.Windows.Forms.Label label_Prenume;
        private System.Windows.Forms.Label label_Sex;
    }
}