﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for PortugueseNCCIdentification.  ISO2002 ID# _TC8Kltp-Ed-ak6NoX_4Aeg_1989940211.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ClearingSystemMemberIdentification2Choice;

/// <summary>
/// Portuguese National Clearing Code - identifies Portuguese financial institutions on the Portuguese national clearing system.
/// </summary>
public partial record PortugueseNCCIdentification : IClearingSystemMemberIdentification2Choice
{
    public required IsoPortugueseNCCIdentifier Value { get; init; }
}
