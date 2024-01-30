﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TradeTransactionEarlyTermination5.  ISO2002 ID# _41hXYA1KEeqV4s5SpzR1dQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details of an early termination report on a trade transaction.
/// </summary>
public partial record TradeTransactionEarlyTermination5
{
    #nullable enable
    
    /// <summary>
    /// Counterparty data details.
    /// </summary>
    // public IReadOnlyCollection<CounterpartySpecificData22> CounterpartySpecificData { get; init; }
    /// <summary>
    /// Trade transaction data details.
    /// </summary>
    public required CommonTradeDataReport35 CommonTradeData { get; init; } 
    /// <summary>
    /// Specifies technical attributes of the message.
    /// </summary>
    public TechnicalAttributes1? TechnicalAttributes { get; init; } 
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    public SupplementaryData1? SupplementaryData { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
