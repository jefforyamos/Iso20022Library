﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CashAccount201.  ISO2002 ID# _tkpXgYirEeefvMoXmllHqg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of an account.
/// </summary>
public partial record CashAccount201
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification of the account between the account owner and the account servicer.
    /// </summary>
    public required AccountIdentificationAndName5 Identification { get; init; } 
    /// <summary>
    /// Institution that maintains the records where the account is held.
    /// </summary>
    public FinancialInstitutionIdentification15? AccountServicer { get; init; } 
    
    #nullable disable
}
