﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SettlementDetails88.  ISO2002 ID# _nKLWIWQMEeSTN56gbbyx2g.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Parameters which explicitly state the conditions that must be fulfilled before a particular transaction of a financial instrument can be settled. These parameters are defined by the instructing party in compliance with settlement rules in the market the transaction will settle in.
/// </summary>
[DataContract]
[XmlType]
public partial record SettlementDetails88
{
    #nullable enable
    
    /// <summary>
    /// Indicates the date as known by the two parties to be used for matching purposes when settlement of securities occurs.
    /// </summary>
    [DataMember]
    public required IsoISODateTime TradeDate { get; init; } 
    /// <summary>
    /// Provides details on either the delivering or receiving settlement parties.
    /// </summary>
    [DataMember]
    public SettlementParties3Choice_? SettlementParties { get; init; } 
    /// <summary>
    /// Indicates the collateral ownership.
    /// </summary>
    [DataMember]
    public required CollateralOwnership1 CollateralOwnership { get; init; } 
    
    #nullable disable
}
