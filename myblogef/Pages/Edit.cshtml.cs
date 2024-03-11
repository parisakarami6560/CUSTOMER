using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using myblogef.Data;
using myblogef.Models;

namespace myblogef.Pages
{
    public class EditModel : PageModel
    {
        private readonly BlogDbContext _db;
        public EditModel(BlogDbContext db)
        {
            customer = new();
            customer =new Customer();
            _db = db;
        }
        [BindProperty]
        public Customer? customer { get; set; }

        public void Onget(int id)
        {
            customer = new();
            customer = _db.customers.FirstOrDefault(u=>u.Id==id);
           
        }
        public IActionResult Onpost()
        {
           
             var  blog = _db.customers.Find(customer.Id);
           
             blog.FirstName = customer.FirstName;
            blog.LastName= customer.LastName;
            blog.Email= customer.Email;
            blog.PhoneNumber= customer.PhoneNumber;
            blog.BankAccountNumber= customer.BankAccountNumber;
            blog.Age= customer.Age;
            blog.Gender = customer.Gender;
            blog.DateofBrith= customer.DateofBrith; 
            _db.SaveChanges();
            return RedirectToPage("Index");
           
           

        }
    }
}
