﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _QJkwwtp-Ed-ak6NoX_4Aeg_1773004320.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ServiceLevel2Choice;

/// <summary>
/// Identification of a pre-agreed level of service between the parties in a coded form.
/// </summary>
public partial record Code : ServiceLevel2Choice_
{
    public required ServiceLevel1Code Value { get; init; }
}
