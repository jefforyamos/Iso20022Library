﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for OtherAmount3.  ISO2002 ID# _e9mKMZzHEembF9M4GR6EAA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amount pertaining to a transaction.
/// </summary>
public partial record OtherAmount3
{
    #nullable enable
    
    /// <summary>
    /// Type of amount.
    /// </summary>
    public required GenericIdentification1 Type { get; init; } 
    /// <summary>
    /// Currency and amount.
    /// </summary>
    public required IsoActiveCurrencyAndAmount Amount { get; init; } 
    
    #nullable disable
}
