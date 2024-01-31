﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CashMovement2.  ISO2002 ID# _UJIWkNp-Ed-ak6NoX_4Aeg_908062376.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the cash movement.
/// </summary>
public partial record CashMovement2
{
    #nullable enable
    
    /// <summary>
    /// Cash amount.
    /// </summary>
    public required IsoActiveCurrencyAndAmount Amount { get; init; } 
    /// <summary>
    /// Provides information about the account which is debited/credited.
    /// </summary>
    public IReadOnlyCollection<CashAccount19> AccountDetails { get; init; } = [];
    
    #nullable disable
}
