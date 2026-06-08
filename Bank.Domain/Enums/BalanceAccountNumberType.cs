using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Domain.Enums
{
    //Перечисление типа балансового номера счета
    public enum BalanceAccountNumberType
    {
        Debit = 40817,
        SavingsAccountOnDemand = 42301,
        UrgentSavingsAccount = 42302,
        ShortTermCreditAccount = 45502,
        LongTermCreditAccount = 45503
    }
}
