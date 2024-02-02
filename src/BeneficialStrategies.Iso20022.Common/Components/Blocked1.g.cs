﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Blocked1.  ISO2002 ID# _K0XSoBHCEeKVqeHljBM1MQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies information about blocked accounts.
/// </summary>
[DataContract]
[XmlType]
public partial record Blocked1
{
    #nullable enable
    
    /// <summary>
    /// Specifies the order type for which the account is blocked.
    /// </summary>
    [DataMember]
    public ValueList<FundOrderType1Choice_> OrderType { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Indicates whether the account is blocked.
    /// </summary>
    [DataMember]
    public required IsoYesNoIndicator Blocked { get; init; } 
    /// <summary>
    /// Specifies the reason the account is blocked.
    /// </summary>
    [DataMember]
    public BlockedReason1Choice_? Reason { get; init; } 
    
    #nullable disable
}
