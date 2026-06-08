using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Domain.Enums
{
    //Перичисление типа карты 
    public enum TheIssuingBank
    {
        DebitCardMir = 6352,
        CreditCardMir = 3122,
        DebitCardVisa = 63524,
        CreditCardVisa = 31224,
        DebitCardMasterCard = 63525,
        CreditCardMasterCard = 31225
    }
}
