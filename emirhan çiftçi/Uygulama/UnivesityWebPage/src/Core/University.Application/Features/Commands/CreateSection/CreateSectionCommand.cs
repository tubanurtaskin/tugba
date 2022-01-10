using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Application.Features.Commands.CreateSection
{
    public class CreateSectionCommand : IRequest<bool>
    {
        public SectionDTO? SectionDTO { get; set; }
    }


    public class SectionDTO
    {
        public SectionDTO(string name, string content, int priority)
        {
            Name = name;
            Content = content;
            Priority = priority;
        }
        public string Name { get; set; }
        public string Content { get; set; }
        public int Priority { get; set; }
    }
}
