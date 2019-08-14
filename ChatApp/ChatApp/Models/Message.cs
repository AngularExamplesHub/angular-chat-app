using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatApp.Models
{
    public class Message
    {
        public string clientuniqueid { get; set; }
        public string type { get; set; }
        public string message { get; set; }
        public DateTime date { get; set; }
    }
}
