﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AccountStatementData1.  ISO2002 ID# _HJDAdPGgEeiGNursv3uE_g.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Statement information of an account.
/// </summary>
public partial record AccountStatementData1
{
    #nullable enable
    
    /// <summary>
    /// Date the statement is generated.
    /// </summary>
    public IsoISODate? StatementDate { get; init; } 
    /// <summary>
    /// Time the account statement is generated.
    /// </summary>
    public IsoISOTime? StatementTime { get; init; } 
    /// <summary>
    /// Statement information.
    /// </summary>
    public AccountStatementDetails1[] AccountStatement { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
