using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class UserService
    {
        public bool GetUserPromotion(int id)
        {
            // Get DATA
            var user = User.Get(id);

            // Domain login
            try
            {
                user.Promote();
                user.Role = 5;
                user.Save();
            }
            catch(Exception e)
            {
                return false;
            }

            return true;
        }
    }
}
