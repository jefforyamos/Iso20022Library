﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionSD18.  ISO2002 ID# _LJFb4b5ZEeexmbB7KsjCwA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action details.
/// </summary>
[DataContract]
[XmlType]
public partial record CorporateActionSD18
{
    #nullable enable
    
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    [DataMember]
    public IsoMax350Text? PlaceAndName { get; init; } 
    /// <summary>
    /// DTC generated number to distinguish between the series of lotteries run against a particular redemption.
    /// </summary>
    [DataMember]
    public IsoMax3NumericText? LotterySequenceNumber { get; init; } 
    
    #nullable disable
}
