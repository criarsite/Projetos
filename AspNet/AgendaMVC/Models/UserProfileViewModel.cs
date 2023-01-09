using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgendaMVC.Models
{
    public class UserProfileViewModel
    {
        public string? Name { get;  set; }
        public string? EmailAddress { get;  set; }
        public string? ProfileImage { get;  set; }
    }
}