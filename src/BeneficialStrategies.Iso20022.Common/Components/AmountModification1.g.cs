﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AmountModification1.  ISO2002 ID# _hZ5eIA4qEeK3IMoVvcTkkg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the type of change to an amount.
/// </summary>
public partial record AmountModification1
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of change.
    /// </summary>
    public Modification1Code? ModificationCode { get; init; } 
    /// <summary>
    /// Amount.
    /// </summary>
    public required IsoImpliedCurrencyAndAmount Amount { get; init; } 
    
    #nullable disable
}
