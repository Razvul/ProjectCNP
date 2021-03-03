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
        private List<User> _userDatabase = new List<User>();
        
        #region Singleton
        private static readonly UserDatabase _instance = new UserDatabase();

        private UserDatabase()
        {
            LoadDatabase();
        }

        public static UserDatabase GetInstance()
        {
            return _instance;
        }
        #endregion

        private void LoadDatabase()
        {
            var x = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            var path = $@"{x}\DataBase\BIO.json";

            using (StreamReader sr = new StreamReader(path))
            {
                string y = sr.ReadToEnd();
                _userDatabase = JsonConvert.DeserializeObject<List<User>>(y);
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

        private User GetUser(string id)
        {
            return _userDatabase.SingleOrDefault(diha => diha.Id == id);
        }

        public List<User> GetUserList()
        {
            return _userDatabase;
        }
    }
}