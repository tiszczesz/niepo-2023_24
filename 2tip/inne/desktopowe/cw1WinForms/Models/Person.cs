using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw1WinForms.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public int? Age { get; set; }
        public override string ToString()
        {
            return $"{Id}|{Firstname}|{Lastname}|{Age}";
        }
    }
}
