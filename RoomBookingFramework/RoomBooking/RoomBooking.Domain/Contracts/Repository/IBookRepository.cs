using RoomBooking.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomBooking.Domain.Contracts
{
    public interface IBookRepository : IDisposable
    {
        IList<Book> GetBooksByDateRange(DateTime startDate, DateTime endDate);
    }
}
