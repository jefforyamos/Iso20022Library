﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DetailedInstructionStatus14.  ISO2002 ID# _baIw1_NfEeqRfth943bvEA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status of an individual instructions of a meeting instruction.
/// </summary>
public partial record DetailedInstructionStatus14
{
    #nullable enable
    
    /// <summary>
    /// Identification of the specific individual instruction from the original meeting instruction message element InstructionIdentification, for which the status is provided.
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
    /// Status of the individual meeting instruction.
    /// </summary>
    public required IInstructionStatus10Choice InstructionStatus { get; init; } 
    
    #nullable disable
}
