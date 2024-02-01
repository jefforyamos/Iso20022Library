﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DefaultAccountDetails1.  ISO2002 ID# _7rRPoCDmEeav65mEytrgaA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details about successor account for automated default funds transfer.
/// </summary>
public partial record DefaultAccountDetails1
{
    #nullable enable
    
    /// <summary>
    /// Account owner identification.
    /// </summary>
    public required FinancialInstitutionIdentification9 AccountOwner { get; init; } 
    /// <summary>
    /// Account identification.
    /// </summary>
    public required CashAccount24 Account { get; init; } 
    /// <summary>
    /// Information about time and event fund transfer.
    /// </summary>
    public DailyFundTransfer1Choice_? DailyFundTransfer { get; init; } 
    
    #nullable disable
}
