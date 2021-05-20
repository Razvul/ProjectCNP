using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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
using WpfCNP.Annotations;

namespace WpfCNP
{
    /// <summary>
    /// Interaction logic for UserDetails.xaml
    /// </summary>
    public partial class UserDetails : Window, INotifyPropertyChanged
    {
        private User _user;
        private readonly UserDatabase _userDatabase = UserDatabase.GetInstance();
        private readonly bool _isNewUser = false;

        public UserDetails(User user)
        {
            InitializeComponent();
            _user = user;
            Button_Add.Visibility = Visibility.Hidden;
            this.DataContext = DataContext;
        }

        public UserDetails()
        {
            _isNewUser = true;
            InitializeComponent();
            Button_Delete.Visibility = Visibility.Hidden;
            Button_Update.Visibility = Visibility.Hidden;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (_isNewUser)
            {
                _user = new User()
                {
                    Id = Utilities.GetNewId().ToString(),
                    Person = new Person(),
                    Address = new AddressClass()
                };

                PopulateNewUser();
            }
            else
            {
                Populate();
            }
            TextBox_ID.IsEnabled = false;
        }

        #region Butoane
        private void Button_Add_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBox_Nume.Text) && !string.IsNullOrEmpty(TextBox_Prenume.Text))
            {
                var checkUser = _userDatabase.GetUser(_user.Id);

                if (checkUser == null)
                {
                    GetUserFromForm();
                    _userDatabase.AddUser(_user);
                    _userDatabase.SaveDatabase();
                    MessageBox.Show("Utilizatorul a fost adaugat cu succes!");
                    this.Close();
                    return;
                }
                MessageBox.Show("Utilizatorul exista in database");
            }
            else
            {
                MessageBox.Show("N-ai completat spatiile pentru Nume si Prenume!");
                return;
            }
        }

        private void Button_Update_Click(object sender, RoutedEventArgs e)
        {
            GetUserFromForm();

            _userDatabase.UpdateUser(_user);
            _userDatabase.SaveDatabase();

            Button_Add.IsEnabled = true;
            MessageBox.Show("Utilizatorul a fost salvat cu succes!");
        }

        private void Button_Delete_Click(object sender, RoutedEventArgs e)
        {
            var dialogresult = MessageBox.Show($"Sigur vrei sa stergi {_user.DisplayValue}", "Stergere utilizator", MessageBoxButton.YesNo, MessageBoxImage.Exclamation);

            if (dialogresult == MessageBoxResult.Yes)
            {
                try
                {
                    _userDatabase.DeleteUser(_user.Id);
                    _userDatabase.SaveDatabase();
                    MessageBox.Show("Utilizatorul a fost sters cu succes!");
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Utilizatorul nu a fost sters!");
                }
            }
            else
            {
                return;
            }
        }

        #endregion

        #region Functii
        private void Populate()
        {
            ComboBox_Sex.ItemsSource = Enum.GetValues(typeof(Enums.Sex));

            if (_user.Person.Sex == Enums.Sex.Masculin)
            {
                ComboBox_Sex.SelectedIndex = 0;
            }
            else
            {
                ComboBox_Sex.SelectedIndex = 1;
            }

            TextBox_ID.Text = $"{_user.Id}";
            TextBox_Nume.Text = $"{_user.Person.Nume}";
            TextBox_Prenume.Text = $"{_user.Person.Prenume}";
            TextBox_CNP.Text = $"{_user.Person.CNP}" == "0" ? "" : $"{_user.Person.CNP}";
            TextBox_Oras.Text = $"{_user.Address.Oras}";
            TextBox_Strada.Text = $"{_user.Address.Strada}";
            TextBox_Numar.Text = $"{_user.Address.Numar}" == "0" ? "" : $"{_user.Address.Numar}";
            TextBox_Bloc.Text = $"{_user.Address.Bloc}";
            TextBox_Scara.Text = $"{_user.Address.Scara}";
            TextBox_Etaj.Text = $"{_user.Address.Etaj}" == "0" ? "" : $"{_user.Address.Etaj}";
            TextBox_Apartament.Text = $"{_user.Address.Apartament}" == "0" ? "" : $"{_user.Address.Apartament}";
            TextBox_Judet.Text = $"{_user.Address.Judet}";
            TextBox_CodPostal.Text = $"{_user.Address.CodPostal}" == "0" ? "" : $"{_user.Address.CodPostal}";
        }

        private void PopulateNewUser()
        {
            ComboBox_Sex.ItemsSource = Enum.GetValues(typeof(Enums.Sex));
            ComboBox_Sex.SelectedIndex = 0;

            TextBox_ID.Text = $"{_user.Id}";
            TextBox_Nume.Text = string.Empty;
            TextBox_Prenume.Text = string.Empty;
            TextBox_CNP.Text = string.Empty;
            TextBox_Oras.Text = string.Empty;
            TextBox_Strada.Text = string.Empty;
            TextBox_Numar.Text = string.Empty;
            TextBox_Bloc.Text = string.Empty;
            TextBox_Scara.Text = string.Empty;
            TextBox_Etaj.Text = string.Empty;
            TextBox_Apartament.Text = string.Empty;
            TextBox_Judet.Text = string.Empty;
            TextBox_CodPostal.Text = string.Empty;
        }

        private void GetUserFromForm()
        {
            _user.Person.Nume = TextBox_Nume.Text;
            _user.Person.Prenume = TextBox_Prenume.Text;
            _user.Person.Sex = ComboBox_Sex.SelectedIndex == 0 ? Enums.Sex.Masculin : Enums.Sex.Feminin;
            _user.Person.CNP = long.TryParse(TextBox_CNP.Text, out long rezultat) ? rezultat : 0;
            _user.Address.Oras = TextBox_Oras.Text;
            _user.Address.Strada = TextBox_Strada.Text;
            _user.Address.Numar = int.TryParse(TextBox_Numar.Text, out int resultat) ? resultat : 0;
            _user.Address.Bloc = TextBox_Bloc.Text;
            _user.Address.Scara = TextBox_Scara.Text;
            _user.Address.Etaj = int.TryParse(TextBox_Etaj.Text, out int result) ? result : 0;
            _user.Address.Apartament = int.TryParse(TextBox_Apartament.Text, out int res) ? res : 0;
            _user.Address.Judet = TextBox_Judet.Text;
            _user.Address.CodPostal = int.TryParse(TextBox_CodPostal.Text, out int r) ? r : 0;

            _user.DisplayValue = $"{_user.Person.Nume} {_user.Person.Prenume}";
        }
        #endregion


        public int Id { get; set; } = 23;


        public ObservableCollection<string> GenderSource { get; set; } =
            new ObservableCollection<string>()
            {
                "Masculin",
                "Feminin",
            };


        public ObservableCollection<Enums.Sex> GenderSource1 { get; set; } =
            new ObservableCollection<Enums.Sex>()
            {
                Enums.Sex.Masculin,
                Enums.Sex.Feminin,
            };

        #region INotifyPropertyChanged implementation

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}