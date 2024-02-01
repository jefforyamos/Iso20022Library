﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for MissingValuationsTransactionData2.  ISO2002 ID# _x29aEVyGEe24CqbZJK5XxA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Detailed information about the outstanding derivatives for which no valuation or outdated valuation has been reported.
/// </summary>
public partial record MissingValuationsTransactionData2
{
    #nullable enable
    
    /// <summary>
    /// Identification of a transaction.
    /// </summary>
    public required TradeTransactionIdentification24 TransactionIdentification { get; init; } 
    /// <summary>
    /// Mark-to-market valuation of the contract, or mark-to-model valuation
    /// </summary>
    public AmountAndDirection106? ValuationAmount { get; init; } 
    /// <summary>
    /// Date and time of the valuation.
    /// </summary>
    public DateAndDateTime2Choice_? ValuationTimeStamp { get; init; } 
    
    #nullable disable
}
