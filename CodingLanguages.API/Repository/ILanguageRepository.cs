using CodingLanguages.API.Data.ValueObjects;

namespace CodingLanguages.API.Repository
{
    public interface ILanguageRepository
    {
        Task<IEnumerable<LanguageVO>> FindAllLanguages();
        Task<LanguageVO> FindLanguageById(long id);
        Task<LanguageVO> CreateLanguage(LanguageVO vo);
        Task<LanguageVO> UpdateLanguage(LanguageVO vo);
        Task<bool> DeleteLanguageById(long id);
        Task<bool> LanguageExists(long id);
    }
}
