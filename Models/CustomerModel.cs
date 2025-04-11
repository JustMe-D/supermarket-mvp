using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Models
{
    internal class CustomerModel
    {
        [DisplayName("Customer Id")]
        public int Id { get; set; }

        [DisplayName("Document Number")]
        [Required(ErrorMessage = "Document number is required")]
        [StringLength(15, ErrorMessage = "Document number must be 15 characters")]
        public string DocumentNumber { get; set; }

        [DisplayName("First Name")]
        [Required(ErrorMessage = "First name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "First name must be between 3 and 50 characters")]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        [Required(ErrorMessage = "Last name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Last name must be between 3 and 50 characters")]
        public string LastName { get; set; }

        [DisplayName("Address")]
        [StringLength(80, ErrorMessage = "Address cannot exceed 80 characters")]
        public string Address { get; set; }

        [DisplayName("Birthday")]
        public DateTime? Birthday { get; set; }

        [DisplayName("Phone Number")]
        [StringLength(16, ErrorMessage = "Phone number cannot exceed 16 characters")]
        public string PhoneNumber { get; set; }

        [DisplayName("Email")]
        [StringLength(100, ErrorMessage = "Email cannot exceed 100 characters")]
        public string Email { get; set; }
    }
}
