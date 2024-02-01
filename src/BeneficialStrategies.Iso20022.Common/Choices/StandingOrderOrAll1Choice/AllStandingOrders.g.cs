﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for AllStandingOrders.  ISO2002 ID# _790-0KMgEeCJ6YNENx4h-w_1737485731.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.StandingOrderOrAll1Choice;

/// <summary>
/// Identification of all standing orders defined with specific characteristics.
/// </summary>
public partial record AllStandingOrders : StandingOrderOrAll1Choice_
{
    #nullable enable
    /// <summary>
    /// Business relationship between two entities; one entity is the account owner, the other entity is the account servicer.|.
    /// </summary>
    public required CashAccount24 Account { get; init; } 
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification5? AccountOwner { get; init; } 
    #nullable disable
}
