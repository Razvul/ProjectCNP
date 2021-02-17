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
            Populate();
        }

        private void Address_Load(object sender, EventArgs e)
        {
            ClearLabels();
        }
        private void button_Clear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Populate()
        {
            label_Nume_Result.Text = $"{_user.Person.Nume}";
            label_Prenume_Result.Text = $"{_user.Person.Prenume}";
            label_Sex_Result.Text = $"{_user.Person.Sex}";
            label_Oras_Result.Text = $"{_user.Address.Oras}";
            label_Strada_Result.Text = $"{_user.Address.Strada}";
            label_Numar_Result.Text = $"{_user.Address.Numar}";
            label_Bloc_Result.Text = $"{_user.Address.Bloc}";
            label_Scara_Result.Text = $"{_user.Address.Scara}";
            label_Etaj_Result.Text = $"{_user.Address.Etaj}";
            label_Apartament_Result.Text = $"{_user.Address.Apartament}";
            label_Localitate_Result.Text = $"{_user.Address.Localitate}";
            label_Judet_Result.Text = $"{_user.Address.Judet}";
            label_Cod_Postal_Result.Text = $"{_user.Address.CodPostal}";
        }
        
        private void Clear()
        {
            ClearLabels();
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
            label_Localitate_Result.Text = string.Empty;
            label_Judet_Result.Text = string.Empty;
            label_Cod_Postal_Result.Text = string.Empty;
        }
    }
}