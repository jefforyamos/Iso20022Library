﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CashAccount12.  ISO2002 ID# _SP1Sodp-Ed-ak6NoX_4Aeg_-1055683398.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Account to or from which a cash entry is made.
/// </summary>
public partial record CashAccount12
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    public required ICashAccountIdentification1Choice Identification { get; init; } 
    /// <summary>
    /// Name of the account. It provides an additional means of identification, and is designated by the account servicer in agreement with the account owner.
    /// </summary>
    public required IsoMax35Text Name { get; init; } 
    /// <summary>
    /// Specifies the nature, or use, of the cash account.
    /// </summary>
    public CashAccountType1Code? Type { get; init; } 
    /// <summary>
    /// Specifies the nature, or use, of the cash account.
    /// </summary>
    public IsoExtended350Code? ExtendedType { get; init; } 
    /// <summary>
    /// Medium of exchange of value.
    /// </summary>
    public required ActiveCurrencyCode Currency { get; init; } 
    /// <summary>
    /// Specifies the current state of an account, eg, enabled or deleted.
    /// </summary>
    public required AccountStatus1Code Status { get; init; } 
    
    #nullable disable
}
