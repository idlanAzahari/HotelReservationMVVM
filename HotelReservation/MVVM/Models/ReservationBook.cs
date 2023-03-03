using HotelReservation.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation.MVVM.Models
{
    public class ReservationBook
    {
        private readonly List<Reservation> _reservations;

        public ReservationBook()
        {
            _reservations = new List<Reservation>();
        }

        public IEnumerable<Reservation> GetReservationsForUser(string username)
        {
            return _reservations.Where(r => r.UserName == username);
        }

        public void AddReservation(Reservation reservation)
        {
            foreach (Reservation existingReservations in _reservations)
            {
                if(existingReservations.Conflicts(reservation))
                {
                    throw new ReservationConflictExceptions(existingReservations, reservation);
                }
            }
            _reservations.Add(reservation);
        }
    }
}
