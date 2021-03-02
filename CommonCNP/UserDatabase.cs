using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;


namespace CommonCNP
{
    public class UserDatabase
    {
        private static readonly UserDatabase _instance = new UserDatabase();
        private List<User> _userDatabase = new List<User>();
        private UserDatabase()
        {
            LoadDatabase();
        }

        public static UserDatabase GetUserData()
        {
            return _instance;
        }
        private void LoadDatabase()
        {
            var x = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            var path = $@"{x}\DataBase\BIO.json";

            using (StreamReader sr = new StreamReader(path))
            {
                string y = sr.ReadToEnd();

                var userList = new List<User>();
                userList = JsonConvert.DeserializeObject<List<User>>(y);
            }
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
    }
}