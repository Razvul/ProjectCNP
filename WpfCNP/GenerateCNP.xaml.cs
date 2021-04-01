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
using System.Windows.Shapes;
using CommonCNP;

namespace WpfCNP
{
    /// <summary>
    /// Interaction logic for GenerateCNP.xaml
    /// </summary>
    public partial class GenerateCNP : Window
    {
        public GenerateCNP()
        {
            InitializeComponent();
            //this.DataContext = Enums;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ComboBox_Sex.ItemsSource = Enum.GetValues(typeof(Enums.Sex));
            ComboBox_Luni.ItemsSource = Enum.GetValues(typeof(Enums.Luni));
            ComboBox_Judete.ItemsSource = Enum.GetValues(typeof(Enums.Judete));

            for (int i = 1900; i <= DateTime.Now.Year; i++)
            {
                ComboBox_An.Items.Add(i);
            }
            ComboBox_Sex.SelectedIndex = 0;
            ComboBox_An.SelectedIndex = 0;
            ComboBox_Luni.SelectedIndex = 0;
            ComboBox_Zile.SelectedIndex = 0;
            ComboBox_Judete.SelectedIndex = 0;

            for (int i = 1; i <= Utilities.Zile(ComboBox_Luni.Text); i++)
            {
                ComboBox_Zile.Items.Add(i);
            }
        }

        private void ComboBox_Luni_DropDownClosed(object sender, EventArgs e)
        {
            var zi_selectata = ComboBox_Zile.SelectedIndex + 1;
            var zile_luna_selectata = Utilities.Zile(ComboBox_Luni.Text);

            ComboBox_Zile.Items.Clear();

            for (int i = 1; i <= zile_luna_selectata; i++)
            {
                ComboBox_Zile.Items.Add(i);
            }

            if (zi_selectata > zile_luna_selectata)
            {
                ComboBox_Zile.SelectedIndex = 0;
            }
            else
            {
                ComboBox_Zile.SelectedIndex = zi_selectata - 1;
            }
        }

        #region Butoane
        private void Button_Creaza_CNP_Click(object sender, RoutedEventArgs e)
        {
            var Om = new CNP
            {
                SEX = Utilities.GetSex(ComboBox_Sex.Text, ComboBox_An.Text),
                AN = Utilities.GetYear(ComboBox_An.Text),
                LUNA =Utilities.GetMonth(ComboBox_Luni.Text),
                ZI = Utilities.GetZi(ComboBox_Zile.Text),
                JUDET = Utilities.GetJudet(ComboBox_Judete.Text),
                NNN = Utilities.GetNNN(),
            };
            Om.CC = Utilities.GetCC(Om.SEX, Om.AN, Om.LUNA, Om.ZI, Om.JUDET, Om.NNN);

            TextBox_Creaza_CNP.Text = Utilities.GetCNP(Om.SEX, Om.AN, Om.LUNA, Om.ZI, Om.JUDET, Om.NNN, Om.CC);
        }
        private void Button_Verifica_CNP_Click(object sender, RoutedEventArgs e)
        {
            if (CommonCNP.CNP.VerificaCNP(TextBox_Verifica_CNP.Text))
            {
                Label_VerificaCNP.Content = "CNP valid";
            }
            else
            {
                Label_VerificaCNP.Content = "CNP gresit";
            }
        }
        #endregion

    }
}