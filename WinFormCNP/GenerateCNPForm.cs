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
    public partial class GenerateCNPForm : Form
    {
        public GenerateCNPForm()
        {
            InitializeComponent();
        }

        private void CNPForm_Load(object sender, EventArgs e)
        {
            ClearLabels();

            comboBox_Sex.Items.Add("Masculin");
            comboBox_Sex.Items.Add("Feminin");

            comboBox_Luni.DataSource = Enum.GetValues(typeof(CommonCNP.Enums.Luni));
            comboBox_Judete.DataSource = Enum.GetValues(typeof(CommonCNP.Enums.Judete));

            for (int i = 1900; i <= DateTime.Now.Year; i++)
            {
                comboBox_An.Items.Add(i);
            }
            comboBox_An.SelectedIndex = 0;
            comboBox_Sex.SelectedIndex = 0;
            comboBox_Zile.SelectedIndex = 0;
        }      

        public string GetCNP(string SEX, string AN, string LUNA, string ZI, string JUDET, string NNN, string CC)
        {
            return $"{SEX}{AN}{LUNA}{ZI}{JUDET}{NNN}{CC}";
        }

        private void comboBox_Luni_SelectedValueChanged(object sender, EventArgs e)
        {
            var zi_selectata = comboBox_Zile.SelectedIndex + 1;
            var zile_luna_selectata = CommonCNP.Utilities.Zile(comboBox_Luni.Text);

            comboBox_Zile.Items.Clear();

            for (int i = 1; i <= zile_luna_selectata; i++)
            {
                comboBox_Zile.Items.Add(i);
            }

            if (zi_selectata > zile_luna_selectata)
            {
                comboBox_Zile.SelectedIndex = 0;
            }
        }

        private void ClearComboBox()
        {
            comboBox_An.Text = string.Empty;
            comboBox_Judete.Text = string.Empty;
            comboBox_Luni.Text = string.Empty;
            comboBox_Zile.Text = string.Empty;
            comboBox_Sex.Text = string.Empty;
        }

        private void ClearLabels()
        {
            label_Verifica_CNP.Text = string.Empty;
        }

        #region ComboBox
        private void comboBox_Judete_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBox_Luni_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void comboBox_Zile_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBox_An_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBox_Sex_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        #endregion

        private void textBox_VerificaCNP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button_Generate_CNP_Click(object sender, EventArgs e)
        {
            var Om = new CommonCNP.CNP
            {
                SEX = CommonCNP.Utilities.GetSex(comboBox_Sex.Text, comboBox_An.Text),
                AN = CommonCNP.Utilities.GetYear(comboBox_An.Text),
                LUNA = CommonCNP.Utilities.GetMonth(comboBox_Luni.Text),
                ZI = CommonCNP.Utilities.GetZi(comboBox_Zile.Text),
                JUDET = CommonCNP.Utilities.GetJudet(comboBox_Judete.Text),
                NNN = CommonCNP.Utilities.GetNNN(),
            };
            Om.CC = CommonCNP.Utilities.GetCC(Om.SEX,Om.AN,Om.LUNA,Om.ZI,Om.JUDET,Om.NNN);

            textBox_CNP_Result.Text = GetCNP(Om.SEX, Om.AN, Om.LUNA, Om.ZI, Om.JUDET, Om.NNN, Om.CC);
        }

        private void button_Verifica_Click(object sender, EventArgs e)
        {
            if(CommonCNP.CNP.VerificaCNP(textBox_VerificaCNP.Text))
            {
                label_Verifica_CNP.Text = "CNP valid";
            }
            else
            {
                label_Verifica_CNP.Text = "CNP gresit";
            }
        }
    }
}