﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ExtendedParty6.  ISO2002 ID# _2_l84RRlEeOKWo1NF21OVw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Other type of party.
/// </summary>
[DataContract]
[XmlType]
public partial record ExtendedParty6
{
    #nullable enable
    
    /// <summary>
    /// Other type of party's role.
    /// </summary>
    [DataMember]
    public required IsoExtended350Code ExtendedPartyRole { get; init; } 
    /// <summary>
    /// Detailed ownership information about a party.
    /// </summary>
    [DataMember]
    public required InvestmentAccountOwnershipInformation9 OtherPartyDetails { get; init; } 
    
    #nullable disable
}
