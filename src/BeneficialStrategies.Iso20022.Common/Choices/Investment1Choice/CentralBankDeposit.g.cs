﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for CentralBankDeposit.  ISO2002 ID# _UYA14LJVEeaYqc4G3TTwhA.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.Investment1Choice;

/// <summary>
/// Indicates that the bank deposit is placed at a central bank.
/// </summary>
public partial record CentralBankDeposit : IInvestment1Choice
{
    #nullable enable
    /// <summary>
    /// Date on which the deposit matures.
    /// </summary>
    public required IsoISODate MaturityDate { get; init; } 
    /// <summary>
    /// Specifies the value of the deposit.
    /// </summary>
    public required IsoActiveCurrencyAndAmount Value { get; init; } 
    /// <summary>
    /// Identifies the legal entity that takes the deposit.
    /// </summary>
    public required IsoLEIIdentifier CounterpartyIdentification { get; init; } 
    #nullable disable
}
