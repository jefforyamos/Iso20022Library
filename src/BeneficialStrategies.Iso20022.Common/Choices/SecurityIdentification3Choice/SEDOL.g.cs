﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for SEDOL.  ISO2002 ID# _Qdr_kdp-Ed-ak6NoX_4Aeg_1796754500.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentification3Choice;

/// <summary>
/// Stock Exchange Daily Official List (SEDOL) number. A code used by the London Stock Exchange to identify foreign stocks, especially those that aren't actively traded in the US and don't have a CUSIP number.
/// </summary>
public partial record SEDOL : ISecurityIdentification3Choice
{
    public required IsoSEDOLIdentifier Value { get; init; }
}
