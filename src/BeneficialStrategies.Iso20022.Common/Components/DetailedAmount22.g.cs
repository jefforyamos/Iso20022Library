﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DetailedAmount22.  ISO2002 ID# _wXx-4ZJREeuuktRxxQZoNQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Breakdown of the transaction amount.
/// </summary>
public partial record DetailedAmount22
{
    #nullable enable
    
    /// <summary>
    /// Type or class of amount.
    /// </summary>
    public required ISO8583AmountTypeCode Type { get; init; } 
    /// <summary>
    /// Additional information to specify the type of amount.
    /// </summary>
    public IsoMax35Text? OtherType { get; init; } 
    /// <summary>
    /// Sign of the amount.
    /// </summary>
    public CreditDebit3Code? CreditDebit { get; init; } 
    /// <summary>
    /// Detailed amount expressed in the transaction currency.
    /// </summary>
    public required IsoImpliedCurrencyAndAmount Amount { get; init; } 
    /// <summary>
    /// Detailed amount expressed in the cardholder billing currency.
    /// </summary>
    public IsoImpliedCurrencyAndAmount? CardholderBillingAmount { get; init; } 
    /// <summary>
    /// Detailed amount expressed in the reconciliation currency. 
    /// </summary>
    public IsoImpliedCurrencyAndAmount? ReconciliationAmount { get; init; } 
    /// <summary>
    /// Short description of the detailed amount.
    /// </summary>
    public IsoMax70Text? Description { get; init; } 
    
    #nullable disable
}
