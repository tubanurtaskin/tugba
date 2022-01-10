namespace University.Application.Features.Queries.ViewModels;

public class LinkViewModel
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Href { get; set; }
    public bool IsNode { get; set; } 
    public string LinkId { get; set; }
    public virtual List<LinkViewModel> SubLinks { get; set; }
}