﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Amount18.  ISO2002 ID# _XCtkkayeEeuupt0UCH5uiw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Describes each adjustment made to the original price.
/// </summary>
public partial record Amount18
{
    #nullable enable
    
    /// <summary>
    /// Code that describes the type of amount or fee.
    /// </summary>
    public CarRentalServiceType2Code? Type { get; init; } 
    /// <summary>
    /// Description of other type of amount or fee.
    /// </summary>
    public IsoMax35Text? OtherType { get; init; } 
    /// <summary>
    /// Contains the amount.
    /// </summary>
    public IsoImpliedCurrencyAndAmount? Amount { get; init; } 
    /// <summary>
    /// Indicates whether or not the amount is a credit or debit. 
    /// </summary>
    public CreditDebit3Code? CreditDebit { get; init; } 
    /// <summary>
    /// Indicates whether or not the customer was notified about additional amounts. 
    /// </summary>
    public IsoTrueFalseIndicator? CustomerNotifiedIndicator { get; init; } 
    
    #nullable disable
}
