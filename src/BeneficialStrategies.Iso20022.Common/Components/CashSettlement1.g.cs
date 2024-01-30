﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CashSettlement1.  ISO2002 ID# _F6-JkCCpEeWJd9HF2tO7BA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Cash settlement parties and accounts.
/// </summary>
public partial record CashSettlement1
{
    #nullable enable
    
    /// <summary>
    /// Account to credit or debit. When this is an account to debit, this is for the payment of a subscription to an investment fund, a savings plan payment, the purchase of securities or the payment of charges. When this is an account to credit, this is for the payment of an amount as a result of a redemption of investment fund units, the sale of securities, interest and dividend payments. A single account may be specified for all cash movements on the account or cash accounts may be specified for specific types of transactions on the account.
    /// </summary>
    public CashAccount33? CashAccountDetails { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Method of payment other than a cash account.
    /// </summary>
    public PaymentInstrument13? OtherCashSettlementDetails { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
