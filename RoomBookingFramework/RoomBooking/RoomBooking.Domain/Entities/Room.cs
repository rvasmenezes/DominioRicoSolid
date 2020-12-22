using RoomBooking.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomBooking.Domain.Entities
{
    public class Room
    {

        public Room(DateTime startDate, DateTime endDate, string title)
        {

            AssertionConcern.AssertArgumentNotNull(startDate, "Horário de início inválido");
            AssertionConcern.AssertArgumentNotNull(endDate, "Horário de término inválido");
            AssertionConcern.AssertArgumentLength(title, 40, "O nome da sala deve conter no máximo 40");

            this.Id = Guid.NewGuid();
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.Title = Title;

        }

        public Guid Id { get; private set; }
        public DateTime StartDate { get; private set; }
        public DateTime EndDate{ get; private set; }
        public string Title { get; set; }
    }
}
