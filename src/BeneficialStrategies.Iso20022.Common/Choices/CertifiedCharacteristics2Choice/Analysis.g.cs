﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Analysis.  ISO2002 ID# _3DBVNTANEeOKib24wnHaFg.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.CertifiedCharacteristics2Choice;

/// <summary>
/// Analysis of the goods, as proven by the certificate.
/// </summary>
public partial record Analysis : ICertifiedCharacteristics2Choice
{
    public required IsoMax70Text Value { get; init; }
}
