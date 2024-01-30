﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for InstructionProcessingStatus4.  ISO2002 ID# _9DhyV6-nEemJ1NnLPsTFaw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status advising on the processing of the instruction.
/// </summary>
public partial record InstructionProcessingStatus4
{
    #nullable enable
    
    /// <summary>
    /// Status code.
    /// </summary>
    public required Status8Code Status { get; init; } 
    /// <summary>
    /// Additional information about the status.
    /// </summary>
    public IsoMax350Text? AdditionalInformation { get; init; } 
    
    #nullable disable
}
