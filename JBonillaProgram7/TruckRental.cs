/*
 * Project: Assignment Set 3- Program 7
 * Date:    October 2022
 * Developed By:    Julissa Bonilla
 * Class Name:  Truck Rental
 * Description: This program calculates the clients price for the truck
 * rental given the odometer readings before and after renting, and the
 * day rate of the rental. 
 * 
 * Last modified: 10/5/2022
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace JBonillaProgram7
{
    class TruckRental
    {
        private int beginOdometerRead;
        private int daysRented;
        private int endOdometerReading;

        //Instance Properties with getter and setter accessors
        public String CustomerName { get; set; }
        public decimal RentalCharge { get; private set; }

        //Set values using the instance method CalculateRentalCharge()
        public int EndOdometerReading
        {
            get
            {
                return endOdometerReading;
            }
            set
            {
                endOdometerReading = value;
                CalculateRentalCharge();
            }
        }
        public int BeginOdometerReading
        {
            get
            {
                return beginOdometerRead;
            }
            set
            {
                beginOdometerRead = value;
                CalculateRentalCharge();
            }
        }

        public int DaysRented
        {
            get
            {
                return daysRented;
            }
            set
            {
                daysRented = value;
                CalculateRentalCharge();
            }
        }
        //Constructors
        public TruckRental()
        {
            throw new System.NotImplementedException();
        }
        //Overload Constructor to instantiate object and set four properties – customer name, ending
        //odometer reading, beginning odometer reading, and number of days rented
        public TruckRental(string nameOfCustomer, int endMiles, int beginMiles, int numDays)
        {
            CustomerName = nameOfCustomer;
            EndOdometerReading = endMiles;
            BeginOdometerReading = beginMiles;
            DaysRented = numDays;
        }


        //Calculate rental charge and set the rental charge property 
        private void CalculateRentalCharge()
        {
            double dayRate = 58.50;
            double mileRate = 0.73;
            double miles = EndOdometerReading - BeginOdometerReading;
            RentalCharge = (decimal)(dayRate * DaysRented + mileRate * miles);
            
        }
    }
}
