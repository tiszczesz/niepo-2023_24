using cw2_razor;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class Page2Model : PageModel
    {
        [BindProperty]
        public int Limit { get; set; }
        public void OnGet()
        {
        }
        public void OnPost()
        {
            if (ModelState.IsValid)
            {
                PrimaryNumbers pn = new();
                var primals = pn.GetPrimals(Limit);
                //todo
            }



        }
    }
}
