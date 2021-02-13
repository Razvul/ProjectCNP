
namespace WinFormCNP
{
    partial class GeneralForm
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
            this.button_CNP = new System.Windows.Forms.Button();
            this.button_Name = new System.Windows.Forms.Button();
            this.button_Adresa = new System.Windows.Forms.Button();
            this.checkedListBox_users = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // button_CNP
            // 
            this.button_CNP.BackColor = System.Drawing.SystemColors.Highlight;
            this.button_CNP.Location = new System.Drawing.Point(49, 65);
            this.button_CNP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_CNP.Name = "button_CNP";
            this.button_CNP.Size = new System.Drawing.Size(100, 28);
            this.button_CNP.TabIndex = 0;
            this.button_CNP.Text = "CNP";
            this.button_CNP.UseVisualStyleBackColor = false;
            this.button_CNP.Click += new System.EventHandler(this.button_CNP_Click);
            // 
            // button_Name
            // 
            this.button_Name.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_Name.Location = new System.Drawing.Point(183, 65);
            this.button_Name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Name.Name = "button_Name";
            this.button_Name.Size = new System.Drawing.Size(100, 28);
            this.button_Name.TabIndex = 1;
            this.button_Name.Text = "Name";
            this.button_Name.UseVisualStyleBackColor = false;
            this.button_Name.Click += new System.EventHandler(this.button_Name_Click);
            // 
            // button_Adresa
            // 
            this.button_Adresa.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button_Adresa.Location = new System.Drawing.Point(308, 65);
            this.button_Adresa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Adresa.Name = "button_Adresa";
            this.button_Adresa.Size = new System.Drawing.Size(100, 28);
            this.button_Adresa.TabIndex = 2;
            this.button_Adresa.Text = "Adresa";
            this.button_Adresa.UseVisualStyleBackColor = true;
            this.button_Adresa.Click += new System.EventHandler(this.button_Adresa_Click);
            // 
            // checkedListBox_users
            // 
            this.checkedListBox_users.FormattingEnabled = true;
            this.checkedListBox_users.Location = new System.Drawing.Point(496, 108);
            this.checkedListBox_users.Name = "checkedListBox_users";
            this.checkedListBox_users.Size = new System.Drawing.Size(210, 191);
            this.checkedListBox_users.TabIndex = 4;
            // 
            // GeneralForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 357);
            this.Controls.Add(this.checkedListBox_users);
            this.Controls.Add(this.button_Adresa);
            this.Controls.Add(this.button_Name);
            this.Controls.Add(this.button_CNP);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GeneralForm";
            this.Text = "GeneralForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_CNP;
        private System.Windows.Forms.Button button_Name;
        private System.Windows.Forms.Button button_Adresa;
        private System.Windows.Forms.CheckedListBox checkedListBox_users;
    }
}