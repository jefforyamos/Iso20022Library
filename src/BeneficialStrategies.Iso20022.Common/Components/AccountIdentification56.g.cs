﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AccountIdentification56.  ISO2002 ID# _bKof5-5-Eeqc-LCjwLsUVg.
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
public partial record AccountIdentification56
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
    public PartyIdentification127Choice_? AccountOwner { get; init; } 
    /// <summary>
    /// Location where the financial instruments are/will be safekept.
    /// </summary>
    [DataMember]
    public SafekeepingPlaceFormat28Choice_? SafekeepingPlace { get; init; } 
    /// <summary>
    /// Detailed account holdings information report for a corporate action event.
    /// </summary>
    [DataMember]
    public ValueList<CorporateActionEventAndBalance20> CorporateActionEventAndBalance { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
