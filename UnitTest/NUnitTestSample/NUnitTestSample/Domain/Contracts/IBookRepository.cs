using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestSample.Domain.Contracts
{
    public interface IBookRepository
    {
        List<DateTime> GetByDate(DateTime startDate, DateTime endDate);
    }
}
