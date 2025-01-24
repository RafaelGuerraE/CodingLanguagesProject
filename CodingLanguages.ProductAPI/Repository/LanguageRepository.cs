using AutoMapper;
using CodingLanguages.API.Model.Context;
using CodingLanguages.API.Data.ValueObjects;
using Microsoft.EntityFrameworkCore;
using CodingLanguages.API.Model;

namespace CodingLanguages.API.Repository
{
    public class LanguageRepository : ILanguageRepository
    {
        private readonly MySQLContext _context;
        private IMapper _mapper;

        public LanguageRepository(MySQLContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<IEnumerable<LanguageVO>> FindAllLanguages()
        {
            List<Language> languages = await _context.Languages.ToListAsync();
            return _mapper.Map<List<LanguageVO>>(languages);
        }

        public async Task<LanguageVO> FindLanguageById(long id)
        {
            Language language = await _context.Languages.Where(p => p.Id == id).FirstOrDefaultAsync()?? new Language();
            return _mapper.Map<LanguageVO>(language);
        }

        public async Task<LanguageVO> CreateLanguage(LanguageVO vo)
        {
            Language language = _mapper.Map<Language>(vo);
            _context.Languages.Add(language);
            await _context.SaveChangesAsync();
            return _mapper.Map<LanguageVO>(language);
        }

        public async Task<LanguageVO> UpdateLanguage(LanguageVO vo)
        {
            Language language = _mapper.Map<Language>(vo);
            _context.Languages.Update(language);
            await _context.SaveChangesAsync();
            return _mapper.Map<LanguageVO>(language);
        }

        public async Task<bool> DeleteLanguage(long id)
        {
            try
            {
                Language language = await _context.Languages.Where(l => l.Id == id).FirstOrDefaultAsync()?? new Language();
                if (language.Id <= 0) return false;
                _context.Languages.Remove(language);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> LanguageExists(long id)
        {
            return await _context.Languages.AnyAsync(l => l.Id == id);
        }
    }
}
