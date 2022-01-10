using System.Text;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using University.Blazor.Domain.Models.HtmlModels;
using University.Blazor.Domain.Models.RequestModel;

namespace University.Blazor.Application.Services;

public class UniversityService : IUniversityService , IDisposable
{
    #region fields
    private readonly HttpClient _httpClient;
    private bool _disposed;
    #endregion

    #region ctors
    public UniversityService(IHttpClientFactory factory)
    {
        _httpClient = factory.CreateClient("University");
    }

    #endregion

    #region methods

    #region links
    public async Task<IEnumerable<LinkModel>> GetLinks(bool isJustNode = true)
    {
        var response = await  _httpClient.GetAsync($"Links/GetAllLink?isJustNode={isJustNode}");
        var content = await response.Content.ReadAsStringAsync();
        var linkModels = JsonConvert.DeserializeObject<List<LinkModel>>(content);
        return linkModels;
    }
    public async Task<bool> CreateLink(AddLinkRequestModel addLinkRequestModel)
    {
        var jsonContent = JsonConvert.SerializeObject(addLinkRequestModel);
        var body = new StringContent(jsonContent, Encoding.UTF8, "application/json");

        var response = await _httpClient.PostAsync("Links/CreateLink", body);
        var content = await response.Content.ReadAsStringAsync();
        var result = JsonConvert.DeserializeObject<bool>(content);

        return result;
    }
    public async Task<bool> UpdateLink(UpdateLinkRequestModel linkUpdateRequestModel)
    {
        var jsonContent = JsonConvert.SerializeObject(linkUpdateRequestModel);
        var body = new StringContent(jsonContent, Encoding.UTF8, "application/json");

        var response = await _httpClient.PostAsync("Links/UpdateLink", body);
        var content = await response.Content.ReadAsStringAsync();
        var result = JsonConvert.DeserializeObject<bool>(content);

        return result;
    }
    public async Task<LinkModel> GetLinkById(string id)
    {
        var response = await _httpClient.GetAsync($"Links/GetById/{id}");
        var content = await response.Content.ReadAsStringAsync();

        var result = JsonConvert.DeserializeObject<LinkModel>(content);

        return result;
    }
    public async Task<bool> DeleteLink(string id)
    {
        var response = await _httpClient.DeleteAsync($"Links/DeleteLink/{id}");
        var content = await response.Content.ReadAsStringAsync();

        var result = JsonConvert.DeserializeObject<bool>(content);

        return result;
    }
    #endregion


    #region sections

    public async Task<IEnumerable<SectionModel>> GetSections()
    {
        var response = await _httpClient.GetAsync($"Sections/GetAllSection");
        var content = await response.Content.ReadAsStringAsync();
        var SectionModels = JsonConvert.DeserializeObject<List<SectionModel>>(content);
        return SectionModels;
    }
    public async Task<bool> CreateSection(AddSectionRequestModel addSectionRequestModel)
    {
        var jsonContent = JsonConvert.SerializeObject(addSectionRequestModel);
        var body = new StringContent(jsonContent, Encoding.UTF8, "application/json");

        var response = await _httpClient.PostAsync("Sections/CreateSection", body);
        var content = await response.Content.ReadAsStringAsync();
        var result = JsonConvert.DeserializeObject<bool>(content);

        return result;
    }
    public async Task<bool> UpdateSection(UpdateSectionRequestModel SectionUpdateRequestModel)
    {
        var jsonContent = JsonConvert.SerializeObject(SectionUpdateRequestModel);
        var body = new StringContent(jsonContent, Encoding.UTF8, "application/json");

        var response = await _httpClient.PostAsync("Sections/UpdateSection", body);
        var content = await response.Content.ReadAsStringAsync();
        var result = JsonConvert.DeserializeObject<bool>(content);

        return result;
    }
    public async Task<SectionModel> GetSectionById(string id)
    {
        var response = await _httpClient.GetAsync($"Sections/GetById/{id}");
        var content = await response.Content.ReadAsStringAsync();

        var result = JsonConvert.DeserializeObject<SectionModel>(content);

        return result;
    }
    public async Task<bool> DeleteSection(string id)
    {
        var response = await _httpClient.DeleteAsync($"Sections/DeleteSection/{id}");
        var content = await response.Content.ReadAsStringAsync();

        var result = JsonConvert.DeserializeObject<bool>(content);

        return result;
    }

    #endregion


    #endregion

    //public async Task<IEnumerable<SectionModel>> GetSections()
    //{
    //    ret
    //}

    //public async Task<IEnumerable<SocialMediaModel>> GetSocialMedia()
    //{

    //}

    #region dispose
    public void Dispose()
    {
        if (!_disposed)
        {
            _httpClient.Dispose();
            GC.SuppressFinalize(this);
            _disposed = true;
        }
    }
    #endregion
}