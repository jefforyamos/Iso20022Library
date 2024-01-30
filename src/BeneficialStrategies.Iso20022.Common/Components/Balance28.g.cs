﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Balance28.  ISO2002 ID# _WhkGsaybEeupy7O5H7ITjQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Card account balance.
/// </summary>
public partial record Balance28
{
    #nullable enable
    
    /// <summary>
    /// Type of card account balance.
    /// </summary>
    public required BalanceType15Code Type { get; init; } 
    /// <summary>
    /// Other card account balance type.
    /// </summary>
    public IsoMax35Text? OtherType { get; init; } 
    /// <summary>
    /// Amount value.
    /// </summary>
    public required IsoImpliedCurrencyAndAmount Amount { get; init; } 
    /// <summary>
    /// Currency of the account.
    /// </summary>
    public ISO3NumericCurrencyCode? Currency { get; init; } 
    /// <summary>
    /// Indicates whether the value of the balance id positive or negative.
    /// </summary>
    public CreditDebit3Code? CreditDebit { get; init; } 
    /// <summary>
    /// Indicates whether the value of balance is expressed in the currency of the cardholder or not.
    /// True: Balance is expressed in the currency of the cardholder
    /// False: Balance is expressed in a different currency.
    /// </summary>
    public IsoTrueFalseIndicator? CardholderCurrencyIndicator { get; init; } 
    /// <summary>
    /// Date of the balance.
    /// </summary>
    public IsoISODate? BalanceDate { get; init; } 
    
    #nullable disable
}
