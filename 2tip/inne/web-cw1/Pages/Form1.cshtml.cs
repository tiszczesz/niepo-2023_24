using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class Form1Model : PageModel
    {
        public void OnGet()
        {
            ViewData["isPost"] = false;
            var firstname = Request.Query["firstname"]; //$_GET
            var date = Request.Query["data"];
        }
        public void OnPost(){
            var firstname = Request.Form["firstname"]; //$_POST[]
            var date = Request.Form["data"];
            ViewData["isPost"] = true;
            ViewData["firstname"] = firstname;
            ViewData["data"] = date;
        }
    }
}
