﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for DataSetAction.  ISO2002 ID# _hAas8aidEeWHO_l3hf2rlA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecuredMarketReport3Choice;

/// <summary>
/// Provides the reason why no transactions are being reported for a money market reporting period.
/// </summary>
public partial record DataSetAction : ISecuredMarketReport3Choice
{
    public required ReportPeriodActivity1Code Value { get; init; }
}
