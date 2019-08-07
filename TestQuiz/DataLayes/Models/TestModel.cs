using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayes.Models
{
    public class TestModel:Entity
    {
        public User TestOwner { get; set; }

        public List<Question> Questions { get; set; }
    }
}
