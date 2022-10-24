using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment10_2_
{
    internal class Parking
    {
        TimeSpan totalTime;
        TimeSpan checkinTime;
        TimeSpan checkoutTime;

        public Parking(TimeSpan checkinTime, TimeSpan checkoutTime)
        {
            CheckinTime = checkinTime;
            CheckoutTime = checkoutTime;
        }
        public TimeSpan CheckinTime { get; set; }
        public TimeSpan CheckoutTime { get; set; }

        public TimeSpan HowLong()
        {
            return totalTime = CheckoutTime - CheckinTime;

        }


        public double Totalcharges(TimeSpan checkinTime, TimeSpan checkoutTime)
        {
            double totalCharge = 0;
            var start = Convert.ToDouble(checkinTime.TotalHours);
            var end = Convert.ToDouble(checkoutTime.TotalHours);
            var difference = end - start;
            double Time = Math.Ceiling(difference);
            if (Time <= 2)
            {
                totalCharge = Time * 2;
            }
            else if (Time > 2 && Time <= 5)
            {
                totalCharge = Time * 1.75;
            }
            else
            {
                totalCharge = Time * 1.5;
            }


            return totalCharge;
        }
    }
}
