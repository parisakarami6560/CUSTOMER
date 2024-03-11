using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using myblogef.Data;
using myblogef.Models;

namespace myblogef.Pages
{
    public class IndexModel : PageModel
    {
     
        public List<Customer> customer { get; set; }
        public void OnGet([FromServices]BlogDbContext db)
        {
            customer=db.customers.ToList();    
        }
    }
}
