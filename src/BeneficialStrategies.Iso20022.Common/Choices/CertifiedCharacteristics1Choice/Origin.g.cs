﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Origin.  ISO2002 ID# _TnJq6dp-Ed-ak6NoX_4Aeg_568642879.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.CertifiedCharacteristics1Choice;

/// <summary>
/// Country of origin of the goods, as proven by the certificate.
/// </summary>
public partial record Origin : ICertifiedCharacteristics1Choice
{
    public required CountryCode Value { get; init; }
}
