using Infrastructure.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Infrastructure
{
    public class UserTable
    {
        public IEnumerable<UserDTO> Get()
        {
            // SQL TODO
            throw new NotImplementedException();
        }

        public UserDTO Get(int id)
        {
            // CALL SQL
            var data = new DataTable();
            return Map(data);
        }

        public bool Create(UserDTO user)
        {
            throw new NotImplementedException();
        }

        public bool Delte(int id)
        {
            throw new NotImplementedException();
        }

        private UserDTO Map( DataTable data)
        {
            throw new NotImplementedException();
        }
    }
}
