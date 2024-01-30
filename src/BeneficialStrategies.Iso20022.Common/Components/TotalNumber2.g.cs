﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TotalNumber2.  ISO2002 ID# _JaoZgygdEey2k_sfZmJz4g.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Settlement transaction numbering information.
/// </summary>
public partial record TotalNumber2
{
    #nullable enable
    
    /// <summary>
    /// Sequential number of the instruction in a range of linked settlement instructions.
    /// </summary>
    public required IsoMax6NumericText CurrentInstructionNumber { get; init; } 
    /// <summary>
    /// Total number of settlement instructions that are linked together.
    /// </summary>
    public required IsoMax6NumericText TotalOfLinkedInstructions { get; init; } 
    
    #nullable disable
}
