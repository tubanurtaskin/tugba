using University.Blazor.Domain.Models.HtmlModels;
using University.Blazor.Domain.Models.RequestModel;

namespace University.Blazor.Application.Services;

public interface IUniversityService
{
    #region link
    Task<IEnumerable<LinkModel>> GetLinks(bool isJustNode = true);
    Task<LinkModel> GetLinkById(string id);
    Task<bool> UpdateLink(UpdateLinkRequestModel linkUpdateRequestModel);
    Task<bool> CreateLink(AddLinkRequestModel linkUpdateRequestModel);
    Task<bool> DeleteLink(string id);
    #endregion


    #region section
    Task<IEnumerable<SectionModel>> GetSections();
    Task<SectionModel> GetSectionById(string id);
    Task<bool> UpdateSection(UpdateSectionRequestModel SectionUpdateRequestModel);
    Task<bool> CreateSection(AddSectionRequestModel SectionUpdateRequestModel);
    Task<bool> DeleteSection(string id);

    #endregion

}