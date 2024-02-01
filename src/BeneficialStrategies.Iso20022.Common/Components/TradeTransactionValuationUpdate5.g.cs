﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TradeTransactionValuationUpdate5.  ISO2002 ID# _HDsGQQ1LEeqV4s5SpzR1dQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details of a valuation update report on a trade transaction.
/// </summary>
public partial record TradeTransactionValuationUpdate5
{
    #nullable enable
    
    /// <summary>
    /// Trade transaction data details.
    /// </summary>
    public CounterpartySpecificData23[] CounterpartySpecificData { get; init; } = [];
    /// <summary>
    /// Trade transaction data details.
    /// </summary>
    public CommonTradeDataReport36? CommonTradeData { get; init; } 
    /// <summary>
    /// Specifies technical attributes of the message.
    /// </summary>
    public TechnicalAttributes1? TechnicalAttributes { get; init; } 
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    public SupplementaryData1[] SupplementaryData { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
