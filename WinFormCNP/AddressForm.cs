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
    public partial class AddressForm : Form
    {
        private User _user;


        public AddressForm(User user)
        {
            InitializeComponent();
            _user = user;
            Populate();
        }


        private void Populate()
        {
            label_nume_prenume.Text = $"{_user.Person.Nume}, {_user.Person.Prenume}";
        }
        

    }
}
