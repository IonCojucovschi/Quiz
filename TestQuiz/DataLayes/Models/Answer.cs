using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayes.Models
{
    public class Question:Entity
    {
        public string Content { get; set; }

        public bool IsTrueFalse { get; set; }

        public ICollection<Response> Responses { get; set; }
    }
}
