﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TradeNewTransaction10.  ISO2002 ID# _VrZzEw1KEeqV4s5SpzR1dQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details of a new trade transaction report.
/// </summary>
public partial record TradeNewTransaction10
{
    #nullable enable
    
    /// <summary>
    /// Data specific to counterparties and related fields.
    /// </summary>
    public IReadOnlyCollection<CounterpartySpecificData24> CounterpartySpecificData { get; init; } = [];
    /// <summary>
    /// Data specifically related to transaction.
    /// </summary>
    public required CommonTradeDataReport38 CommonTradeData { get; init; } 
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
