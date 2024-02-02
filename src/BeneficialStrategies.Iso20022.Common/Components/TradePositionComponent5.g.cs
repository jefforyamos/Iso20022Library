﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TradePositionComponent5.  ISO2002 ID# _BmwjgQ1LEeqV4s5SpzR1dQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details of a component report on a trade position.
/// </summary>
[DataContract]
[XmlType]
public partial record TradePositionComponent5
{
    #nullable enable
    
    /// <summary>
    /// Counterparty data details.
    /// </summary>
    [DataMember]
    public ValueList<CounterpartySpecificData24> CounterpartySpecificData { get; init; } = [];
    /// <summary>
    /// Contract and transaction trade data details.
    /// </summary>
    [DataMember]
    public required CommonTradeDataReport38 CommonTradeData { get; init; } 
    /// <summary>
    /// Specifies technical attributes of the message.
    /// </summary>
    [DataMember]
    public TechnicalAttributes1? TechnicalAttributes { get; init; } 
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [DataMember]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
