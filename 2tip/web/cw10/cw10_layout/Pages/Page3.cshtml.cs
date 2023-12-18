using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class Page3Model : PageModel
    {
        [BindProperty]
        public List<string> Gifts { get; set; }
        public Page3Model()
        {
            Gifts = new List<string>{
                "Konik na biegunach",
                "Rybki", "Klocki LEGO",
                "Lalka","Rowerek","skarpetki"
            };
        }
        public void OnGet()
        {
        }
    }
}
