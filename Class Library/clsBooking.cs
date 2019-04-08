using System;

namespace Class_Library
{
    public class clsBooking
    {
        public DateTime DateAdded;

        public int CustomerNo { get; set; }
        public string Address { get; set; }
        public clsCustomer Customer { get; set; }
        public clsBooking BookingNo { get; set; }
        public string Admin { get; set; }
        public DateTime BookingDate { get; set; }
        public clsAdmin Blog { get; set; }
    }
    }