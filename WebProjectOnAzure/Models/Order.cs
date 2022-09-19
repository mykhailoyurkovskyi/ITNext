﻿using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebProjectOnAzure.Models
{
    
    public partial class Order
    {

        [BindNever]
        [ScaffoldColumn(false)]
        public int OrderID { get; set; }

        [ScaffoldColumn(false)]
        public DateTime OrderDate { get; set; }

        [ScaffoldColumn(false)]
        public string? Username { get; set; }

        [Required(ErrorMessage = "First Name is required")]
        [DisplayName("First Name")]
        [StringLength(160)]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        [DisplayName("Last Name")]
        [StringLength(160)]
        public string? LastName { get; set; }

        [Required(ErrorMessage = "Address is required")]
        [StringLength(70)]
        public string? Address { get; set; }

        [Required(ErrorMessage = "City is required")]
        [StringLength(40)]
        public string? City { get; set; }

        [Required(ErrorMessage = "State is required")]
        [StringLength(40)]
        public string? State { get; set; }

        [Required(ErrorMessage = "Postal Code is required")]
        [DisplayName("Postal Code")]
        [StringLength(10)]
        public string? PostalCode { get; set; }

        [Required(ErrorMessage = "Country is required")]
        [StringLength(40)]
        public string? Country { get; set; }

        [Required(ErrorMessage = "Phone is required")]
        [StringLength(24)]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "Email Address is required")]
        [DisplayName("Email Address")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}",
            ErrorMessage = "Email is is not valid.")]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Card Number is required")]
        [DisplayName("Card Number")]
        public int CardNumber { get; set; }
        [Required(ErrorMessage = "Expiration Date is required")]
        [StringLength(9)]
        [DisplayName("Expiration Date")]
        public string? ExpirationDate { get; set; }
        
        [Required(ErrorMessage = "CVCode must contain 3 integers")]
        [DisplayName("CVCode")]

        public int CVCode { get; set; }

        
        public string? CouponCode { get; set; }        
        [ScaffoldColumn(false)]
        public decimal Total { get; set; }

        public List<OrderDetail>? OrderDetails { get; set; }
    }
}
