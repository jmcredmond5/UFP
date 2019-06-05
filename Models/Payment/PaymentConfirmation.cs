using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace UFPCore.Models.Payment
{
    public class PaymentConfirmation
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int UsersId { get; set; }
        [Required]
        public int Year { get; set; }
    }
}