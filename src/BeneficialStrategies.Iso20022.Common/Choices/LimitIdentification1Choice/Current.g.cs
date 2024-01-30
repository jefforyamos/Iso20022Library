﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Current.  ISO2002 ID# _73kl0KMgEeCJ6YNENx4h-w_-1610520689.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.LimitIdentification1Choice;

/// <summary>
/// Identification of the current limit.
/// </summary>
public partial record Current : ILimitIdentification1Choice
{
    #nullable enable
    /// <summary>
    /// Identification of a particular cash clearing system.
    /// </summary>
    public ISystemIdentification2Choice? SystemIdentification { get; init; } 
    /// <summary>
    /// Identification of the system member for which the limit is established.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification5? BilateralLimitCounterpartyIdentification { get; init; } 
    /// <summary>
    /// Nature of the risk management limit.
    /// </summary>
    public required ILimitType1Choice Type { get; init; } 
    /// <summary>
    /// Owner of the account which is being queried.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification5? AccountOwner { get; init; } 
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    public IAccountIdentification4Choice? AccountIdentification { get; init; } 
    #nullable disable
}
