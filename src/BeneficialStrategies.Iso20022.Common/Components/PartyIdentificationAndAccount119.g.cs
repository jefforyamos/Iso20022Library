﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PartyIdentificationAndAccount119.  ISO2002 ID# _o7MJQEUqEeSGWeX3z5zSZQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Party and account information.
/// </summary>
[DataContract]
[XmlType]
public partial record PartyIdentificationAndAccount119
{
    #nullable enable
    
    /// <summary>
    /// Identification of the party that legally owns the account.
    /// </summary>
    [DataMember]
    public ValueList<PartyIdentification90> PartyIdentification { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Identification of the account owned by the party.
    /// </summary>
    [DataMember]
    public ValueList<AccountIdentification30> AccountIdentification { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
