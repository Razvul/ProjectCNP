using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommonCNP;

namespace WinFormCNP
{
    public partial class Address : Form
    {
        private User _user;

        public Address(User user)
        {
            InitializeComponent();
            _user = user;
        }

        private void Address_Load(object sender, EventArgs e)
        {
            ClearLabels();
            Populate();

            button_Salveaza.Enabled = false;

            textBox_Nume.Enabled = false;
            textBox_Prenume.Enabled = false;
            textBox_Sex.Enabled = false;
            textBox_Oras.Enabled = false;
            textBox_Strada.Enabled = false;
            textBox_Numar.Enabled = false;
            textBox_Bloc.Enabled = false;
            textBox_Scara.Enabled = false;
            textBox_Etaj.Enabled = false;
            textBox_Apartament.Enabled = false;
            textBox_Judet.Enabled = false;
            textBox_CodPostal.Enabled = false;
        }

        private void button_Editeaza_Click(object sender, EventArgs e)
        {
            button_Salveaza.Enabled = true;
            button_Editeaza.Enabled = false;

            textBox_Nume.Enabled = true;
            textBox_Prenume.Enabled = true;
            textBox_Sex.Enabled = true;
            textBox_Oras.Enabled = true;
            textBox_Strada.Enabled = true;
            textBox_Numar.Enabled = true;
            textBox_Bloc.Enabled = true;
            textBox_Scara.Enabled = true;
            textBox_Etaj.Enabled = true;
            textBox_Apartament.Enabled = true;
            textBox_Judet.Enabled = true;
            textBox_CodPostal.Enabled = true;
        }

        private void button_Salveaza_Click(object sender, EventArgs e)
        {
            button_Editeaza.Enabled = true;
            button_Salveaza.Enabled = false;

            textBox_Nume.Enabled = false;
            textBox_Prenume.Enabled = false;
            textBox_Sex.Enabled = false;
            textBox_Oras.Enabled = false;
            textBox_Strada.Enabled = false;
            textBox_Numar.Enabled = false;
            textBox_Bloc.Enabled = false;
            textBox_Scara.Enabled = false;
            textBox_Etaj.Enabled = false;
            textBox_Apartament.Enabled = false;
            textBox_Judet.Enabled = false;
            textBox_CodPostal.Enabled = false;
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        

        private void Populate()
        {
            textBox_Nume.Text = $"{_user.Person.Nume}";
            textBox_Prenume.Text = $"{_user.Person.Prenume}";
            textBox_Sex.Text = $"{_user.Person.Sex}";
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
        
        private void Clear()
        {
            ClearLabels();
            ClearTextbox();
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

        #region TextBox

        private void textBox_Nume_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textBox_Prenume_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textBox_Sex_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textBox_Oras_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textBox_Strada_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textBox_Numar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textBox_Bloc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textBox_Scara_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textBox_Etaj_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textBox_Apartament_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textBox_Judet_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textBox_CodPostal_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        #endregion

        
    }
}