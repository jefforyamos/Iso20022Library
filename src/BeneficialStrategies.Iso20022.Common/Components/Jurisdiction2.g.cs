﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Jurisdiction2.  ISO2002 ID# _uh9kAMVaEeuips4fuphvoQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains information that identifies or is specific to a transaction jurisdiction.
/// </summary>
public partial record Jurisdiction2
{
    #nullable enable
    
    /// <summary>
    /// When true, indicates the transaction is considered to be domestic.
    /// </summary>
    public IsoTrueFalseIndicator? DomesticIndicator { get; init; } 
    /// <summary>
    /// Identifies the reason the transaction is considered to be domestic or non-domestic.
    /// </summary>
    public IsoMax35Text? DomesticQualification { get; init; } 
    
    #nullable disable
}
