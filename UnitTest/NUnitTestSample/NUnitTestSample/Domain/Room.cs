using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit.Sdk;

namespace NUnitTestSample.Domain
{
    
    public class Room
    {

        public Room(string name)
        {

            if (string.IsNullOrEmpty(name))
                throw new Exception("Nome inválido");

            this.Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public void Book(DateTime startDate, DateTime endDate, List<DateTime> books)
        {

            if (books.Contains(startDate))
            {

            }
        }
    }
}
