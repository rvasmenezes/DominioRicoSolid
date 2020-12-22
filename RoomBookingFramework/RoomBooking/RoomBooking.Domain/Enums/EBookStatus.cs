using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomBooking.Domain.Enums
{
    public enum EBookStatus
    {
        InProgress = 1,
        Reserved = 2, 
        InUse = 3,
        Canceled = 4,
        Completed = 5
    }
}
