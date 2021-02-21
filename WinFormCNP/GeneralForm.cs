using System;
using System.Collections;
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
            var x = new Name();
            x.Show();
        }

        private void button_Adresa_Click(object sender, EventArgs e)
        {
            var SelectedUser = (User)listBox_Users.SelectedItem;

            var x = new AddressForm(SelectedUser);
            x.Show();
        }

        List<User> ListUsers = new List<User>();

        private void GenerateMockData()
        {
            var user1 = new User
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
                    CodPostal = 475125
                }
            };

            User user2 = new User
            {
                Person = new Person
                {
                    Nume = "Zamfir",
                    Prenume = "Rodica",
                    Sex = Enums.Sex.Feminin,
                    CNP = 2610621120870
                },

                Address = new CommonCNP.Address
                {
                    Oras = "Cluj Napoca",
                    Strada = "Strada Mihai Eminescu",
                    Numar = 31,
                    Bloc = 9,
                    Etaj = 5,
                    Apartament = 16,
                    Judet = "Cluj",
                    CodPostal = 475120
                }
            };

            User user3 = new User
            {
                Person = new Person
                {
                    Nume = "Popescu",
                    Prenume = "Elena",
                    Sex = Enums.Sex.Masculin,
                    CNP = 5000114179137
                },

                Address = new CommonCNP.Address
                {
                    Oras = "Galati",
                    Strada = "Strada Stefan cel Mare",
                    Numar = 2,
                    Bloc = 15,
                    Etaj = 3,
                    Apartament = 7,
                    Judet = "Galati",
                    CodPostal = 475964
                }
            };


            ListUsers.Add(user1);
            ListUsers.Add(user2);
            ListUsers.Add(user3);

            foreach (var user in ListUsers)
            {
                user.DisplayValue = $"{user.Person.Nume} {user.Person.Prenume}";
            }
        }

        private void GetMockData()
        {
            // citeste fisierul salvat, pune datele intr-un array
            // creaza un user 
            // initializeaza user creat mai sus cu datele din array
        }

        private void PopulateListBox()
        {
            ArrayList authors = new ArrayList(); // declare arraylist

            foreach (var user in ListUsers)
            {
                //listBox_Users.Items.Add(user);
                authors.Add(user);  //filling arraylist
            }

            listBox_Users.DataSource = authors;  // adding the whole list in the listbox
            listBox_Users.DisplayMember = "DisplayValue";

            listBox_Users.SelectedItem = ListUsers[0];
        }
    }
}