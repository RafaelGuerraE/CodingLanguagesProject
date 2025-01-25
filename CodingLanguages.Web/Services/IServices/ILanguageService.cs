using CodingLanguages.Web.Models;

namespace CodingLanguages.Web.Services.IServices
{
    public interface ILanguageService
    {
        Task<IEnumerable<LanguageModel>> FindAllLanguages();
        Task<LanguageModel> FindLanguageById(long id);
        Task<LanguageModel> CreateLanguage(LanguageModel language);
        Task<LanguageModel> UpdateLanguage(LanguageModel language);
        Task<bool> DeleteLanguageById(long id);
    }
}
