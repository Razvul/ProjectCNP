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
    public partial class GeneralForm : Form
    {
        public GeneralForm()
        {
            InitializeComponent();
            GenerateMockData();
            PopulateListBox();
        }

        private void button_CNP_Click(object sender, EventArgs e)
        {
            var x = new GenerateCNP();
            x.Show();
        }

        private void button_Name_Click(object sender, EventArgs e)
        {
            var x = new NameForm();
            x.Show();
        }

        private void button_Adresa_Click(object sender, EventArgs e)
        {
            var usersCollection = checkedListBox_users.CheckedItems;

            foreach (var item in usersCollection)
            {

                var st = (User)item;
                var sto = 2;
            }


           


            var x = new Address(ListUsers.First());
            x.Show();
        }


        List<User> ListUsers = new List<User>();

        private void GenerateMockData()
        {

            User user1 = new User
            {
                Person = new Person
                {
                    Nume = "Basescu",
                    Prenume = "Traian",
                    Sex = Enums.Sex.Masculin,
                    CNP = 1751205075564
                },

                Address = new CommonCNP.Address
                {
                    Oras = "Botosani",
                    Strada = "Strada Mare",
                    Numar = 12,
                    Bloc = 34,
                    Etaj = 2,
                    Apartament = 4,
                    Judet = "Botosani",
                    CodPostal = 47512
                }
            };

            User user2 = new User
            {
                Person = new Person
                {
                    Nume = "Zamfir",
                    Prenume = "Rodica",
                    Sex = Enums.Sex.Feminin,
                    CNP = 1751205075564
                },

                Address = new CommonCNP.Address
                {
                    Oras = "Botosani",
                    Strada = "Strada Mare",
                    Numar = 31,
                    Bloc = 9,
                    Etaj = 4,
                    Apartament = 16,
                    Judet = "Bucuresti",
                    CodPostal = 475120
                }
            };

            User user3 = new User
            {
                Person = new Person
                {
                    Nume = "Popescu",
                    Prenume = "Elena",
                    Sex = Enums.Sex.Feminin,
                    CNP = 1751205075564
                },

                Address = new CommonCNP.Address
                {
                    Oras = "Botosani",
                    Strada = "Strada Mare",
                    Numar = 12,
                    Bloc = 34,
                    Etaj = 2,
                    Apartament = 4,
                    Judet = "Botosani",
                    CodPostal = 47512
                }
            };

            ListUsers.Add(user1);
            ListUsers.Add(user2);
            ListUsers.Add(user3);
        }

        private void PopulateListBox()
        {
            foreach (var user in ListUsers)
            {
                //var item = $"{user.Person.Nume}, {user.Person.Prenume}";
                checkedListBox_users.Items.Add(user);
            }
        }
    }
}