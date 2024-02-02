﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ContentInformationType6.  ISO2002 ID# _6DM4sQvFEeKzJ69IWwzB9Q.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// General cryptographic message syntax (CMS) containing authenticated data.
/// </summary>
[DataContract]
[XmlType]
public partial record ContentInformationType6
{
    #nullable enable
    
    /// <summary>
    /// Type of data protection.
    /// </summary>
    [DataMember]
    public required ContentType1Code ContentType { get; init; } 
    /// <summary>
    /// Data protection by a message authentication code (MAC).
    /// </summary>
    [DataMember]
    public ValueList<AuthenticatedData2> AuthenticatedData { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
