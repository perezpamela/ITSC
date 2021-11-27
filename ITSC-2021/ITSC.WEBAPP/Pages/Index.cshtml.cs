using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;



namespace ITSC.WebApp.Pages
{
    public class IndexModel : MBase//PageModel
    {
        [BindProperty(SupportsGet = true)]
        public int usuarioDNI { get; set; }
        private readonly ILogger<IndexModel> _logger;
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public IActionResult OnGet(int usuarioDNI)
        {
            return Page();
        }

        public IActionResult OnPost(int usuarioDNI)
        {
            return RedirectToPage("./Dashboard", new { usuario = usuarioDNI });

        }


    }
}
