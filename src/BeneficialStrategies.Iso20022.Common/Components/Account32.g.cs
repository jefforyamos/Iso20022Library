﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Account32.  ISO2002 ID# _rRiDQZS_EemqYPWMBuVawg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Business relationship between two entities; one entity is the account owner, the other entity is the account servicer.
/// </summary>
[DataContract]
[XmlType]
public partial record Account32
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [DataMember]
    public IsoMax35Text? Identification { get; init; } 
    /// <summary>
    /// Institution servicing an account and assigning the account identifier to the account owner.
    /// </summary>
    [DataMember]
    public required PartyIdentification125Choice_ AccountServicer { get; init; } 
    
    #nullable disable
}
