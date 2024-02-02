﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for UndertakingAmount3.  ISO2002 ID# _95MIcHltEeG7BsjMvd1mEw_-289979186.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about an amount.
/// </summary>
[DataContract]
[XmlType]
public partial record UndertakingAmount3
{
    #nullable enable
    
    /// <summary>
    /// Amount and currency of the demand.
    /// </summary>
    [DataMember]
    public required IsoActiveCurrencyAndAmount Amount { get; init; } 
    /// <summary>
    /// Additional information concerning the demand amount.
    /// </summary>
    [DataMember]
    public ValueList<IsoMax2000Text> AdditionalInformation { get; init; } = [];
    
    #nullable disable
}
