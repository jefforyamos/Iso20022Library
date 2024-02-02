﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AccountIdentification43.  ISO2002 ID# _SQJWEZcFEee8S7xwGG7Veg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Account information and detailed account holdings information report for corporate action events.
/// </summary>
[DataContract]
[XmlType]
public partial record AccountIdentification43
{
    #nullable enable
    
    /// <summary>
    /// Account where financial instruments are maintained.
    /// </summary>
    [DataMember]
    public required IsoMax35Text SafekeepingAccount { get; init; } 
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [DataMember]
    public PartyIdentification92Choice_? AccountOwner { get; init; } 
    /// <summary>
    /// Location where the financial instruments are/will be safekept.
    /// </summary>
    [DataMember]
    public SafekeepingPlaceFormat8Choice_? SafekeepingPlace { get; init; } 
    /// <summary>
    /// Detailed account holdings information report for a corporate action event.
    /// </summary>
    [DataMember]
    public ValueList<CorporateActionEventAndBalance13> CorporateActionEventAndBalance { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
