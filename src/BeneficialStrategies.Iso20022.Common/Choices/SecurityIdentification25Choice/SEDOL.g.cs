﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for SEDOL.  ISO2002 ID# _cH1L5TnxEeabspMEjqY5TQ.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentification25Choice;

/// <summary>
/// Stock Exchange Daily Official List (SEDOL) number. A code used by the London Stock Exchange to identify foreign stocks, especially those that aren't actively traded in the US and don't have a CUSIP number.
/// </summary>
public partial record SEDOL : ISecurityIdentification25Choice
{
    public required IsoSEDOLIdentifier Value { get; init; }
}
