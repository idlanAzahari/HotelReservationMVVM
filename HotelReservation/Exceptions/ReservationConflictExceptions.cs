using HotelReservation.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation.Exceptions
{
    public class ReservationConflictExceptions : Exception
    {
        public Reservation ExistingReservation { get; }
        public Reservation IncomingReservation { get; }
        public ReservationConflictExceptions(Reservation existingReservation, Reservation incomingReservation)
        {
            ExistingReservation = existingReservation;
            IncomingReservation = incomingReservation;
        }

        public ReservationConflictExceptions(string message, Reservation existingReservation, Reservation incomingReservation) : base(message)
        {
            ExistingReservation = existingReservation;
            IncomingReservation = incomingReservation;
        }

        public ReservationConflictExceptions(string message, Exception innerException, Reservation existingReservation, Reservation incomingReservation) : base(message, innerException)
        {
            ExistingReservation = existingReservation;
            IncomingReservation = incomingReservation;
        }

        protected ReservationConflictExceptions(SerializationInfo info, StreamingContext context, Reservation existingReservation, Reservation incomingReservation) : base(info, context)
        {
            ExistingReservation = existingReservation;
            IncomingReservation = incomingReservation;
        }
    }
}
