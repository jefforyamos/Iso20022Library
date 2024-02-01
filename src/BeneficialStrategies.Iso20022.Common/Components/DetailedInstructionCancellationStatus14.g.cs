﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DetailedInstructionCancellationStatus14.  ISO2002 ID# _WrUtJ8T3Eem9aZlimxVUIw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status applying to individual cancellation instructions of a meeting instruction cancellation request message.
/// </summary>
public partial record DetailedInstructionCancellationStatus14
{
    #nullable enable
    
    /// <summary>
    /// Identification of the specific individual instruction cancellation request from the original meeting instruction cancellation request message identified in InstructionType/ InstructionCancellationIdentification, for which the status is provided.
    /// </summary>
    public required IsoMax35Text SingleInstructionCancellationIdentification { get; init; } 
    /// <summary>
    /// Identification of the securities account.
    /// </summary>
    public IsoMax35Text? AccountIdentification { get; init; } 
    /// <summary>
    /// Identification of the subaccount within the safekeeping account.
    /// </summary>
    public IsoMax35Text? SubAccountIdentification { get; init; } 
    /// <summary>
    /// Status of an individual meeting instruction cancellation request.
    /// </summary>
    public required CancellationStatus26Choice_ InstructionCancellationStatus { get; init; } 
    
    #nullable disable
}
