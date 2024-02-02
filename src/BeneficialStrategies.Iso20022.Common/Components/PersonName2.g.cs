﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PersonName2.  ISO2002 ID# _W138xVB2Eem6LsRj385o5w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies a person via its first name and surname.
/// </summary>
[DataContract]
[XmlType]
public partial record PersonName2
{
    #nullable enable
    
    /// <summary>
    /// First name(s) by which a natural person is known.
    /// </summary>
    [DataMember]
    public required IsoMax350Text Name { get; init; } 
    /// <summary>
    /// Postal address of the party.
    /// </summary>
    [DataMember]
    public PostalAddress26? Address { get; init; } 
    
    #nullable disable
}
