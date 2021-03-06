using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job_posting_platform.User
{
    interface User
    {
         string City { get; set; }
        string Email { get; set; }
        long PhoneNumber { get; set; }

        void UserShow();
    }
}
