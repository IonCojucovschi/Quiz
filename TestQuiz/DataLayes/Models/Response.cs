using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayes.Models
{
    public class Response:Entity
    {
        public string Content { get; set; }

        public Question Answer { get; set; }
    }
}
