﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AdditionalInformation24.  ISO2002 ID# _2xhasLzhEeivTd4NUfCi2g.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Unless bilaterally agreed between the Sender and the Receiver, additional information must not contain information that can be provided in a structured field.
/// </summary>
public partial record AdditionalInformation24
{
    #nullable enable
    
    /// <summary>
    /// Provides additional information on the collateral instruction.
    /// </summary>
    public IsoMax350Text? CollateralInstruction { get; init; } 
    /// <summary>
    /// Narrative information visible to other parties.
    /// </summary>
    public IsoMax350Text? Note { get; init; } 
    
    #nullable disable
}
