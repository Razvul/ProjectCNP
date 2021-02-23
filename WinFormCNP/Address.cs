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
            ClearLabels();
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
            var path = $@"{x}\DataBase\Razvan.txt";

            string[] text =
            {
                textBox_Nume.Text,
                textBox_Prenume.Text,
                textBox_Sex.Text,
                textBox_CNP.Text,
                textBox_Oras.Text,
                textBox_Strada.Text,
                textBox_Numar.Text,
                textBox_Bloc.Text,
                textBox_Scara.Text,
                textBox_Etaj.Text,
                textBox_Apartament.Text,
                textBox_Judet.Text,
                textBox_CodPostal.Text
            };
            File.WriteAllLines(path, text);

            button_Editeaza.Enabled = true;
            button_Salveaza.Enabled = false;

            TextBoxEnabled(false);
        }

        private void Populate()
        {
            textBox_Nume.Text = $"{_user.Person.Nume}";
            textBox_Prenume.Text = $"{_user.Person.Prenume}";
            textBox_Sex.Text = $"{_user.Person.Sex}";
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

        private void ClearLabels()
        {
            label_Nume_Result.Text = string.Empty;
            label_Prenume_Result.Text = string.Empty;
            label_Sex_Result.Text = string.Empty;
            label_Oras_Result.Text = string.Empty;
            label_Strada_Result.Text = string.Empty;
            label_Numar_Result.Text = string.Empty;
            label_Bloc_Result.Text = string.Empty;
            label_Scara_Result.Text = string.Empty;
            label_Etaj_Result.Text = string.Empty;
            label_Apartament_Result.Text = string.Empty;
            label_Judet_Result.Text = string.Empty;
            label_Cod_Postal_Result.Text = string.Empty;
        }

        private void ClearTextbox()
        {
            textBox_Nume.Text = string.Empty;
            textBox_Prenume.Text = string.Empty;
            textBox_Sex.Text = string.Empty;
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
    }
}