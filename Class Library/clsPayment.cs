using System;

namespace Class_Library
{
    public class clsPayment
    {
        public int CardNo { get; set; }
        public int CVVNo { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string Email { get; set; }
    }
}