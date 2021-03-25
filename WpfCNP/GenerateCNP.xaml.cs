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
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ComboBox_Sex.Items.Add("Masculin");
            ComboBox_Sex.Items.Add("Feminin");

            ComboBox_Luni.ItemsSource = Enum.GetValues(typeof(Luni));
            ComboBox_Judete.ItemsSource = Enum.GetValues(typeof(Judete));

            for (int i = 1900; i <= DateTime.Now.Year; i++)
            {
                ComboBox_An.Items.Add(i);
            }
            ComboBox_Sex.SelectedIndex = 0;
            ComboBox_An.SelectedIndex = 0;
            ComboBox_Luni.SelectedIndex = 0;
            ComboBox_Zile.SelectedIndex = 0;
            ComboBox_Judete.SelectedIndex = 0;

            for (int i = 1; i <= CommonCNP.Utilities.Zile(ComboBox_Luni.Text); i++)
            {
                ComboBox_Zile.Items.Add(i);
            }
        }

        enum Luni
        {
            Ianuarie, Februarie, Martie, Aprilie, Mai, Iunie, Iulie, August, Septembrie, Octombrie, Noiembrie, Decembrie
        }

        enum Judete
        {
            Alba = 1, Arad, Arges, Bacau, Bihor, Bistrita, Botosani, Brasov, Braila, Buzau, Caras, Cluj, Constanta, Covasna, Dambovita, Dolj, Galati, Gorj,
            Harghita, Hunedoara, Ialomita, Iasi, Ilfov, Maramures, Mehedinti, Mures, Neamt, Olt, Prahova, SatuMare, Salaj, Sibiu, Suceava, Teleorman, Timis,
            Tulcea, Vaslui, Valcea, Vrancea, Bucuresti, Bucuresti1, Bucuresti2, Bucuresti3, Bucuresti4, Bucuresti5, Bucuresti6, Calarasi, Giurgiu
        }

        private void ComboBox_Luni_DropDownClosed(object sender, EventArgs e)
        {
            var zi_selectata = ComboBox_Zile.SelectedIndex + 1;
            var zile_luna_selectata = CommonCNP.Utilities.Zile(ComboBox_Luni.Text);

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
            var Om = new CommonCNP.CNP
            {
                SEX = CommonCNP.Utilities.GetSex(ComboBox_Sex.Text, ComboBox_An.Text),
                AN = CommonCNP.Utilities.GetYear(ComboBox_An.Text),
                LUNA = CommonCNP.Utilities.GetMonth(ComboBox_Luni.Text),
                ZI = CommonCNP.Utilities.GetZi(ComboBox_Zile.Text),
                JUDET = CommonCNP.Utilities.GetJudet(ComboBox_Judete.Text),
                NNN = CommonCNP.Utilities.GetNNN(),
            };
            Om.CC = CommonCNP.Utilities.GetCC(Om.SEX, Om.AN, Om.LUNA, Om.ZI, Om.JUDET, Om.NNN);

            TextBox_Creaza_CNP.Text = CommonCNP.Utilities.GetCNP(Om.SEX, Om.AN, Om.LUNA, Om.ZI, Om.JUDET, Om.NNN, Om.CC);
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