using CodingLanguages.API.Data.ValueObjects;
using CodingLanguages.API.Repository;
using Microsoft.AspNetCore.Mvc;

namespace CodingLanguages.API.Controllers
{
    [Route("api/v1/language")]
    [ApiController]
    public class LanguageController : ControllerBase
    {
        private ILanguageRepository _repository;

        public LanguageController(ILanguageRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<LanguageVO>>> FindAllLanguages()
        {
            var languages = await _repository.FindAllLanguages();
            return Ok(languages);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<LanguageVO>> FindLanguageById(long id)
        {
            var language = await _repository.FindLanguageById(id);
            if (language.Id <= 0) return NotFound();
            return Ok(language);
        }

        [HttpPost]
        public async Task<ActionResult<LanguageVO>> CreateLanguage([FromBody] LanguageVO vo)
        {
            if (vo == null) return BadRequest();
            var language = await _repository.CreateLanguage(vo);
            return Ok(language);
        }

        [HttpPut]
        public async Task<ActionResult<LanguageVO>> UpdateLanguage([FromBody] LanguageVO vo)
        {
            if (vo == null) return BadRequest();
            var language = await _repository.UpdateLanguage(vo);
            return Ok(language);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteLanguageById(long id)
        {
            var exists = await _repository.LanguageExists(id);
            if (!exists)
            {
                return NotFound(new { message = $"Language with ID {id} not found." });
            }

            var status = await _repository.DeleteLanguageById(id);
            if (!status)
            {
                return BadRequest(new { message = "Failed to delete the language." });
            }
            return NoContent();
        }
    }
}
