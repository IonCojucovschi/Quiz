using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataLayes.Models
{
    public class Entity
    {
        [Key]
        [ValidateNever]
        public int id { get; set; }
    }
}
