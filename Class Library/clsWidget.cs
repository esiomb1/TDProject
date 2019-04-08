
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Class_Library
{
    public class clsWidget
    {
        public clsWidget()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private Int32 mWidgetNo;
        public Int32 WidgetNo
        {
            get
            {
                return mWidgetNo;
            }
            set
            {
                mWidgetNo = value;
            }
        }

        private string mWidget;
        public string Widget
        {
            get
            {
                return mWidget;
            }
            set
            {
                mWidget = value;
            }
        }
    }
}