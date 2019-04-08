using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Library
{
  public  class clseCartItem
    {
        private Int32 mBookingNo;
        public Int32 BookingNo
        {
            get
            {





                return mBookingNo;
            }

            set
            {
                mBookingNo = value;
            }
        }

        private Int32 mQTY;
        public Int32 QTY
        {
            get
            {
                return mQTY;
            }

            set
            {
                mQTY = value;
            }
        }
    }

}
