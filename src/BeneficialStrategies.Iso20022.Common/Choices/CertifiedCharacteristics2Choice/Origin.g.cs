﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Origin.  ISO2002 ID# _3DBVMTANEeOKib24wnHaFg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CertifiedCharacteristics2Choice;

/// <summary>
/// Country of origin of the goods, as proven by the certificate.
/// </summary>
public partial record Origin : ICertifiedCharacteristics2Choice
{
    public required CountryCode Value { get; init; }
}
