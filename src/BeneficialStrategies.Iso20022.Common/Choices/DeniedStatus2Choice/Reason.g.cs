﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Reason.  ISO2002 ID# _UUc1xtp-Ed-ak6NoX_4Aeg_2072801643.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.DeniedStatus2Choice;

/// <summary>
/// Specifies the reason of the DeniedStatus.
/// </summary>
public partial record Reason : IDeniedStatus2Choice
{
    #nullable enable
    /// <summary>
    /// Specifies the reason why the request has a denied status.
    /// </summary>
    public required IDeniedReason2Choice Code { get; init; } 
    /// <summary>
    /// Provides additional reason information that cannot be provided in a structured field.
    /// </summary>
    public IsoMax210Text? AdditionalReasonInformation { get; init; } 
    #nullable disable
}
