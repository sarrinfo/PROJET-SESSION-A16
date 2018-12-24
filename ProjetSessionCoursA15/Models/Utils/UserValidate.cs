using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetSessionCoursA15.Models.Utils
{
    public static class UserValidate
    {
        public static bool ValidateUser(string username, string password)
        {
            if (username == "Ibrahima" && password == "abc123...")
            {
                return true;
            }
            else
            {
                return false;
            }

   
        }
    }
}