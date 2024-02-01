﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Common.  ISO2002 ID# _B03cDVhxEeWDI58xzGOTTQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentification22Choice;

/// <summary>
/// Identifier of securities issued in Luxembourg. The common code is a 9-digit code that replaces the CEDEL (Clearstream) and Euroclear codes.
/// </summary>
public partial record Common : SecurityIdentification22Choice_
{
    public required IsoEuroclearClearstreamIdentifier Value { get; init; }
}
