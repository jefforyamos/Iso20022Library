﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for HeadMemberDetails.  ISO2002 ID# _zpIWcCDsEeav65mEytrgaA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.LiquidityPoolMembers1Choice;

/// <summary>
/// Information about head member of liquidity pool.
/// </summary>
public partial record HeadMemberDetails : ILiquidityPoolMembers1Choice
{
    #nullable enable
    /// <summary>
    /// Account identifier.
    /// </summary>
    public required CashAccount24 Account { get; init; } 
    /// <summary>
    /// Account owner identification.
    /// </summary>
    public required FinancialInstitutionIdentification9 AccountOwner { get; init; } 
    #nullable disable
}
