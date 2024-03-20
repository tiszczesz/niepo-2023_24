using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using web_cw1.Models;


namespace MyApp.Namespace
{
    public class FormModelModel : PageModel
    {
        [BindProperty]
        public Game MyGame { get; set; }
        public void OnGet()
        {
            ViewData["genres"] = GetGenres();
        }
        public void OnPost()
        {
             ViewData["genres"] = GetGenres();
            if(ModelState.IsValid){

            }
        }
        private List<string> GetGenres(){
            return new List<string>{
                "RPG","symulator","FPS","logiczna","przygodowa"
            };
        }
    }
}
