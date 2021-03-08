using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommonCNP;
using Newtonsoft.Json;

namespace WinFormCNP
{
    public partial class UserDetails : Form
    {
        private User _user;
        private UserDatabase _userDatabase = UserDatabase.GetInstance();
        private bool _isNewUser = false;

        public UserDetails(User user)
        {
            InitializeComponent();
            _user = user;
            button_AddUser.Enabled = false;
        }

        public UserDetails()
        {
            _isNewUser = true;
            InitializeComponent();
            button_DeleteUser.Enabled = false;
            button_UpdateUser.Enabled = false;
        }

        private void Address_Load(object sender, EventArgs e)
        {
            if(_isNewUser)
            {
                PopulateNewUser();
            }
            var user = new User()
            {
                Id = Utilities.GetNewId().ToString(),
                Person = new Person(),
                Address = new AddressClass()
            };
            Populate();
            textBox_ID.Enabled = false;
        }

        private void Populate()
        {
            comboBox_Sex.DataSource = Enum.GetValues(typeof(Enums.Sex));

            if (_user.Person.Sex == Enums.Sex.Masculin)
            {
                comboBox_Sex.SelectedIndex = 0;
            }
            else
            {
                comboBox_Sex.SelectedIndex = 1;
            }

            textBox_ID.Text = $"{_user.Id}";
            textBox_Nume.Text = $"{_user.Person.Nume}";
            textBox_Prenume.Text = $"{_user.Person.Prenume}";
            textBox_CNP.Text = $"{_user.Person.CNP}";
            textBox_Oras.Text = $"{_user.Address.Oras}";
            textBox_Strada.Text = $"{_user.Address.Strada}";
            textBox_Numar.Text = $"{_user.Address.Numar}";
            textBox_Bloc.Text = $"{_user.Address.Bloc}";
            textBox_Scara.Text = $"{_user.Address.Scara}";
            textBox_Etaj.Text = $"{_user.Address.Etaj}";
            textBox_Apartament.Text = $"{_user.Address.Apartament}";
            textBox_Judet.Text = $"{_user.Address.Judet}";
            textBox_CodPostal.Text = $"{_user.Address.CodPostal}";
        }

        private void PopulateNewUser()
        {
            comboBox_Sex.DataSource = Enums.Sex.Masculin;
            //comboBox_Sex.DataSource = Enum.GetValues(typeof(Enums.Sex));

            //if (_user.Person.Sex == Enums.Sex.Masculin)
            //{
            //    comboBox_Sex.SelectedIndex = 0;
            //}
            //else
            //{
            //    comboBox_Sex.SelectedIndex = 1;
            //}

            textBox_ID.Text = $"{_user.Id}";
            textBox_Nume.Text = string.Empty;
            textBox_Prenume.Text = string.Empty;
            textBox_CNP.Text = string.Empty;
            textBox_Oras.Text = string.Empty;
            textBox_Strada.Text = string.Empty;
            textBox_Numar.Text = string.Empty;
            textBox_Bloc.Text = string.Empty;
            textBox_Scara.Text = string.Empty;
            textBox_Etaj.Text = string.Empty;
            textBox_Apartament.Text = string.Empty;
            textBox_Judet.Text = string.Empty;
            textBox_CodPostal.Text = string.Empty;
        }
        #region Buttons
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

        private void button_UpdateUser_Click(object sender, EventArgs e)
        {
            _user.Person.Nume = textBox_Nume.Text;
            _user.Person.Prenume = textBox_Prenume.Text;
            _user.Person.Sex = comboBox_Sex.SelectedIndex == 0 ? Enums.Sex.Masculin : Enums.Sex.Feminin;
            _user.Person.CNP = long.Parse(textBox_CNP.Text);
            _user.Address.Oras = textBox_Oras.Text;
            _user.Address.Strada = textBox_Strada.Text;
            _user.Address.Numar = int.Parse(textBox_Numar.Text);
            _user.Address.Bloc = textBox_Bloc.Text;
            _user.Address.Scara = textBox_Scara.Text;
            _user.Address.Etaj = int.Parse(textBox_Etaj.Text);
            _user.Address.Apartament = int.Parse(textBox_Apartament.Text);
            _user.Address.Judet = textBox_Judet.Text;
            _user.Address.CodPostal = int.Parse(textBox_CodPostal.Text);

            _userDatabase.UpdateUser(_user);
            _userDatabase.SaveDatabase();

            button_AddUser.Enabled = true;
            button_UpdateUser.Enabled = false;
            MessageBox.Show("Utilizatorul a fost salvat cu succes!");
        }

        private void button_DeleteUser_Click(object sender, EventArgs e)
        {
            try
            {
                _userDatabase.DeleteUser(_user.Id);
                _userDatabase.SaveDatabase();
                MessageBox.Show("Utilizatorul a fost sters cu succes!");
            }
            catch
            {
                MessageBox.Show("Utilizatorul nu a fost sters!");
            }
        }
        #endregion

        #region Textbox
        private void textBox_Nume_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
            }
            //e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void textBox_Prenume_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
            }
            //e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void comboBox_Sex_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textBox_CNP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }// && (e.KeyChar != '.')

        private void textBox_Oras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
            }
            //e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void textBox_Strada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
            }
            //e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
        private void textBox_Numar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_Etaj_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_Apartament_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_CodPostal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_Judet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
            }
            //e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
        #endregion
    }
}