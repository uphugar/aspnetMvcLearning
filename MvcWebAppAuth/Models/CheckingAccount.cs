﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcWebAppAuth.Models
{
    public class CheckingAccount
    {
        public int Id { get; set; }
        [Display(Name = "Account #")]

        [Required]
        [StringLength(10)]
        [Column(TypeName ="varchar")]
        [RegularExpression(@"\d{6,10}", ErrorMessage = "Account # should be numeric between 6 and 10 characters")]
        public string AccountNumber { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Display(Name = "Name")]
        public string Name
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
        [DataType(DataType.Currency)]
        public decimal Balance { get; set; }

        public virtual ApplicationUser User { get; set; }

        [Required]
        public string ApplicationUserId { get; set; }

        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}