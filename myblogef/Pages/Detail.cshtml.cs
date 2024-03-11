using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using myblogef.Data;
using myblogef.Models;

namespace myblogef.Pages
{
    public class DetaleModel : PageModel
    {
        private readonly BlogDbContext _db;
        public DetaleModel(BlogDbContext db)
        {
           customer=new ();    
            _db = db;
        }
       
        public Customer? customer { get; set; }

        public void Onget(int id)
        {
          customer = _db.customers.FirstOrDefault(u=>u.Id==id);

        }
    }
}
