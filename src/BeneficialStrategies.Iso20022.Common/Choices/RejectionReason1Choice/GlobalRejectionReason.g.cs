﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for GlobalRejectionReason.  ISO2002 ID# _RJ8oodp-Ed-ak6NoX_4Aeg_1042217735.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.RejectionReason1Choice;

/// <summary>
/// Rejection reason that applies to the whole report.
/// </summary>
public partial record GlobalRejectionReason : IRejectionReason1Choice
{
    #nullable enable
    /// <summary>
    /// Detailed description of the rejection.
    /// </summary>
    public required IsoMax140Text Description { get; init; } 
    #nullable disable
}
