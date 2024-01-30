﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ATMTransactionAmounts7.  ISO2002 ID# _3ACQ0a19EeWMg5rOByfExw.
//

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Additional amount that may be displayed to the customer, for instance the daily limit or the daily balance for the service.
/// </summary>
public partial record ATMTransactionAmounts7
{
    #nullable enable
    
    /// <summary>
    /// Type of amount.
    /// </summary>
    public required IsoMax35Text Type { get; init; } 
    /// <summary>
    /// Amount value.
    /// </summary>
    public required IsoImpliedCurrencyAndAmount Amount { get; init; } 
    /// <summary>
    /// Currency of the amount.
    /// </summary>
    public ActiveCurrencyCode? Currency { get; init; } 
    /// <summary>
    /// Description of the amount that may be provided to the customer.
    /// </summary>
    public IsoMax70Text? Label { get; init; } 
    
    #nullable disable
}
