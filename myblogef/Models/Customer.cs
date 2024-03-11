using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace myblogef.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }   
       
        public int? Age { get; set; }
        [Column(TypeName ="tinyint")]
        public Tyegender Gender { get; set; }
        public string? PhoneNumber { get; set; }
        public DateTime DateofBrith { get; set; }
        public int?  BankAccountNumber { get; set; }
       
       

    }
}
public enum Tyegender
{

    None = 0,
    Male=1,
  Famale=1
}
