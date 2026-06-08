using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Domain.Enums
{
    //Перечисление типа депозита
    public enum TypeOfDeposit
    {
        NoDepositsAndNoWithdraawals,
        NoDepositWithPartialWithdrawal,
        WithAndWithoutDeposits,
        WithReplenishmentAndPartialWithdrawal
    }
}
