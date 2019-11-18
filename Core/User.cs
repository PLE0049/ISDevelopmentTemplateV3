using Infrastructure;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Core
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Role { get; set; }

        public void Promote()
        {
            // TODO
        }
        
        public static User Get(int id)
        {
            var userTable = new UserTable();
            var data = userTable.Get(id);
            return Map(data);
        }

        public void Save()
        {
            if(Id == -1)
            {
                // INSERT
                return;
            }

            // UPDATE
        }

        public static IEnumerable<User> GetAll(int id)
        {
            throw new NotImplementedException();
        }

        private static User Map(DataTable data)
        {
            return new User();
        }
    }
}
