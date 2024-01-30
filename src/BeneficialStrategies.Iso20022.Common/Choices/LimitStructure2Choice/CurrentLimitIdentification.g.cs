﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for CurrentLimitIdentification.  ISO2002 ID# __vDiY249EeiU9cctagi5ow.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.LimitStructure2Choice;

/// <summary>
/// Identification of the current limit.
/// </summary>
public partial record CurrentLimitIdentification : ILimitStructure2Choice
{
    #nullable enable
    /// <summary>
    /// Identification of a particular cash clearing system.
    /// </summary>
    public ISystemIdentification2Choice? SystemIdentification { get; init; } 
    /// <summary>
    /// Identification of the system member for which the limit is established.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification6? BilateralLimitCounterpartyIdentification { get; init; } 
    /// <summary>
    /// Nature of the risk management limit.
    /// </summary>
    public required ILimitType1Choice Type { get; init; } 
    /// <summary>
    /// Owner of the account which is being queried.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification6? AccountOwner { get; init; } 
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    public IAccountIdentification4Choice? AccountIdentification { get; init; } 
    #nullable disable
}
