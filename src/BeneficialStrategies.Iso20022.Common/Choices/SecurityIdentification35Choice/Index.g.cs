﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Index.  ISO2002 ID# _ZmtSVQ1HEeqV4s5SpzR1dQ.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentification35Choice;

/// <summary>
/// Index name where the underlying is an index.
/// </summary>
public partial record Index : ISecurityIdentification35Choice
{
    public required BenchmarkCurveName3Code Value { get; init; }
}
