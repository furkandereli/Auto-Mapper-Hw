using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AutoMapperHw.Models
{
    public class PersonDTO
    {
        public int Id {  get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"Id : {Id}, FullName : {FullName}, Age : {Age}";
        }
    }
}
