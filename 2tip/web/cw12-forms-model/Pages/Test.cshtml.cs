using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{

   
    public class TestModel : PageModel
    {     
        [BindProperty]
        public string? Dane { get; set; }

        [BindProperty]
        public bool MyCheckbox { get; set; }
        public void OnGet()
        {
        }
        public void OnPostSave(){
            var dd = Dane;
        }
        public void OnPostCheck(){
            if(MyCheckbox){
                ViewData["result"] = "Zazanaczony";
            }else{
                 ViewData["result"] = "Niezazanaczony";
            }
        }
    }
}
