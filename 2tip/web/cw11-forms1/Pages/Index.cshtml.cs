using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public List<string> Colors { get; set; }
        public IndexModel(){
             Colors = new List<string>{"red","green","blue"};
        }
        public void OnGet()
        {           
            ViewData["info"] = "ala ma kota";
            var result = Request.Query;
            ViewData["result"] = result;
        }
    }
}
