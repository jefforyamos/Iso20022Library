﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ForeignExchange.  ISO2002 ID# _xH-zZSe0Eei12pGEsJIAeQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Derivative3Choice;

/// <summary>
/// Details specific for Foreign exchange.
/// </summary>
public partial record ForeignExchange : IDerivative3Choice
{
    #nullable enable
    /// <summary>
    /// Type of deliverable and non-deliverable forwards, options and swaps contract.	.
    /// </summary>
    public required AssetClassSubProductType19Code ContractSubType { get; init; } 
    #nullable disable
}
