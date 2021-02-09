
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
            this.SuspendLayout();
            // 
            // comboBox_Judete
            // 
            this.comboBox_Judete.FormattingEnabled = true;
            this.comboBox_Judete.Location = new System.Drawing.Point(12, 101);
            this.comboBox_Judete.Name = "comboBox_Judete";
            this.comboBox_Judete.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Judete.TabIndex = 0;
            // 
            // comboBox_Luni
            // 
            this.comboBox_Luni.FormattingEnabled = true;
            this.comboBox_Luni.Location = new System.Drawing.Point(151, 101);
            this.comboBox_Luni.Name = "comboBox_Luni";
            this.comboBox_Luni.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Luni.TabIndex = 1;
            this.comboBox_Luni.SelectedValueChanged += new System.EventHandler(this.comboBox_Luni_SelectedValueChanged);
            // 
            // comboBox_Zile
            // 
            this.comboBox_Zile.FormattingEnabled = true;
            this.comboBox_Zile.Location = new System.Drawing.Point(296, 101);
            this.comboBox_Zile.Name = "comboBox_Zile";
            this.comboBox_Zile.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Zile.TabIndex = 2;
            // 
            // label_Judete
            // 
            this.label_Judete.AutoSize = true;
            this.label_Judete.Location = new System.Drawing.Point(12, 45);
            this.label_Judete.Name = "label_Judete";
            this.label_Judete.Size = new System.Drawing.Size(39, 13);
            this.label_Judete.TabIndex = 3;
            this.label_Judete.Text = "Judete";
            // 
            // label_Luni
            // 
            this.label_Luni.AutoSize = true;
            this.label_Luni.Location = new System.Drawing.Point(148, 45);
            this.label_Luni.Name = "label_Luni";
            this.label_Luni.Size = new System.Drawing.Size(27, 13);
            this.label_Luni.TabIndex = 4;
            this.label_Luni.Text = "Luni";
            // 
            // label_Zile
            // 
            this.label_Zile.AutoSize = true;
            this.label_Zile.Location = new System.Drawing.Point(293, 45);
            this.label_Zile.Name = "label_Zile";
            this.label_Zile.Size = new System.Drawing.Size(24, 13);
            this.label_Zile.TabIndex = 5;
            this.label_Zile.Text = "Zile";
            // 
            // label_An
            // 
            this.label_An.AutoSize = true;
            this.label_An.Location = new System.Drawing.Point(448, 45);
            this.label_An.Name = "label_An";
            this.label_An.Size = new System.Drawing.Size(20, 13);
            this.label_An.TabIndex = 6;
            this.label_An.Text = "An";
            // 
            // comboBox_An
            // 
            this.comboBox_An.FormattingEnabled = true;
            this.comboBox_An.Location = new System.Drawing.Point(451, 101);
            this.comboBox_An.Name = "comboBox_An";
            this.comboBox_An.Size = new System.Drawing.Size(121, 21);
            this.comboBox_An.TabIndex = 7;
            // 
            // label_CNP
            // 
            this.label_CNP.AutoSize = true;
            this.label_CNP.Location = new System.Drawing.Point(12, 243);
            this.label_CNP.Name = "label_CNP";
            this.label_CNP.Size = new System.Drawing.Size(29, 13);
            this.label_CNP.TabIndex = 8;
            this.label_CNP.Text = "CNP";
            // 
            // label_CNP_Result
            // 
            this.label_CNP_Result.AutoSize = true;
            this.label_CNP_Result.Location = new System.Drawing.Point(12, 287);
            this.label_CNP_Result.Name = "label_CNP_Result";
            this.label_CNP_Result.Size = new System.Drawing.Size(62, 13);
            this.label_CNP_Result.TabIndex = 9;
            this.label_CNP_Result.Text = "CNP Result";
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(496, 276);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(75, 23);
            this.button_Clear.TabIndex = 10;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // CNPForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 366);
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
    }
}

