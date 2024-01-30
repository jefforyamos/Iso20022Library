﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for OpenInterest1.  ISO2002 ID# _XEpRcLVZEeadLcJesEbkTQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Measure of the current stock of a financial instrument that has been traded on an exchange or cleared via a central counterparty.
/// </summary>
public partial record OpenInterest1
{
    #nullable enable
    
    /// <summary>
    /// Gross notional of product cleared, if applicable.
    /// </summary>
    public required IsoActiveCurrencyAnd24Amount GrossNotionalAmount { get; init; } 
    /// <summary>
    /// Open interest in number of lots, if applicable.
    /// </summary>
    public IsoPositiveNumber? NumberOfLots { get; init; } 
    
    #nullable disable
}
