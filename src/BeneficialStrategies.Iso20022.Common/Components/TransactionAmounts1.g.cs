﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TransactionAmounts1.  ISO2002 ID# _1-7FQESIEeeb1MmUPTrSMw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amounts of the card transaction.
/// </summary>
public partial record TransactionAmounts1
{
    #nullable enable
    
    /// <summary>
    /// Qualifier or type of amount.
    /// ISO 8583:93/2003 bit 24
    /// </summary>
    public TypeOfAmount11Code? AmountQualifier { get; init; } 
    /// <summary>
    /// Actual amount of the transaction.
    /// </summary>
    public TransactionAmount1? TransactionAmount { get; init; } 
    /// <summary>
    /// Present when the cardholder billing currency differs from the transaction currency expressed in the amount of the transaction. It may be populated by the card scheme or an intermediary processor as normally the acceptor does not know the billing currency for which the cardholder will be debited.
    /// </summary>
    public Amount4? CardholderBillingAmount { get; init; } 
    /// <summary>
    /// Amount used for reconciliation. 
    /// Calculated based on the transaction amount, except when the transaction amount is absent. When transaction amount is absent, the reconciliation amount is calculated on the detailed amount field 
    /// </summary>
    public Amount4? ReconciliationAmount { get; init; } 
    /// <summary>
    /// Further details of some or all amounts in the transaction amount. 
    /// </summary>
    public DetailedAmount19? DetailedAmount { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Amount related to the original transaction.
    /// ISO 8583:87 bit 95
    /// ISO 8583:93/2003 bit 30
    /// </summary>
    public OriginalTransactionAmount1? OriginalTransactionAmounts { get; init; } 
    
    #nullable disable
}
