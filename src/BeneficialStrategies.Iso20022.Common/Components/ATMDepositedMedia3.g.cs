﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ATMDepositedMedia3.  ISO2002 ID# _r3cB8a4QEeWZgJQOa6iKCQ.
//

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Deposited media put in the safe.
/// </summary>
public partial record ATMDepositedMedia3
{
    #nullable enable
    
    /// <summary>
    /// Type of deposited media.
    /// </summary>
    public required ATMMediaType2Code MediaType { get; init; } 
    /// <summary>
    /// Category of deposited media items.
    /// </summary>
    public ATMMediaType3Code? MediaCategory { get; init; } 
    /// <summary>
    /// Media item that are deposited.
    /// </summary>
    public ATMDepositedMedia2? MediaItems { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
