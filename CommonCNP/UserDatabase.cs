using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace CommonCNP
{
    public class UserDatabase
    {
        private static readonly UserDatabase _instance = new UserDatabase();
        private List<User> _userDatabase = new List<User>();
        private UserDatabase()
        {
            LoadDatabase(_userDatabase);
        }

        public static UserDatabase GetUserData()
        {
            return _instance;
        }

        private void AddUser()
        {

        }

        private void DeleteUser()
        {

        }

        private void UpdateUser()
        {

        }

        private void GetUser()
        {

        }

        private void GetUserList()
        {

        }

        private void LoadDatabase(List<User> users)
        {
            var x = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            var path = $@"{x}\DataBase\BIO.json";


        }
    }
}