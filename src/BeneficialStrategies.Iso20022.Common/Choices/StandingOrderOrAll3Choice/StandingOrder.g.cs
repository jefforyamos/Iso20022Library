﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for StandingOrder.  ISO2002 ID# _ex1mYdcZEeqRFcf2R4bPBw.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.StandingOrderOrAll3Choice;

/// <summary>
/// Identification of single standing orders defined with specific characteristics.
/// </summary>
public partial record StandingOrder : IStandingOrderOrAll3Choice
{
    #nullable enable
    /// <summary>
    /// Unique and unambiguous identification for a standing order, as assigned by the account servicer or the account owner.
    /// </summary>
    public IsoMax35Text? Identification { get; init; } 
    /// <summary>
    /// Business relationship between two entities; one entity is the account owner, the other entity is the account servicer.
    /// </summary>
    public required CashAccount40 Account { get; init; } 
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification6? AccountOwner { get; init; } 
    #nullable disable
}
