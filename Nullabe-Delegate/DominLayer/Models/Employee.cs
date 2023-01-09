using DominLayer.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominLayer.Models
{
    public class Employee : BaseEntity  
    {
        public string Name { get; set; }
        public int Age { get; set; }

    }
}
