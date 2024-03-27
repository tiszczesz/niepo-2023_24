using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class Index2Model : PageModel
    {
        [BindProperty]
        public List<string> Names { get; set; }
        public void OnGet()
        {
            Names = new List<string>{"Jan","Monika","Roman","Leszek"};
        }
    }
}
