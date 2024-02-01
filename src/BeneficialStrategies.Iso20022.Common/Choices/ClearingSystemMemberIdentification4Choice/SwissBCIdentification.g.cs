﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for SwissBCIdentification.  ISO2002 ID# _VwSCa7NIEeejueAciesPMA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ClearingSystemMemberIdentification4Choice;

/// <summary>
/// Swiss Bank Code - identifies Swiss institutions on the Swiss national clearing system.
/// </summary>
public partial record SwissBCIdentification : ClearingSystemMemberIdentification4Choice_
{
    public required IsoSwissBCIdentifier Value { get; init; }
}
