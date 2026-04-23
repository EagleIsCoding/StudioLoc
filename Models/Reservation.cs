using System;

namespace StudioLoc
{
    public class Reservation
    {
        public int Id { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int GuestCount { get; set; }

        public int UserId { get; set; }

        public int StudioId { get; set; }

        public string ClientName { get; set; }

        public string StudioName { get; set; }
    }
}