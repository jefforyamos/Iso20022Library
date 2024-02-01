﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ModificationRequested.  ISO2002 ID# _dsyaiDi8Eeydid5dcNPKvg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus92Choice;

/// <summary>
/// Modification request from your counterparty for this transaction is pending waiting for your cancellation request or your consent.
/// </summary>
public partial record ModificationRequested : ProcessingStatus92Choice_
{
    #nullable enable
    /// <summary>
    /// Proprietary identification of the reason related to a status.
    /// </summary>
    public GenericIdentification47? Reason { get; init; } 
    /// <summary>
    /// Provides additional information about the processed instruction.
    /// </summary>
    public IsoRestrictedFINXMax210Text? AdditionalReasonInformation { get; init; } 
    #nullable disable
}
