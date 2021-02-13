
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
            this.label_Judete = new System.Windows.Forms.Label();
            this.label_Luni = new System.Windows.Forms.Label();
            this.label_Zile = new System.Windows.Forms.Label();
            this.label_An = new System.Windows.Forms.Label();
            this.comboBox_An = new System.Windows.Forms.ComboBox();
            this.label_CNP = new System.Windows.Forms.Label();
            this.label_CNP_Result = new System.Windows.Forms.Label();
            this.button_Clear = new System.Windows.Forms.Button();
            this.label_Sex = new System.Windows.Forms.Label();
            this.comboBox_Sex = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBox_Judete
            // 
            this.comboBox_Judete.FormattingEnabled = true;
            this.comboBox_Judete.Location = new System.Drawing.Point(16, 124);
            this.comboBox_Judete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_Judete.Name = "comboBox_Judete";
            this.comboBox_Judete.Size = new System.Drawing.Size(160, 24);
            this.comboBox_Judete.TabIndex = 0;
            this.comboBox_Judete.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox_Judete_KeyPress);
            // 
            // comboBox_Luni
            // 
            this.comboBox_Luni.FormattingEnabled = true;
            this.comboBox_Luni.Location = new System.Drawing.Point(201, 124);
            this.comboBox_Luni.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_Luni.Name = "comboBox_Luni";
            this.comboBox_Luni.Size = new System.Drawing.Size(160, 24);
            this.comboBox_Luni.TabIndex = 1;
            this.comboBox_Luni.SelectedValueChanged += new System.EventHandler(this.comboBox_Luni_SelectedValueChanged);
            this.comboBox_Luni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox_Luni_KeyPress);
            // 
            // comboBox_Zile
            // 
            this.comboBox_Zile.FormattingEnabled = true;
            this.comboBox_Zile.Location = new System.Drawing.Point(395, 124);
            this.comboBox_Zile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_Zile.Name = "comboBox_Zile";
            this.comboBox_Zile.Size = new System.Drawing.Size(160, 24);
            this.comboBox_Zile.TabIndex = 2;
            this.comboBox_Zile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox_Zile_KeyPress);
            // 
            // label_Judete
            // 
            this.label_Judete.AutoSize = true;
            this.label_Judete.Location = new System.Drawing.Point(16, 55);
            this.label_Judete.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Judete.Name = "label_Judete";
            this.label_Judete.Size = new System.Drawing.Size(51, 17);
            this.label_Judete.TabIndex = 3;
            this.label_Judete.Text = "Judete";
            // 
            // label_Luni
            // 
            this.label_Luni.AutoSize = true;
            this.label_Luni.Location = new System.Drawing.Point(197, 55);
            this.label_Luni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Luni.Name = "label_Luni";
            this.label_Luni.Size = new System.Drawing.Size(35, 17);
            this.label_Luni.TabIndex = 4;
            this.label_Luni.Text = "Luni";
            // 
            // label_Zile
            // 
            this.label_Zile.AutoSize = true;
            this.label_Zile.Location = new System.Drawing.Point(391, 55);
            this.label_Zile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Zile.Name = "label_Zile";
            this.label_Zile.Size = new System.Drawing.Size(31, 17);
            this.label_Zile.TabIndex = 5;
            this.label_Zile.Text = "Zile";
            // 
            // label_An
            // 
            this.label_An.AutoSize = true;
            this.label_An.Location = new System.Drawing.Point(597, 55);
            this.label_An.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_An.Name = "label_An";
            this.label_An.Size = new System.Drawing.Size(25, 17);
            this.label_An.TabIndex = 6;
            this.label_An.Text = "An";
            // 
            // comboBox_An
            // 
            this.comboBox_An.FormattingEnabled = true;
            this.comboBox_An.Location = new System.Drawing.Point(601, 124);
            this.comboBox_An.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_An.Name = "comboBox_An";
            this.comboBox_An.Size = new System.Drawing.Size(160, 24);
            this.comboBox_An.TabIndex = 7;
            this.comboBox_An.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox_An_KeyPress);
            // 
            // label_CNP
            // 
            this.label_CNP.AutoSize = true;
            this.label_CNP.Location = new System.Drawing.Point(16, 299);
            this.label_CNP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_CNP.Name = "label_CNP";
            this.label_CNP.Size = new System.Drawing.Size(36, 17);
            this.label_CNP.TabIndex = 8;
            this.label_CNP.Text = "CNP";
            // 
            // label_CNP_Result
            // 
            this.label_CNP_Result.AutoSize = true;
            this.label_CNP_Result.Location = new System.Drawing.Point(16, 353);
            this.label_CNP_Result.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_CNP_Result.Name = "label_CNP_Result";
            this.label_CNP_Result.Size = new System.Drawing.Size(80, 17);
            this.label_CNP_Result.TabIndex = 9;
            this.label_CNP_Result.Text = "CNP Result";
            // 
            // button_Clear
            // 
            this.button_Clear.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_Clear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_Clear.Location = new System.Drawing.Point(871, 341);
            this.button_Clear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(100, 28);
            this.button_Clear.TabIndex = 10;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = false;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // label_Sex
            // 
            this.label_Sex.AutoSize = true;
            this.label_Sex.Location = new System.Drawing.Point(805, 55);
            this.label_Sex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Sex.Name = "label_Sex";
            this.label_Sex.Size = new System.Drawing.Size(31, 17);
            this.label_Sex.TabIndex = 11;
            this.label_Sex.Text = "Sex";
            // 
            // comboBox_Sex
            // 
            this.comboBox_Sex.FormattingEnabled = true;
            this.comboBox_Sex.Location = new System.Drawing.Point(809, 124);
            this.comboBox_Sex.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_Sex.Name = "comboBox_Sex";
            this.comboBox_Sex.Size = new System.Drawing.Size(160, 24);
            this.comboBox_Sex.TabIndex = 12;
            this.comboBox_Sex.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox_Sex_KeyPress);
            // 
            // CNPForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 463);
            this.Controls.Add(this.comboBox_Sex);
            this.Controls.Add(this.label_Sex);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.label_CNP_Result);
            this.Controls.Add(this.label_CNP);
            this.Controls.Add(this.comboBox_An);
            this.Controls.Add(this.label_An);
            this.Controls.Add(this.label_Zile);
            this.Controls.Add(this.label_Luni);
            this.Controls.Add(this.label_Judete);
            this.Controls.Add(this.comboBox_Zile);
            this.Controls.Add(this.comboBox_Luni);
            this.Controls.Add(this.comboBox_Judete);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CNPForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.CNPForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Judete;
        private System.Windows.Forms.ComboBox comboBox_Luni;
        private System.Windows.Forms.ComboBox comboBox_Zile;
        private System.Windows.Forms.Label label_Judete;
        private System.Windows.Forms.Label label_Luni;
        private System.Windows.Forms.Label label_Zile;
        private System.Windows.Forms.Label label_An;
        private System.Windows.Forms.ComboBox comboBox_An;
        private System.Windows.Forms.Label label_CNP;
        private System.Windows.Forms.Label label_CNP_Result;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Label label_Sex;
        private System.Windows.Forms.ComboBox comboBox_Sex;
    }
}

