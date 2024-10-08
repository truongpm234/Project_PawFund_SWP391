﻿using System.ComponentModel.DataAnnotations.Schema;
using System.Transactions;

namespace PawFund.Models
{
    [Table(name: "Transaction")]

    public class Transaction
    {
        public int TransactionId { get; set; }
        public decimal TransactionAmount { get; set; }
        public bool IsMoneyDonation { get; set; }
        public bool IsResourceDonation { get; set; }
        public int? DonationEventId { get; set; }
        public int UserId { get; set; }
        public int TransactionStatusId { get; set; }
        public int TransactionTypeId { get; set; }

        // Navigation properties
        public DonationEvent DonationEvent { get; set; }
        public User User { get; set; }
        public TransactionStatus TransactionStatus { get; set; }
        public TransactionType TransactionType { get; set; }
    }
}
