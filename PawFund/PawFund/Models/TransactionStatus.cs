using System.ComponentModel.DataAnnotations.Schema;

namespace PawFund.Models
{
    [Table(name: "TransactionStatus")]
    public class TransactionStatus
    {
        public int TransactionStatusId { get; set; }
        public string Status { get; set; }
    }
}
