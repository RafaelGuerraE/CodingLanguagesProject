using CodingLanguages.Web.Models;
using CodingLanguages.Web.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace CodingLanguages.Web.Controllers
{
    public class LanguageController : Controller
    {
        private readonly ILanguageService _languageService;

        public LanguageController(ILanguageService languageService)
        {
            _languageService = languageService?? throw new ArgumentNullException(nameof(languageService));
        }

        public async Task<IActionResult> LanguageIndex()
        {
            var languages = await _languageService.FindAllLanguages();
            return View(languages);
        } 
        
        public async Task<IActionResult> LanguageCreate()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> LanguageCreate(LanguageModel language)
        {
            if (ModelState.IsValid)
            {
                var response = await _languageService.CreateLanguage(language);
                if (response != null) return RedirectToAction(nameof(LanguageIndex));
            }
            return View(language);
        }

        public async Task<IActionResult> LanguageUpdate(long id)
        {
            var language = await _languageService.FindLanguageById(id);
            if(language != null) return View(language);
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> LanguageUpdate(LanguageModel language)
        {
            if (ModelState.IsValid)
            {
                var response = await _languageService.UpdateLanguage(language);
                if (response != null) return RedirectToAction(nameof(LanguageIndex));
            }
            return View(language);
        }
        
        
        public async Task<IActionResult> LanguageDelete(long id)
        {
            var language = await _languageService.FindLanguageById(id);
            if(language != null) return View(language);
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> LanguageDelete(LanguageModel language)
        {
            var response = await _languageService.DeleteLanguageById(language.Id);
            if (response) return RedirectToAction(nameof(LanguageIndex));
            return View(language);
        }
    }
}
