﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for DataSetAction.  ISO2002 ID# _CA844WEbEe2P-L9DBerEgA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TradeData58Choice;

/// <summary>
/// Where no active instruments are present on a venue, this field should be set so that a valid instrument reference data file can be submitted to ESMA as per daily submission requirements.
/// </summary>
public partial record DataSetAction : TradeData58Choice_
{
    public required ReportPeriodActivity1Code Value { get; init; }
}
