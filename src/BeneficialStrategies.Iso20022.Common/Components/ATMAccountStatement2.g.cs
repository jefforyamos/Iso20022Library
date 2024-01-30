﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ATMAccountStatement2.  ISO2002 ID# _O9ETgYq8EeSHjtO_wHA7PQ.
//

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Statement information of an account.
/// </summary>
public partial record ATMAccountStatement2
{
    #nullable enable
    
    /// <summary>
    /// Date of the transaction.
    /// </summary>
    public IsoISODate? TransactionDate { get; init; } 
    /// <summary>
    /// Value date of the transaction.
    /// </summary>
    public IsoISODate? ValueDate { get; init; } 
    /// <summary>
    /// Short text to display or print for the statement.
    /// </summary>
    public IsoMax70Text? ShortText { get; init; } 
    /// <summary>
    /// True if credit transaction.
    /// </summary>
    public IsoTrueFalseIndicator? CreditTransaction { get; init; } 
    /// <summary>
    /// Amount of the transaction.
    /// </summary>
    public required IsoImpliedCurrencyAndAmount Amount { get; init; } 
    /// <summary>
    /// Currency of the amount.
    /// </summary>
    public ActiveCurrencyCode? Currency { get; init; } 
    /// <summary>
    /// Alternative text of the statement to print or display.
    /// </summary>
    public IsoMax256Text? LongText { get; init; } 
    
    #nullable disable
}
