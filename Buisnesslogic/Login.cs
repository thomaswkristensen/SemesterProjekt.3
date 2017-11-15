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
        private HP_DTO _HP_DTO;
        
        public HP_DTO get_Login(string medarbejderID, string password)
        {
            _HP_DTO = new HP_DTO();

            _HP_DTO.EmployeeID = medarbejderID;
            _HP_DTO.Password = password;

            return _HP_DTO;

        }

        public void openSSNW()
        {
            
        }


        

        
    }
}
