using System.Collections.Generic;
using System.Linq;


namespace SalesWebMvc.Models
{
    public class SellerFormViewModel
    {
        public Seller Seller { get; set; }
        public ICollection<Department> Departments { get; set; }
    }
}
