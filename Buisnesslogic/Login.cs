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
        
        public bool get_Login(string medarbejderID, string password, HP_DTO hpDto)
        {
            _HP_DTO = hpDto;

            if (_HP_DTO.EmployeeID == medarbejderID && _HP_DTO.Password == password)
            {
                return true;
            }

            return false;

        }
    }
}
