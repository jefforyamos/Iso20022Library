﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for SingleNameCreditDefaultSwap.  ISO2002 ID# _xSzjUSe0Eei12pGEsJIAeQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CreditDefaultSwapsDerivative4Choice;

/// <summary>
/// A credit default swap on a single name instrument.
/// </summary>
public partial record SingleNameCreditDefaultSwap : CreditDefaultSwapsDerivative4Choice_
{
    #nullable enable
    /// <summary>
    /// Reference entity of a single name credit default swap (CDS) or a derivative on single name CDS.
    /// </summary>
    public required IsoTrueFalseIndicator SovereignIssuer { get; init; } 
    /// <summary>
    /// Reference entity of a single name credit default swap (CDS) or a derivative on single name credit default swap (CDS).
    /// </summary>
    public DerivativePartyIdentification1Choice_? ReferenceParty { get; init; } 
    /// <summary>
    /// Currency in which the notional is denominated.
    /// </summary>
    public required ActiveOrHistoricCurrencyCode NotionalCurrency { get; init; } 
    #nullable disable
}
