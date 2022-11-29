using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthDemo.Shared.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public string Email { get; set; }
        public string Status { get; set; }
    }
}
