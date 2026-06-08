using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Domain.Enums
{
    //Перечисление статуса заявки 
    public enum ApplicationStatus
    {
        Pending,
        Approved,
        Rejected,
        Cancelled
    }
}
