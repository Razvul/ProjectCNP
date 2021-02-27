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
    public partial class AddressForm : Form
    {
        private User _user;

        public AddressForm(User user)
        {
            InitializeComponent();
            _user = user;
        }

        private void Address_Load(object sender, EventArgs e)
        {
            Populate();
            button_Salveaza.Enabled = false;
            TextBoxEnabled(false);
        }

        private void button_Editeaza_Click(object sender, EventArgs e)
        {
            button_Salveaza.Enabled = true;
            button_Editeaza.Enabled = false;

            TextBoxEnabled(true);
        }

        private void button_Salveaza_Click(object sender, EventArgs e)
        {
            var x = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            var path = $@"{x}\DataBase\BIO1.json";

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

            var text = JsonConvert.SerializeObject(_user);
            
            File.WriteAllText(path, text);

            button_Editeaza.Enabled = true;
            button_Salveaza.Enabled = false;

            TextBoxEnabled(false);
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

        private void TextBoxEnabled(bool enabled)
        {
            textBox_Nume.Enabled = enabled;
            textBox_Prenume.Enabled = enabled;
            textBox_Sex.Enabled = enabled;
            textBox_CNP.Enabled = enabled;
            textBox_Oras.Enabled = enabled;
            textBox_Strada.Enabled = enabled;
            textBox_Numar.Enabled = enabled;
            textBox_Bloc.Enabled = enabled;
            textBox_Scara.Enabled = enabled;
            textBox_Etaj.Enabled = enabled;
            textBox_Apartament.Enabled = enabled;
            textBox_Judet.Enabled = enabled;
            textBox_CodPostal.Enabled = enabled;
        }

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

        private void textBox_Sex_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
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