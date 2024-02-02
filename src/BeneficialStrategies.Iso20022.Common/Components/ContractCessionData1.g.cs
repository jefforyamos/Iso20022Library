﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ContractCessionData1.  ISO2002 ID# _qkawwLb-Eeu9Cp6InX88Vw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contract cession data in structured form.
/// </summary>
[DataContract]
[XmlType]
public partial record ContractCessionData1
{
    #nullable enable
    
    /// <summary>
    /// The party to which the cession is made.
    /// </summary>
    [DataMember]
    public required TradeParty5 Party { get; init; } 
    /// <summary>
    /// Number of the document under which the cession is made.
    /// </summary>
    [DataMember]
    public IsoMax35Text? DocumentNumber { get; init; } 
    /// <summary>
    /// Date of the document under which the cession is made.
    /// </summary>
    [DataMember]
    public IsoISODate? DocumentDate { get; init; } 
    
    #nullable disable
}
