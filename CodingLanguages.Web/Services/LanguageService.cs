using CodingLanguages.Web.Models;
using CodingLanguages.Web.Services.IServices;
using CodingLanguages.Web.Utils;

namespace CodingLanguages.Web.Services
{
    public class LanguageService : ILanguageService
    {
        private readonly HttpClient _client;
        public const string BasePath = "api/v1/language";

        public LanguageService(HttpClient client)
        {
            _client = client?? throw new ArgumentNullException(nameof(client));
        }

        public async Task<IEnumerable<LanguageModel>> FindAllLanguages()
        {
            var response = await _client.GetAsync(BasePath);
            return await response.ReadContentAs<List<LanguageModel>>();
        }

        public async Task<LanguageModel> FindLanguageById(long id)
        {
            var response = await _client.GetAsync($"{BasePath}/{id}");
            return await response.ReadContentAs<LanguageModel>();
        }
        public async Task<LanguageModel> CreateLanguage(LanguageModel language)
        {
            var response = await _client.PostAsJson(BasePath, language);
            if (response.IsSuccessStatusCode) return await response.ReadContentAs<LanguageModel>();
            else throw new Exception($"Something went wrong when calling the API: {response}");
        }

        public async Task<LanguageModel> UpdateLanguage(LanguageModel language)
        {
            var response = await _client.PutAsJsonAsync(BasePath, language);
            if (response.IsSuccessStatusCode) return await response.ReadContentAs<LanguageModel>();
            else throw new Exception($"Something went wrong when calling the API: {response} {language}");
        }

        public async Task<bool> DeleteLanguageById(long id)
        {
            var response = await _client.DeleteAsync($"{BasePath}/{id}");
            if (response.IsSuccessStatusCode) return await response.ReadContentAs<bool>();
            else throw new Exception($"Something went wrong when calling the API: {response}");
        }
    }
}
