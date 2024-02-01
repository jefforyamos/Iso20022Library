﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Balance1.  ISO2002 ID# _R8wlrdp-Ed-ak6NoX_4Aeg_1927261078.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Net position of a segregated holding, in a single security, within the overall position held in a securities account. A securities balance is calculated from the sum of securities' receipts minus the sum of securities' deliveries.
/// </summary>
public partial record Balance1
{
    #nullable enable
    
    /// <summary>
    /// Indication that the position is short or long.
    /// </summary>
    public required ShortLong1Code ShortLongIndicator { get; init; } 
    /// <summary>
    /// Total quantity of financial instruments of the balance.
    /// </summary>
    public required BalanceQuantity4Choice_ Quantity { get; init; } 
    
    #nullable disable
}
