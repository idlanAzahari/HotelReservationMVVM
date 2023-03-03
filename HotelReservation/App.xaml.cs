using HotelReservation.Exceptions;
using HotelReservation.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace HotelReservation
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            Hotel hotel = new Hotel("Modulus INN");
            try
            {
                hotel.MakeReservation(new Reservation(
                new RoomID(1, 20), new DateTime(2020, 10, 20), new DateTime(2020, 10, 25), "Idlan Azahari"
                ));

                hotel.MakeReservation(new Reservation(
                    new RoomID(1, 20), new DateTime(2020, 10, 20), new DateTime(2020, 10, 28), "John Smith"
                    ));
            }
            catch (ReservationConflictExceptions ex)
            {

                
            }
            

            

            IEnumerable<Reservation> reservations = hotel.GetReservationsForUser("Idlan Azahari"); //hmmm menarikk


            base.OnStartup(e);
        }
    }
}
