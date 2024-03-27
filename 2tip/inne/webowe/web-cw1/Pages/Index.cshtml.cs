using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
            ViewData["isShow"] = true;
            ViewData["Message"] = "Hello World";
            ViewData["Message2"] = "Inna wiadomość";
            
        }
    }
}
