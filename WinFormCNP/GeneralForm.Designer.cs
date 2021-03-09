
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
            this.button_Detalii = new System.Windows.Forms.Button();
            this.listBox_Users = new System.Windows.Forms.ListBox();
            this.button_AddUser = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_Cauta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_CNP
            // 
            this.button_CNP.BackColor = System.Drawing.SystemColors.Highlight;
            this.button_CNP.Location = new System.Drawing.Point(75, 53);
            this.button_CNP.Name = "button_CNP";
            this.button_CNP.Size = new System.Drawing.Size(75, 23);
            this.button_CNP.TabIndex = 0;
            this.button_CNP.Text = "CNP";
            this.button_CNP.UseVisualStyleBackColor = false;
            this.button_CNP.Click += new System.EventHandler(this.button_CNP_Click);
            // 
            // button_Detalii
            // 
            this.button_Detalii.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button_Detalii.Location = new System.Drawing.Point(227, 53);
            this.button_Detalii.Name = "button_Detalii";
            this.button_Detalii.Size = new System.Drawing.Size(75, 23);
            this.button_Detalii.TabIndex = 2;
            this.button_Detalii.Text = "Detalii";
            this.button_Detalii.UseVisualStyleBackColor = true;
            this.button_Detalii.Click += new System.EventHandler(this.button_Detalii_Click);
            // 
            // listBox_Users
            // 
            this.listBox_Users.BackColor = System.Drawing.SystemColors.Desktop;
            this.listBox_Users.ForeColor = System.Drawing.SystemColors.Window;
            this.listBox_Users.FormattingEnabled = true;
            this.listBox_Users.Location = new System.Drawing.Point(387, 53);
            this.listBox_Users.Name = "listBox_Users";
            this.listBox_Users.Size = new System.Drawing.Size(120, 95);
            this.listBox_Users.TabIndex = 3;
            // 
            // button_AddUser
            // 
            this.button_AddUser.ForeColor = System.Drawing.SystemColors.GrayText;
            this.button_AddUser.Location = new System.Drawing.Point(227, 124);
            this.button_AddUser.Name = "button_AddUser";
            this.button_AddUser.Size = new System.Drawing.Size(75, 23);
            this.button_AddUser.TabIndex = 4;
            this.button_AddUser.Text = "AddUser";
            this.button_AddUser.UseVisualStyleBackColor = true;
            this.button_AddUser.Click += new System.EventHandler(this.button_AddUser_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(75, 182);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // button_Cauta
            // 
            this.button_Cauta.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button_Cauta.Location = new System.Drawing.Point(227, 182);
            this.button_Cauta.Name = "button_Cauta";
            this.button_Cauta.Size = new System.Drawing.Size(75, 23);
            this.button_Cauta.TabIndex = 6;
            this.button_Cauta.Text = "Cauta";
            this.button_Cauta.UseVisualStyleBackColor = true;
            // 
            // GeneralForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.button_Cauta);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_AddUser);
            this.Controls.Add(this.listBox_Users);
            this.Controls.Add(this.button_Detalii);
            this.Controls.Add(this.button_CNP);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MaximumSize = new System.Drawing.Size(850, 550);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "GeneralForm";
            this.Text = "GeneralForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_CNP;
        private System.Windows.Forms.Button button_Detalii;
        private System.Windows.Forms.ListBox listBox_Users;
        private System.Windows.Forms.Button button_AddUser;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_Cauta;
    }
}