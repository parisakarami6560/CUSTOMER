using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using myblogef.Data;
using myblogef.Models;

namespace myblogef.Pages
{
    public class DeleteModel : PageModel
    {
        private readonly BlogDbContext _db;
        public DeleteModel(BlogDbContext db)
        {
            customer = new();
            _db = db;
        }
        [BindProperty]
        public Customer? customer { get; set; }

        public void Onget(int id)
        {

           customer=new();
            customer = _db.customers.FirstOrDefault(u => u.Id == id);

        }
        public IActionResult Onpost()
        {

            var blog = _db.customers.Find(customer.Id);

            _db.customers.Remove(blog);   
            _db.SaveChanges();
            return RedirectToPage("Index");
            
           
               

           

        }
    }
}

