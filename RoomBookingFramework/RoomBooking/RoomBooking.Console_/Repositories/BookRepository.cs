﻿using RoomBooking.Domain.Contracts;
using RoomBooking.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomBooking.Console_.Repositories
{
    public class BookRepository : IBookRepository
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IList<Book> GetBooksByDateRange(DateTime startDate, DateTime endDate)
        {
            throw new NotImplementedException();
        }
    }
}
