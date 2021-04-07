using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleMVCApp.Models
{
    public class ContactViewModel
    {
        public string Topic { get; set; }
        public string Title { get; set; }

        public string Content { get; set; }
        public string Fullname { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }
    }
}
