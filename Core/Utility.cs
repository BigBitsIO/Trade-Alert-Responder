using CsvHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Utility
    {
        public static decimal AdjustLimitPriceBySettings(decimal StartPrice, decimal PricePercentModifier, decimal TickSize, int TicksOffset, int DecimalsToRoundTo = 8)
        {
            decimal Price = StartPrice;

            // Modify our price by percentage
            Price = ModifyPriceByPercentage(Price, PricePercentModifier);

            // Round price to a tick size
            decimal Remainder = Price % TickSize;

            if (Remainder < TickSize / 2)
            {
                Price = Math.Round(Price - Remainder, DecimalsToRoundTo);
            }
            else
            {
                decimal Adjustment = TickSize - Remainder;
                Price = Math.Round(Price + Adjustment, DecimalsToRoundTo);
            }

            // Adjust the price by a tick offset
            Price = OffsetByTickPrice(Price, TicksOffset, TickSize);

            return Price;
        }


        

        public static decimal PercentageChange(decimal Old, decimal New)
        {
            if (Old == 0)
                return 0;
            return (New / Old - 1) * 100;
        }

        public static decimal IntegerPrecisionToDecimalValue(int Precision, int Base = 1)
        {
            return (Base / (decimal)(Math.Pow(10, Precision)));
            // Ex: Base of 1, with precision of 8 is .00000001, or 1 satoshi
            // Ex: Base of 2, with precision of 5 is .00002, or 2000 satoshis
        }

        public static decimal ModifyPriceByPercentage(decimal Price, decimal Percentage)
        {
            if (Percentage == 0)
            {
                return Price;
            }
            else
            {
                return (Price + (Price * (Percentage / 100)));
            }
        }

        public static decimal OffsetByTickPrice(decimal StartPrice, int OffsetCount, decimal TickSize)
        {
            decimal Price = StartPrice;

            decimal Adjustment = OffsetCount * TickSize;
            Price = Price + Adjustment;  // Always adding the adjustment incase the offset is negative, in which case would add a negative (subtract)

            return Price;
        }

        

        public static decimal StringToDecimal(string DecimalString)
        {
            try
            {
                decimal value = 0;

                value = Convert.ToDecimal(DecimalString);

                return value;
            }
            catch(Exception ex)
            {
                return 0; // DEFAULTS TO 0
            }
        }
    }
}
