using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace Buisnesslogic
{
    public class Login
    {
        public string _medarbejderID;
        public string _password;
        

        public void get_Login(string medarbejderID, string password)
        {
            _medarbejderID = medarbejderID;
            _password = password;


        }
    }
}
