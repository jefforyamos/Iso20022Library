﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ClearingAccount1.  ISO2002 ID# _zZQ3oZXeEeaEh9L5Y0ZaKQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Operational construct of a central counterparty that defines the relationship between collateral, margin and position accounts and upon default of a clearing member defines the segregation of losses on positions and assets held in such accounts.
/// </summary>
public partial record ClearingAccount1
{
    #nullable enable
    
    /// <summary>
    /// Indicates the type of clearing account.
    /// </summary>
    public required ClearingAccountType3Code AccountType { get; init; } 
    /// <summary>
    /// Operational construct used by a central counterparty to record ownership of assets posted as collateral by clearing members to meet their obligations at the central counterparty.
    /// </summary>
    public CollateralAccount5[] CollateralAccountOwner { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
