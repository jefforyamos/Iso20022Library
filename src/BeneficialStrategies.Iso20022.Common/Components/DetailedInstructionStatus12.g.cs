﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DetailedInstructionStatus12.  ISO2002 ID# _8bzrB6-nEemJ1NnLPsTFaw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status of an individual instructions of a meeting instruction.
/// </summary>
public partial record DetailedInstructionStatus12
{
    #nullable enable
    
    /// <summary>
    /// Identification of the specific individual instruction from the original meeting instruction message, element InstructionType/ InstructionIdentification, for which the status is provided.
    /// </summary>
    public required IsoMax35Text SingleInstructionIdentification { get; init; } 
    /// <summary>
    /// Identification of the securities account.
    /// </summary>
    public IsoMax35Text? AccountIdentification { get; init; } 
    /// <summary>
    /// Identification of the subaccount within the safekeeping account.
    /// </summary>
    public IsoMax35Text? SubAccountIdentification { get; init; } 
    /// <summary>
    /// Status of an individual meeting instruction.
    /// </summary>
    public required InstructionStatus8Choice_ InstructionStatus { get; init; } 
    
    #nullable disable
}
