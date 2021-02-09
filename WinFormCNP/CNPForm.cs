﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormCNP
{
    public partial class CNPForm : Form
    {
        public CNPForm()
        {
            InitializeComponent();

            comboBox_Luni.DataSource = Enum.GetValues(typeof(Luni));
            comboBox_Judete.DataSource = Enum.GetValues(typeof(Judete));
        }

        private void CNPForm_Load(object sender, EventArgs e)
        {
            ClearLabels();

            for (int i = 1900; i <= DateTime.Now.Year; i++)
            {
                comboBox_An.Items.Add(i);
            }
        }

        int[] zi = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31 };

        enum Saptamana
        {
            Luni = 1, Marti, Miercuri, Joi, Vineri, Sambata, Duminica
        }

        enum Luni
        {
            Ianuarie = 1, Februarie, Martie, Aprilie, Mai, Iunie, Iulie, August, Septembrie, Octombrie, Noiembrie, Decembrie
        }

        enum Judete
        {
            Alba = 1, Arad, Arges, Bacau, Bihor, Bistrita, Botosani, Brasov, Braila, Buzau, Caras, Cluj, Constanta, Covasna, Dambovita, Dolj, Galati, Gorj,
            Harghita, Hunedoara, Ialomita, Iasi, Ilfov, Maramures, Mehedinti, Mures, Neamt, Olt, Prahova, SatuMare, Salaj, Sibiu, Suceava, Teleorman, Timis,
            Tulcea, Vaslui, Valcea, Vrancea, Bucuresti, Bucuresti1, Bucuresti2, Bucuresti3, Bucuresti4, Bucuresti5, Bucuresti6, Calarasi, Giurgiu
        }

        private void comboBox_Luni_SelectedValueChanged(object sender, EventArgs e)
        {
            comboBox_Zile.Items.Clear();

            for (int i = 1; i <= CommonCNP.Utilities.Zile(comboBox_Luni.Text); i++)
            {
                //if()
                comboBox_Zile.Items.Add(i);
            }
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            ClearComboBox();
            ClearLabels();
        }

        private void ClearComboBox()
        {
            comboBox_An.Text = string.Empty;
            comboBox_Judete.Text = string.Empty;
            comboBox_Luni.Text = string.Empty;
            comboBox_Zile.Text = string.Empty;
        }

        private void ClearLabels()
        {
            label_CNP_Result.Text = string.Empty;
        }
    }
}