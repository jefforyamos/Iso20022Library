﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PaymentAccount2.  ISO2002 ID# _w9aBcO19Eei-V5h0ja04AA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data related to an account.
/// </summary>
public partial record PaymentAccount2
{
    #nullable enable
    
    /// <summary>
    /// Currency of a Payment Account.
    /// </summary>
    public ActiveCurrencyCode? Currency { get; init; } 
    /// <summary>
    /// Balance of a Payment Account
    /// </summary>
    public IsoImpliedCurrencyAndAmount? CurrentBalance { get; init; } 
    /// <summary>
    /// Detail of Acquirer.
    /// </summary>
    public Acquirer9? PaymentAcquirerData { get; init; } 
    
    #nullable disable
}
