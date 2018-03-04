using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using webapp3.Data.Entities;

namespace webapp3.Data
{
    public class InMemoryDatabase
    {
        public static List<User> Users = new List<User>();
        public static int id = 0;

        public static int NextId()
        {
            return id++;
        }

        public static void DeleteUser(int id)
        {
            var user = Users.Find(u => u.Id == id);
            Users.Remove(user);
        }
    }
}