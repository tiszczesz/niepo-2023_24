using cw3_razor_vs.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace cw3_razor_vs.PAges
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private UserRepo _userRepo ;
        [BindProperty] public List<User>? Users { get; set; }

     
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            _userRepo = new UserRepo();
           Users = _userRepo.FromJson();
        }
    }
}
