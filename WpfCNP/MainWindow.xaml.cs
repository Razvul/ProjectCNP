using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CommonCNP;
using Newtonsoft.Json;

namespace WpfCNP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private UserDatabase _userDatabase = UserDatabase.GetInstance();


        public MainWindow()
        {
            InitializeComponent();
        }

        #region Butoane
        private void Buton_CNP_Click(object sender, RoutedEventArgs e)
        {
            var x = new GenerateCNP();
            x.Show();
        }

        private void Buton_Detalii_Click(object sender, RoutedEventArgs e)
        {
            var SelectedUser = (User)listBox_Users.SelectedItem;
            var x = new UserDetails(SelectedUser);
            x.Show();
        }

        private void Buton_AddUser_Click(object sender, RoutedEventArgs e)
        {
            var x = new UserDetails();
            x.Show();
        }

        private void Buton_Cauta_Click(object sender, RoutedEventArgs e)
        {
            var ListaNume = _userDatabase.FindUser(textBox_Cauta.Text);

            if (ListaNume.Count == 0)
            {
                MessageBox.Show($"Nu s-a gasit niciun utilizatoru cu numele {textBox_Cauta.Text}");
            }
            else
            {
                listBox_Users.Items.Clear();
                foreach (var user in ListaNume)
                {
                    listBox_Users.Items.Add(user);
                    listBox_Users.DisplayMemberPath = "DisplayValue";
                }
            }
        }

        private void Buton_Refresh_Click(object sender, RoutedEventArgs e)
        {
            listBox_Users.Items.Clear();
            //listBox_Users= true;
            Populate();
        }

        #endregion

        private void Populate()
        {
            foreach (var user in _userDatabase.GetUserList())
            {
                listBox_Users.Items.Add(user);
            }

            listBox_Users.DisplayMemberPath = "DisplayValue";
            listBox_Users.SelectedItem = listBox_Users.Items[0];
            //listBox_Users.Sorted = true;
        }
    }
}