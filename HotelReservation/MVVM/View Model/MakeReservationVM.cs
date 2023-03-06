using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation.MVVM.View_Model
{
    public class MakeReservationVM : BaseVM
    {
        private string _userName;

        public string UserName
        {
            get { return _userName; }
            set { _userName = value; OnPropertyChanged(nameof(UserName)); }
        }

        private int _floorNumber;

        public int FloorNumber
        {
            get { return _floorNumber; }
            set { _floorNumber = value; OnPropertyChanged(nameof(FloorNumber)); }
        }

        private int _roomNumber;

        public int RoomNumber
        {
            get { return _roomNumber; }
            set { _roomNumber = value; OnPropertyChanged(nameof(RoomNumber)); }
        }

        private DateTime _startTime;

        public DateTime StartTime
        {
            get { return _startTime; }
            set { _startTime = value; OnPropertyChanged(nameof(RoomNumber)); }
        }


        private DateTime _endDate;

        public DateTime EndDate
        {
            get { return _endDate; }
            set { _endDate = value; OnPropertyChanged(nameof(EndDate)); }
        }



    }
}
