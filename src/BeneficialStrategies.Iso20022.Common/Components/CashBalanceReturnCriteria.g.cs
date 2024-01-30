﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CashBalanceReturnCriteria.  ISO2002 ID# _RGqrKtp-Ed-ak6NoX_4Aeg_-1267402961.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the criteria used to report on the cash balance.
/// </summary>
public partial record CashBalanceReturnCriteria
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether the balance type is requested.
    /// </summary>
    public required IsoRequestedIndicator TypeIndicator { get; init; } 
    /// <summary>
    /// Indicates whether the balance status is requested.
    /// </summary>
    public required IsoRequestedIndicator StatusIndicator { get; init; } 
    /// <summary>
    /// Indicates whether the value date is requested.
    /// </summary>
    public required IsoRequestedIndicator ValueDateIndicator { get; init; } 
    /// <summary>
    /// Indicates whether the number of payment is requested.
    /// </summary>
    public required IsoRequestedIndicator NumberOfPaymentsIndicator { get; init; } 
    
    #nullable disable
}
