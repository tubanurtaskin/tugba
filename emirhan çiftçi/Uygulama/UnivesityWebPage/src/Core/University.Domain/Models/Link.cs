using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Domain.SeedWork;

namespace University.Domain.Models
{
    public class Link : BaseEntity
    {
        public Link() 
        {
            Id = Guid.NewGuid();
            SubLinks ??= new List<Link>();
        }
        public string Name { get; set; }
        public string Href { get; set; }
        public bool IsNode { get; set; } = false;
        public Guid? LinkId { get; set; }
        public virtual List<Link> SubLinks { get; set; }
    }
}