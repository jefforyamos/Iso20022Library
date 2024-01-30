﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionDate65.  ISO2002 ID# _wZOj8bQZEeeKRKrD60ELBQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies corporate action dates.
/// </summary>
public partial record CorporateActionDate65
{
    #nullable enable
    
    /// <summary>
    /// Date/time of the posting (credit or debit) to the account.
    /// </summary>
    public required IDateAndDateTime2Choice PostingDate { get; init; } 
    /// <summary>
    /// Date/time when calculating economic benefit for a cash amount.
    /// </summary>
    public IDateAndDateTime2Choice? ValueDate { get; init; } 
    /// <summary>
    /// Date/time at which a foreign exchange rate will be determined.
    /// </summary>
    public IDateAndDateTime2Choice? ForeignExchangeRateFixingDate { get; init; } 
    /// <summary>
    /// Date/time on which a payment can be made, for example, if the payment date is a non-business day or to indicate the first payment date of an offer.
    /// </summary>
    public IDateAndDateTime2Choice? EarliestPaymentDate { get; init; } 
    /// <summary>
    /// Date on which the distribution is due to take place (cash and/or securities).
    /// </summary>
    public IDateAndDateTime2Choice? PaymentDate { get; init; } 
    
    #nullable disable
}
