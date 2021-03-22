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

        private void Buton_CNP_Click(object sender, RoutedEventArgs e)
        {
            var x = new GenerateCNP();
            x.Show();
        }

        private void Buton_Detalii_Click(object sender, RoutedEventArgs e)
        {
            //var x = UserDetails();
            //x.Show();
        }
    }
}
