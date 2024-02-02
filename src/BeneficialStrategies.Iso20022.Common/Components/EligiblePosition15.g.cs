﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for EligiblePosition15.  ISO2002 ID# _oMQblzRTEe2id-MjcNoBdw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the voting entitlement for rights holders.
/// </summary>
[DataContract]
[XmlType]
public partial record EligiblePosition15
{
    #nullable enable
    
    /// <summary>
    /// Identification of the securities account.
    /// </summary>
    [DataMember]
    public IsoMax35Text? AccountIdentification { get; init; } 
    /// <summary>
    /// Blockchain address or wallet where digital assets are maintained. This is the equivalent of safekeeping account for digital assets.
    /// </summary>
    [DataMember]
    public IsoMax140Text? BlockChainAddressOrWallet { get; init; } 
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [DataMember]
    public PartyIdentification241? AccountOwner { get; init; } 
    /// <summary>
    /// Net position of a segregated holding of a single security within the overall position held in a securities account, for example, sub-balance per status.
    /// </summary>
    [DataMember]
    public ValueList<HoldingBalance11> HoldingBalance { get; init; } = [];
    /// <summary>
    /// Owner of the voting rights.
    /// </summary>
    [DataMember]
    public ValueList<PartyIdentification270> RightsHolder { get; init; } = [];
    
    #nullable disable
}
