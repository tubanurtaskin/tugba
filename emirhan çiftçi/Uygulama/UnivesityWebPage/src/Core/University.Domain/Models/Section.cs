using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Domain.SeedWork;

namespace University.Domain.Models
{
    public class Section : BaseEntity
    {
        public string Name { get; set; }
        public string Content { get; set; }
        public int Priority { get; set; }
    }
}
