using System;

namespace tst17_SalesWebMvc.Models
{
    public class SallesRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amout { get; set; }
        public Seller Seller { get; set; }
        public SaleStatus Status { get; set; }

        public SallesRecord()
        {
        }

        public SallesRecord(int id, DateTime date, double amout, Seller seller, SaleStatus status)
        {
            Id = id;
            Date = date;
            Amout = amout;
            Seller = seller;
            Status = status;
        }
    }
}
