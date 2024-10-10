using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Supermarket_mvp.Models
{
    internal class CustomersModel
    {
        [DisplayName("Customers Name")]
        public int Id { get; set; }

        [DisplayName("Customers Document")]
        [Required(ErrorMessage ="Document is required")]
        [StringLength(15, MinimumLength = 3, ErrorMessage ="Customers Document must be between 3 and 50 characteres")]
        
        public string document_number { get; set; }
        
        [DisplayName("Customers Firts_Name")]
        [Required(ErrorMessage = "Firts_Name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Customers Firt_Name must be between 3 and 50 characteres")]
        public string firts_name { get; set; }

        [DisplayName("Customers Last_Name")]
        [Required(ErrorMessage = "Last_Name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Customers Last_Name must be between 3 and 50 characteres")]
        public string last_name { get; set;}

        [DisplayName("Customers Address")]
        [Required(ErrorMessage = "Address is required")]
        [StringLength(80, MinimumLength = 3, ErrorMessage = "Customers Address must be between 3 and 50 characteres")]
        public string address {  get; set; }

        [DisplayName("Customers Birthday")]
        [Required(ErrorMessage = "Birthday is required")]
        public DateTime? birthday { get; set; }

        [DisplayName("Customers Phone_Numbers")]
        [Required(ErrorMessage = "Phone_Number is required")]
        [StringLength(16, MinimumLength = 3, ErrorMessage = "Customers Phone_Numbers must be between 3 and 50 characteres")]
        public string phone_numbers { get; set; }

        [DisplayName("Customers Email")]
        [Required(ErrorMessage = "Email is required")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Customers Email must be between 3 and 50 characteres")]
        public string email { get; set; }
    }
}
