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
    /// Interaction logic for UserDetails.xaml
    /// </summary>
    public partial class UserDetails : Window
    {
        private readonly User _user;
        private readonly UserDatabase _userDatabase = UserDatabase.GetInstance();
        private readonly bool _isNewUser = false;

        public UserDetails(User user)
        {
            InitializeComponent();
            _user = user;
            Button_Add.Visibility = Visibility.Hidden;
        }

        public UserDetails()
        {
            _isNewUser = true;
            InitializeComponent();
            Button_Delete.Visibility = Visibility.Hidden;
            Button_Update.Visibility = Visibility.Hidden;
        }
    }
}
