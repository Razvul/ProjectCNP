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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //comboBox1.Items.Add("Botosani");
            //comboBox1.Items.Add("Iasi");
            //comboBox1.Items.Add("Brasov");
            //comboBox1.Items.Add("Bacau");
            //comboBox1.Items.RemoveAt(3);

            comboBox1.DataSource = Enum.GetValues(typeof(Judete));
        }
        enum Judete
        {
            Alba = 1, Arad, Arges, Bacau, Bihor, Bistrita, Botosani, Brasov, Braila, Buzau, Caras, Cluj, Constanta, Covasna, Dambovita, Dolj, Galati, Gorj,
            Harghita, Hunedoara, Ialomita, Iasi, Ilfov, Maramures, Mehedinti, Mures, Neamt, Olt, Prahova, SatuMare, Salaj, Sibiu, Suceava, Teleorman, Timis,
            Tulcea, Vaslui, Valcea, Vrancea, Bucuresti, Bucuresti1, Bucuresti2, Bucuresti3, Bucuresti4, Bucuresti5, Bucuresti6, Calarasi, Giurgiu
        }
    }
}