using System;
using System.Collections.Generic;
using CarRental.Model;
using System.Linq;
namespace CarRental
{
    class Program
    {
        static void Main(string[] args)
        {
            CarRentalItem carRentalItem = new CarRentalItem();

            carRentalItem.ListOfCarRentals.Add(new Rental(5, "Ferrari", "a1234"));
            carRentalItem.ListOfCarRentals.Add(new Rental(6, "Audi", "a1234"));
            carRentalItem.ListOfCarRentals.Add(new Rental(7, "BMW", "a1234"));

           

            // carRentalItem.ListOfCarRentals.Sort(x => x.CarRegistration)

            //  carRentalItem.DisplayRentals();
            Console.WriteLine("===========================================");
            Rental newRental = new Rental();
            Console.WriteLine("Enter Car Rental Id");

            // newRental.RentalId =  Int32.Parse(Console.ReadLine());
            newRental.RentalId =  Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Car Rental Model");

            newRental.CarModel = Console.ReadLine();


            Console.WriteLine("Enter Car Rental Reg");

            newRental.CarRegistration = Console.ReadLine();


            carRentalItem.ListOfCarRentals.Add(newRental);


            carRentalItem.DisplayRentals();

        }
    }
}
