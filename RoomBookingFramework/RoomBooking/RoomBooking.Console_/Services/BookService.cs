using RoomBooking.Domain.Contracts.Services;
using RoomBooking.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomBooking.Console_.Services
{
    public class BookService : IBookService
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void PlaceBook(DateTime startDate, DateTime endDate, Guid room)
        {
            var book = new Book(room, startDate, endDate);
            book.MarkAsCompleted();
            //bookRepository.Save(book);

        }
    }
}
