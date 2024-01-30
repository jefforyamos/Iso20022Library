﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionDate47.  ISO2002 ID# _Lo7nOEEEEeWVgfuHGaKtRQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies corporate action dates.
/// </summary>
public partial record CorporateActionDate47
{
    #nullable enable
    
    /// <summary>
    /// Date on which the movement is due to take place (cash and/or securities).
    /// </summary>
    public required IDateFormat31Choice PaymentDate { get; init; } 
    /// <summary>
    /// Date/time when calculating economic benefit for a cash amount.
    /// </summary>
    public IDateFormat33Choice? ValueDate { get; init; } 
    /// <summary>
    /// Date/time at which a foreign exchange rate will be determined.
    /// </summary>
    public IDateFormat31Choice? ForeignExchangeRateFixingDate { get; init; } 
    /// <summary>
    /// Date on which a payment can be made, for example, if payment date is a non-business day or to indicate the first payment date of an offer.
    /// </summary>
    public IDateFormat31Choice? EarliestPaymentDate { get; init; } 
    
    #nullable disable
}
