using System;
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
            //comboBox1.Items.Add("Botosani");
            //comboBox1.Items.Add("Iasi");
            //comboBox1.Items.Add("Brasov");
            //comboBox1.Items.Add("Bacau");
            //comboBox1.Items.RemoveAt(3);

            //for (int i = 1; i <= Utilities.Zile(comboBox_Luni); i++)
            //{
            //    comboBox_Zile.Items.Add(i);
            //}

            comboBox_Luni.DataSource = Enum.GetValues(typeof(Luni));
            comboBox_Judete.DataSource = Enum.GetValues(typeof(Judete));
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
    }
}