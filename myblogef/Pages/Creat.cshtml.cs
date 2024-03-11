using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using myblogef.Data;
using myblogef.Models;

using System.Reflection.Metadata;

namespace myblogef.Pages
{
    public class CreatModel : PageModel
    {
        private readonly BlogDbContext _db;
        public CreatModel (BlogDbContext db)
        {
            customers = new();
            _db = db;
        }
        [BindProperty]
           public Customer? customers { get; set; }
        public IActionResult OnPost()
        {
    
            _db.customers.Add(customers);  
           _db.SaveChanges();
            return Redirect("/Index");
        }
    }
}
