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
    public partial class GeneralForm : Form
    {
        public GeneralForm()
        {
            InitializeComponent();
        }

        private void button_CNP_Click(object sender, EventArgs e)
        {
            var x = new CNPForm();
            x.Show();
        }

        private void button_Name_Click(object sender, EventArgs e)
        {
            var x = new NameForm();
            x.Show();
        }

        private void button_Adresa_Click(object sender, EventArgs e)
        {
            var x = new AddressForm();
            x.Show();
        }
    }
}