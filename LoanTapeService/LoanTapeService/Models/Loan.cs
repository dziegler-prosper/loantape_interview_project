using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LoanTapeService.Models
{
    public class Loan
    {
        public int Id { get; set; }
        [Required]
        public int CustomerId { get; set; }
        public int Amount { get; set; }
    }
}