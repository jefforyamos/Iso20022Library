﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Analysis.  ISO2002 ID# _TnJq69p-Ed-ak6NoX_4Aeg_798600586.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CertifiedCharacteristics1Choice;

/// <summary>
/// Analysis of the goods, as proven by the certificate.
/// </summary>
public partial record Analysis : ICertifiedCharacteristics1Choice
{
    public required IsoMax70Text Value { get; init; }
}
