﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for CUSIP.  ISO2002 ID# _cH1L5znxEeabspMEjqY5TQ.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentification25Choice;

/// <summary>
/// Committee on Uniform Securities and Identification Procedures (CUSIP). The standards body that created and maintains the securities classification system in the US. The CUSIP is composed of a 9-character number that uniquely identifies a particular security. Non-US securities have a similar number called the CINS number.
/// </summary>
public partial record CUSIP : ISecurityIdentification25Choice
{
    public required IsoCUSIPIdentifier Value { get; init; }
}
