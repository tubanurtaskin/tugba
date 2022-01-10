using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Domain.HttpModels
{
    public class LoginResponseModel
    {
        public string Email { get; set; }

        public string UserToken { get; set; }
    }
}
