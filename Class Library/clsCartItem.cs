using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for clsProduct
/// </summary>
public class clsCartItem
{
    public clsCartItem()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    private Int32 mProductId;
    public Int32 ProductId
    {
        get
        {
            return mProductId;
        }

        set
        {
            mProductId = value;
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
    private Int32 mUnitCost;
    public Int32 UnitCost
    {
        get
        {
            return mUnitCost;
        }

        set
        {
            mUnitCost = value;
        }
    }
    private decimal mPrice;
    public decimal Price
    {
        get
        {
            return mPrice;
        }

        set
        {
            mPrice = value;
        }
    }
    private float mTotal;
    public float Total
    {
        get
        {
            return mTotal;
        }

        set
        {
            mTotal = value;
        }
    }
}