using System;

namespace DelegatesChallenge
{
    // zone1 : 25%
    // zone2 : 25% + 12% is high risk
    // zone3 : 8%
    // zone4 : 4% is high risk


    // declare the delegate type used to calculate the fees
    public delegate void ShippingFeesDelegate(decimal thePrice, ref decimal fee);

    abstract class ShippingDestination
    {
        public bool highRisk;
        public virtual void calcFees(decimal price, ref decimal fee) { }

        public static ShippingDestination getDestination(string dest)
        {
            if (dest.Equals("zone1"))
            {
                return new Dest_Zone1();
            }
            if (dest.Equals("zone2"))
            {
                return new Dest_Zone2();
            }
            if (dest.Equals("zone3"))
            {
                return new Dest_Zone3();
            }
            if (dest.Equals("zone4"))
            {
                return new Dest_Zone4();
            }
            return null;
        }
    }

    internal class Dest_Zone4 : ShippingDestination
    {
        public Dest_Zone4()
        {
            this.highRisk = true;
        }
        public override void calcFees(decimal price, ref decimal fee)
        {
            fee = price * 0.04m;
        }
    }

    internal class Dest_Zone3 : ShippingDestination
    {
        public Dest_Zone3()
        {
            this.highRisk = false;
        }
        public override void calcFees(decimal price, ref decimal fee)
        {
            fee = price * 0.08m;
        }
    }

    internal class Dest_Zone2 : ShippingDestination
    {
        public Dest_Zone2()
        {
            this.highRisk = true;
        }
        public override void calcFees(decimal price, ref decimal fee)
        {
            fee = price * 0.12m;
        }
    }

    internal class Dest_Zone1 : ShippingDestination
    {
        public Dest_Zone1()
        {
            this.highRisk = false;
        }
        public override void calcFees(decimal price, ref decimal fee)
        {
            fee = price * 0.25m;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ShippingFeesDelegate theDelegate;
            ShippingDestination theDest;

            string theZone;

            do
            {
                // get the destination zone
               

                // if the user wrote "exit" then terminate the program,
                // otherwise continue 

                    // given the zone, retrieve the associated shipping info
                    

                    // if there's no associated info, then the user entered
                    // an invalid zone, otherwise continue
                    
                        // ask for the price and convert the string to a decimal number
                        

                        // Each ShippingDestination object has a function called calcFees,
                        // use that as the delegate for calculating the fee
                        

                        // For high-risk zones, we tack on the delegate that adds more
                        

                        // now all that is left to do is call the delegate and output
                        // the shipping fee to the Console
                        
            } while (theZone != "exit");
        }

    }
}
