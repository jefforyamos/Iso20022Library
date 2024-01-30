﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionDate62.  ISO2002 ID# _dhQEP7QXEeeKRKrD60ELBQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies corporate action dates.
/// </summary>
public partial record CorporateActionDate62
{
    #nullable enable
    
    /// <summary>
    /// Date/time on which the movement is due to take place (cash and/or securities).
    /// </summary>
    public required IDateFormat43Choice PaymentDate { get; init; } 
    /// <summary>
    /// Date/time when calculating economic benefit for a cash amount.
    /// </summary>
    public IDateFormat46Choice? ValueDate { get; init; } 
    /// <summary>
    /// Date/time at which a foreign exchange rate will be determined.
    /// </summary>
    public IDateFormat43Choice? ForeignExchangeRateFixingDate { get; init; } 
    /// <summary>
    /// Date/time on which a payment can be made, for example, if payment date is a non-business day or to indicate the first payment date of an offer.
    /// </summary>
    public IDateFormat43Choice? EarliestPaymentDate { get; init; } 
    
    #nullable disable
}
