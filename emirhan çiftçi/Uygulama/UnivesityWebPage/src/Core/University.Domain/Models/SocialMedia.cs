using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Domain.SeedWork;

namespace University.Domain.Models
{
    public class SocialMedia : BaseEntity
    {
        public string IconHtml { get; set; }
        public string Href { get; set; }
    }
}
