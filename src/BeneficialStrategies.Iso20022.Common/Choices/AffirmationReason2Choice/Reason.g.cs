﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Reason.  ISO2002 ID# _YFYT8wd3Ee2fOITqoTnSLQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AffirmationReason2Choice;

/// <summary>
/// Specifies the reason of the UnaffirmedStatus.
/// </summary>
public partial record Reason : IAffirmationReason2Choice
{
    #nullable enable
    /// <summary>
    /// Specifies the reason why the instruction/request has a unaffirmed status.
    /// </summary>
    public required IUnaffirmedReason3Choice Code { get; init; } 
    /// <summary>
    /// Provides additional information about the reason in narrative form.
    /// </summary>
    public IsoMax210Text? AdditionalReasonInformation { get; init; } 
    #nullable disable
}
