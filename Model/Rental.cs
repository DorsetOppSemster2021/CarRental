using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Model
{
    public class Rental
    {
        public int RentalId { get; set; }
        public string CarModel { get; set; }

        public string CarRegistration { get; set; }

        public Rental(int _rentalId, string _carModel, string carRegistration)
        {
            RentalId = _rentalId;
            CarModel = _carModel;
            CarRegistration = carRegistration;
        }

        public Rental()
        {

        }
    }
}
