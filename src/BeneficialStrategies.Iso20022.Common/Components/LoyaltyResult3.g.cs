﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for LoyaltyResult3.  ISO2002 ID# _foxFoU7XEeyGi9JAv6wq7Q.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data related to the result of a processed loyalty transaction.
/// </summary>
[DataContract]
[XmlType]
public partial record LoyaltyResult3
{
    #nullable enable
    
    /// <summary>
    /// Account managing the Loyalty.
    /// </summary>
    [DataMember]
    public required LoyaltyAccount3 Account { get; init; } 
    /// <summary>
    /// Amount.
    /// </summary>
    [DataMember]
    public LoyaltyAmount1? Amount { get; init; } 
    /// <summary>
    /// Data sent by the Loyalty server.
    /// </summary>
    [DataMember]
    public LoyaltyServerData1? ServerData { get; init; } 
    /// <summary>
    /// Rebate information.
    /// </summary>
    [DataMember]
    public LoyaltyRebates1? Rebates { get; init; } 
    
    #nullable disable
}
