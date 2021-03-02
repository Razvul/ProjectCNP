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
        private void button_CNP_Click(object sender, EventArgs e)
        {
            var x = new GenerateCNPForm();
            x.Show();
        }

        private void button_Detalii_Click(object sender, EventArgs e)
        {
            var SelectedUser = (User)listBox_Users.SelectedItem;

            var x = new AddressForm(SelectedUser);
            x.Show();
        }

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