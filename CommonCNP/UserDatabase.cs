using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonCNP
{
    public class UserDatabase
    {
        private static readonly UserDatabase _instance = new UserDatabase();

        private UserDatabase()
        {

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
    }
}