using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NavyaPortfolio.Pages
{
    public class ContactModel : PageModel
    {
        [BindProperty]
        public string? Name { get; set; }

        [BindProperty]
        public string? Email { get; set; }

        [BindProperty]
        public string? Message { get; set; }

        public bool IsSubmitted { get; set; } = false;

        public void OnGet()
        {
        }

        public void OnPost()
        {
            // In real-world, save to DB or send email
            IsSubmitted = true;
        }
    }
}
