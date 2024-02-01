﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for IntermediaryOpeningBalance.  ISO2002 ID# _Szn0AQgHEeSxsfb1OEDVsw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.OpeningBalance3Choice;

/// <summary>
/// Opening balance of this page only. It must be the intermediary closing balance of the previous page (part of the same statement).
/// </summary>
public partial record IntermediaryOpeningBalance : OpeningBalance3Choice_
{
    #nullable enable
    /// <summary>
    /// Quantity expressed as a number, eg, a number of shares.
    /// </summary>
    public required IsoDecimalNumber Unit { get; init; } 
    #nullable disable
}
