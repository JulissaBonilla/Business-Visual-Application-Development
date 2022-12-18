/*
 * Project:         Assignment 4 Program 9
 * Date:            October 2022
 * Developed By:    JulissaB
 * Purpose:         Conference Calculator that calculates the total charge and shows discounts and breakdown of charges.
 * Last Modified:   10/21/22
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace JBonillaProgram9
{
    public enum AccommodationType
    {
        Single,
        Double,
        Suite
    }
    class Conference
    {
        private AccommodationType accommodationChoice;
        private const decimal accommodationDiscount=0.12m;
        private const decimal doubleRate=56.74m;
        private bool internetAccess;
        private const decimal internetAccessRate=7.28m;
        private const int minAttendeesForDiscount=75;
        private const int minNightsForDiscount=5;
        private int numberOfAttendees;
        private int numberOfNights;
        private const decimal optionalServicesDiscount=7.5m;
        private bool recreationCenterAccess;
        private const decimal recreationCenterAccessRate=6.13m;
        private const decimal singleRate=83.61m;
        private const decimal suiteRate =101.95m;

        public string ConferenceName { get; set; }
        public decimal AccommodationCharge { get; set; }
        public AccommodationType AccommodationChoice { get; set; }
        public decimal Discount { get; set; }
        public bool InternetAccess { get; set; }
        public int NumberOfAttendees { get; set; }
        public int NumberOfNights { get; set; }
        public decimal OptionalServicesCharge { get; set; }
        public bool RecreationCenterAccess { get; set; }
        public decimal TotalCharge { get; set; }
        
        //constructor
        public Conference(string confName, int numAttendees, int numNights, AccommodationType accommodation, bool internet, bool recCenter)
        {
            ConferenceName = confName;
            NumberOfAttendees = numAttendees;
            NumberOfNights = numNights;
            AccommodationChoice = accommodation;
            InternetAccess = internet;
            RecreationCenterAccess = recCenter;
        }
        
        //Calculates the accommodationRate
        private decimal ReturnAccommodationRate()
        {

            decimal accRate = 0;
            //switch case to determine the rate based on the accomodation type selected
            switch (AccommodationChoice)
             {
                case AccommodationType.Single:
                    {
                        accRate = Convert.ToDecimal(singleRate);
                        break;
                    }
                    
                case AccommodationType.Double:
                    {
                        accRate = doubleRate;
                        break;
                    }
                    
                case AccommodationType.Suite:
                    {
                        accRate = suiteRate;
                        break;
                    }
                    
                default: break;
            }
            return accRate;
        }
        

        private void CalcConferenceCharges()
        {
            //local variables
            decimal attendeesXnights= NumberOfAttendees * NumberOfNights;//repeated calculation made into a variable
            decimal internetCharge = 0;//default zero charge
            decimal recCenterCharge = 0;//default zero charge
           
            //accommodation charge calculation
            AccommodationCharge = ReturnAccommodationRate()* attendeesXnights;
            
            //If internet access is selected
            if(InternetAccess)
            {
                internetCharge = internetAccessRate * attendeesXnights;
            }
            //If Recreation 
            if(RecreationCenterAccess)
            {
                recCenterCharge=recreationCenterAccessRate * attendeesXnights;
            }
            OptionalServicesCharge = internetCharge + recCenterCharge;
            //if the qualified numbers are met then a discount is applied
            if (NumberOfAttendees>=minAttendeesForDiscount && NumberOfNights>=minNightsForDiscount)
            {
                Discount = (AccommodationCharge * accommodationDiscount) + (OptionalServicesCharge * optionalServicesDiscount);
            }
            TotalCharge = AccommodationCharge + OptionalServicesCharge - Discount;
            
                
            
        }
        //Creates a summary of the accomodation charges and discounts
        public override string ToString()
        {
            string output = string.Empty;
            //call the calculations
            CalcConferenceCharges();

            output = $"Accommodation Charge: {AccommodationCharge.ToString("c")} \n Optional Service Charge:{OptionalServicesCharge.ToString("c")} \n Discount: {Discount.ToString("c")} \n Total Charges: {TotalCharge.ToString("c")}";

            return output;
        }
    }
}
