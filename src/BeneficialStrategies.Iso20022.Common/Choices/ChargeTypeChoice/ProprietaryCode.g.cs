﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ProprietaryCode.  ISO2002 ID# _RIcz1tp-Ed-ak6NoX_4Aeg_-1267403815.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ChargeTypeChoice;

/// <summary>
/// Type of charge is a bilaterally agreed code.
/// </summary>
public partial record ProprietaryCode : IChargeTypeChoice
{
    public required IsoMax4AlphaNumericText Value { get; init; }
}
