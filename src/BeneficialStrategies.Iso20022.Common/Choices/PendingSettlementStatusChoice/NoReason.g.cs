﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for NoReason.  ISO2002 ID# _U1POqNp-Ed-ak6NoX_4Aeg_-1628599640.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PendingSettlementStatusChoice;

/// <summary>
/// Indicates that there is no reason available or to report.
/// </summary>
public partial record NoReason : PendingSettlementStatusChoice_
{
    public required NoReasonCode Value { get; init; }
}
