using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDeveloper.Model.Account
{
    public class LoginViewModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public Boolean RemenberMe { get; set; }
    }
}
