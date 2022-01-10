namespace University.Blazor.Domain.Models.HtmlModels
{
    public class LinkModel
    {
        public LinkModel()
        {
            SubLinks ??= new List<LinkModel>();
        }
        public string Id { get; set; }
        public string Name { get; set; }
        public string Href { get; set; }
        public bool IsNode { get; set; } = false;
        public virtual List<LinkModel> SubLinks { get; set; }
    }
}
