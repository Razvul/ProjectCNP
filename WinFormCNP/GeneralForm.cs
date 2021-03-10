using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommonCNP;
using System.IO;
using Newtonsoft.Json;

namespace WinFormCNP
{
    public partial class GeneralForm : Form
    {
        private UserDatabase _userDatabase = UserDatabase.GetInstance(); //chemat din UserDatabase

        public GeneralForm()
        {
            InitializeComponent();
            Populate();
        }

        #region Butoane
        private void button_CNP_Click(object sender, EventArgs e)
        {
            var x = new GenerateCNPForm();
            x.Show();
        }

        private void button_Detalii_Click(object sender, EventArgs e)
        {
            var SelectedUser = (User)listBox_Users.SelectedItem;
            var x = new UserDetails(SelectedUser);
            x.Show();
        }

        private void button_AddUser_Click(object sender, EventArgs e)
        {
            var x = new UserDetails();
            x.Show();
        }

        private void button_Cauta_Click(object sender, EventArgs e)
        {
            var ListaNume = _userDatabase.FindUser(textBox_Cauta.Text);

            if (ListaNume.Count == 0)
            {
                MessageBox.Show($"Nu s-a gasit niciun utilizatoru cu numele {textBox_Cauta.Text}");
            }
            else
            {
                listBox_Users.Items.Clear();
                foreach (var user in ListaNume)
                {
                    listBox_Users.Items.Add(user);
                    listBox_Users.DisplayMember = "DisplayValue";
                }
            }
        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            listBox_Users.Items.Clear();
            Populate();
        }
        #endregion

        private void Populate()
        {
            foreach (var user in _userDatabase.GetUserList())
            {
                listBox_Users.Items.Add(user);
            }

            listBox_Users.DisplayMember = "DisplayValue";
            listBox_Users.SelectedItem = listBox_Users.Items[0];
        }        
    }
}