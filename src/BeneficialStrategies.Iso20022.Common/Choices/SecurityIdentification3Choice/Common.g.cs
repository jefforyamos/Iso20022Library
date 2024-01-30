﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Common.  ISO2002 ID# _Qd1wlNp-Ed-ak6NoX_4Aeg_1064399423.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentification3Choice;

/// <summary>
/// Identifier of securities issued in Luxembourg. The common code is a 9-digit code that replaces the CEDEL (Clearstream) and Euroclear codes.
/// </summary>
public partial record Common : ISecurityIdentification3Choice
{
    public required IsoEuroclearClearstreamIdentifier Value { get; init; }
}
