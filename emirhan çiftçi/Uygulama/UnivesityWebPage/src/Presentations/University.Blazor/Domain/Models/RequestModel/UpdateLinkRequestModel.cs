namespace University.Blazor.Domain.Models.RequestModel
{
    public class UpdateLinkRequestModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Href { get; set; }

        public UpdateLinkRequestModel(string id, string name, string href)
        {
            Id = id;
            Name = name;
            Href = href;
        }
    }
}
