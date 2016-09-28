using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;

namespace LoanTapeService.Models
{
    public class Loan
    {
        public int Id { get; set; }
        public int BorrowerId { get; set; }
        public double Amount { get; set; }
        public DateTime OriginalDate { get; set; }
        public LoanType LoanType { get; set; }
        public double Apr { get; set; }
        public List<Action> Events;

    }

    public class Borrow
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public enum LoanType
    {
        Active = 0,
        PaidOff = 1,
        Cancelled = 2
    }
    public abstract class Action
    {
        public int Id;
        public DateTime CreationDate { get; set; }
        public  ActionType ActionType{ get; set; }
        public int ActionId { get; set; }
    }

    public class LoanPayment: Action
    {
        public double Amount { get; set; }
        public PaymentType PaymentType { get; set; }
    }

    public enum ActionType
    {
        Payment = 0    
    }

    public enum PaymentType
    {
        Manual = 0,
        Automatic = 1
    }
}