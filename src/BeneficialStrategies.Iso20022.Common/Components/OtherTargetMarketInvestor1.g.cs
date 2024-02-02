﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for OtherTargetMarketInvestor1.  ISO2002 ID# _8aPsYDcLEeiIxKQErQxblg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Investor type target market.
/// </summary>
[DataContract]
[XmlType]
public partial record OtherTargetMarketInvestor1
{
    #nullable enable
    
    /// <summary>
    /// Type of investor.
    /// </summary>
    [DataMember]
    public IsoMax35Text? InvestorType { get; init; } 
    /// <summary>
    /// Choice of formats for the specification of whether the product is aimed at the type of investor.
    /// </summary>
    [DataMember]
    public TargetMarket3Choice_? Target { get; init; } 
    /// <summary>
    /// Additional information about the target market and the investor type.
    /// </summary>
    [DataMember]
    public AdditionalInformation15? AdditionalInformation { get; init; } 
    
    #nullable disable
}
