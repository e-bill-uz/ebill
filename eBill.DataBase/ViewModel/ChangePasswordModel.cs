using System;
using System.Collections.Generic;
using System.Text;

namespace eBill.DataBase.ViewModel
{
    public class ChangePasswordModel
    {
        public string UserName { get; set; }
        public string NewPassword { get; set; }
        public string OldPassword { get; set; }
    }
}
