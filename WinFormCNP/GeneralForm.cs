﻿using System;
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
            var x = new UserDetails(SelectedUser);
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

        private void button_AddUser_Click(object sender, EventArgs e)
        {
            var _user = new User();
            var checkUser = _userDatabase.GetUser(_user.Id);

            if (checkUser == null)
            {
                _userDatabase.AddUser(_user);
                _userDatabase.SaveDatabase();
                MessageBox.Show("Utilizatorul a fost adaugat cu succes!");
                return;
            }

            MessageBox.Show("Utilizatorul exista in database");
        }
    }
}