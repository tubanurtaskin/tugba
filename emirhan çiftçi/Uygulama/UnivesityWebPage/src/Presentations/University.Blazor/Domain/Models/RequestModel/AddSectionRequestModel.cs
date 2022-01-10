using System.ComponentModel.DataAnnotations;

namespace University.Blazor.Domain.Models.RequestModel
{
    public class AddSectionRequestModel
    {
        public string Name { get; set; }
        public string Content { get; set; }
        public int Priority { get; set; }

        public AddSectionRequestModel(string name, string content, int priority)
        {
            Content = content;
            Priority = priority;
            Name = name;
        }
    }
}
