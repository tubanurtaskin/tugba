using System.ComponentModel.DataAnnotations;

namespace University.Blazor.Domain.Models.RequestModel
{
    public class AddLinkRequestModel
    {
        public string Name { get; set; }
        public string Href { get; set; }
        public bool IsNode { get; set; }

        [Required(AllowEmptyStrings = true)]
        public string? LinkId { get; set; }

        public AddLinkRequestModel(string name, string href, bool isNode, string? linkId = null)
        {
            Name = name;
            Href = href;
            IsNode = isNode;
            LinkId = linkId;
        }
    }

    public class LinkViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
}
