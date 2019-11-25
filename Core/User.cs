using Infrastructure;
using Infrastructure.DTO;
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
            var userDTO = userTable.Get(id);
            return Map(userDTO);
        }

        public void Save()
        {
            if(Id == -1)
            {
                var userTable = new UserTable();
                userTable.Create(Map(this));
                return;
            }

            // UPDATE
        }

        public static IEnumerable<User> GetAll(int id)
        {
            throw new NotImplementedException();
        }

        private static User Map(UserDTO userDTO)
        {
            return new User
            {
                Name = userDTO.Name
            };
        }

        private static UserDTO Map(User user)
        {
            return new UserDTO
            {
                Name = user.Name
            };
        }
    }
}
