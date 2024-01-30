﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for OriginalBusinessInstruction2.  ISO2002 ID# _XaC4U_WfEemtd4wHZYvFUQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Unique identification, as assigned by the original requestor, to unambiguously identify the business instruction message.
/// </summary>
public partial record OriginalBusinessInstruction2
{
    #nullable enable
    
    /// <summary>
    /// Point to point reference, as assigned by the original initiating party, to unambiguously identify the original instruction message.
    /// </summary>
    public IsoRestrictedFINXMax35Text? MessageIdentification { get; init; } 
    /// <summary>
    /// Specifies the instruction message name identifier to which the message refers.
    /// </summary>
    public IsoRestrictedFINXMax35Text? MessageNameIdentification { get; init; } 
    
    #nullable disable
}
