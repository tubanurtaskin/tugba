namespace University.Blazor.Domain.Models.RequestModel
{
    public class UpdateSectionRequestModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public int Priority { get; set; }

        public UpdateSectionRequestModel(string id, string name, string content, int priority)
        {
            Id = id;
            Name = name;
            Content = content;
            Priority = priority;
        }
    }
}
