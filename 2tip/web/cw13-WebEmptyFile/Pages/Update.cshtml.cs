using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebEmptyFile.Models;

namespace WebEmptyFile.Pages
{
    public class UpdateModel : PageModel
    {
        public Person MyPerson { get; set; }
        public IActionResult OnGet(string? id)
        {
            if (id != null) {
                var persons = WelcomeRepo.AllFromFile();
                var personToUpdate = persons.FirstOrDefault(p=>p.Id==id);
                if (personToUpdate != null) {
                    MyPerson = personToUpdate;
                    return Page();
                }
            }

            return RedirectToPage(nameof(Index));
        }

        public IActionResult OnPost() {
            if (ModelState.IsValid) {
                //

                //przekierowanie do Index
            }

            return Page();
        }
    }
}
