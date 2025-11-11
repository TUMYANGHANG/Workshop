using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workshop3
{
    internal class NullOpe
    {
        string userFullName = null;

        public string CheckIfNull()
        {
            return userFullName == null ? "user name is null" : userFullName;
        }

        public string CheckUsingCoalescing()
        {
            return userFullName ?? "GuestUser";
        }

        public void SetDefaultUserName()
        {
            userFullName ??= "DefaultUser";
            Console.WriteLine(userFullName);
        }
    }

