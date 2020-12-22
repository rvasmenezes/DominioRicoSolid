using RoomBooking.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomBooking.Domain.Entities
{
    public class Book
    {
        public Book(
            Guid room,            
            DateTime startTime,
            DateTime endTime
            )
        {
            this.Id = Guid.NewGuid();
            this.Room = room;
            this.Status = EBookStatus.InProgress;
            this.StartTime = startTime;
            this.EndTime = endTime;

        }

        public Guid Id { get; set; }
        public Guid Room { get; set; }
        public EBookStatus Status { get; set; }
        public DateTime StartTime{ get; set; }
        public DateTime EndTime { get; set; }

        public void MarkAsCompleted()
        {
            this.Status = EBookStatus.Completed;
        }

        public void MarkAsCanceled()
        {
            this.Status = EBookStatus.Canceled;
        }
    }
}
