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
            var path = $@"{x}\DataBase\ProjectCNP.json";

            using (StreamReader sr = new StreamReader(path))
            {
                string y = sr.ReadToEnd();
                _userDatabase = JsonConvert.DeserializeObject<List<User>>(y);
            }
        }

        public bool AddUser(User user)// sa returneze un boolean
        {
            try
            {
                _userDatabase.Add(user);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

            
        }

        public bool DeleteUser(string id)
        {
            try
            {
                var user = _userDatabase.SingleOrDefault(d => d.Id == id);
                if (user == null)
                {
                    return false;
                }

                _userDatabase.Remove(user);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool UpdateUser(User user)
        {
            try
            {
                var index = _userDatabase.FindIndex(x => x.Id == user.Id);

                if (index < 0)
                {
                    return false;
                }

                _userDatabase[index] = user;
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

            
        }

        public User GetUser(string id)
        {
            return _userDatabase.SingleOrDefault(diha => diha.Id == id);
        }

        public void SaveDatabase()
        {
            var x = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            var path = $@"{x}\DataBase\ProjectCNP.json";

            var text = JsonConvert.SerializeObject(_userDatabase);

            File.WriteAllText(path, text);
        }

        public List<User> GetUserList()
        {
            return _userDatabase;
        }
    }
}