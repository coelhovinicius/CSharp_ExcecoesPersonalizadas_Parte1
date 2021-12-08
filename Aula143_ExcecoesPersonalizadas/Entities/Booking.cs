/* >>> CLASSE BOOKING <<< */
using System;
namespace Aula143_ExcecoesPersonalizadas.Entities
{
    class Booking
    {
        public int RoomNumber { get;  set; }
        public DateTime CheckIn { get;  set; }
        public DateTime CheckOut { get;  set; }

        public Booking()
        {
        }

        public Booking(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays; // Casting do double TotalDays para inteiro
        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public override string ToString()
        {
            return "Room " + RoomNumber
                + ", check-in: " + CheckIn.ToString("dd/MM/yyyy")
                + ", check-out: " + CheckOut.ToString("dd/MM/yyyy")
                + ", " + Duration() + " nights";
        }
    }
}
