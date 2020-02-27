using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CandyShop.Domain.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        [Required(ErrorMessage = "Please enter your first name.")]
        [Display(Name ="First Name")]
        [StringLength(25)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please enter your last name.")]
        [Display(Name = "Last Name")]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter your address.")]
        [Display(Name = "Home Address")]
        [StringLength(100)]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please enter your email.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage ="Please enter your city.")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please enter your state.")]
        [StringLength(2, MinimumLength = 2)]
        public string State { get; set; }

        [Required(ErrorMessage = "Please enter your zip.")]
        [Display(Name ="Zip Code")]
        [StringLength(5, MinimumLength = 5)]
        public string ZipCode { get; set; }

        [Required(ErrorMessage = "Please enter your phone number.")]
        [Display(Name ="Phone Number")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        public IEnumerable<OrderDetail> OrderDetails { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public decimal OrderTotal { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime OrderPlaced { get; set; }
    }
}
