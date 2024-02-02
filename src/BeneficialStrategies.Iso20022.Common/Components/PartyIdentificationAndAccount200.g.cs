﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PartyIdentificationAndAccount200.  ISO2002 ID# _T4ZcCyqSEeyR9JrVGfaMKw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Party involved in the settlement chain.
/// </summary>
[DataContract]
[XmlType]
public partial record PartyIdentificationAndAccount200
{
    #nullable enable
    
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [DataMember]
    public required PartyIdentification178Choice_ PartyIdentification { get; init; } 
    /// <summary>
    /// Identification of the account owned by the party.
    /// </summary>
    [DataMember]
    public IsoMax35Text? AccountIdentification { get; init; } 
    /// <summary>
    /// Blockchain address or wallet where digital assets are maintained. This is the equivalent of safekeeping account for digital assets.
    /// </summary>
    [DataMember]
    public IsoMax140Text? BlockChainAddressOrWallet { get; init; } 
    /// <summary>
    /// Specifies the reference of the transaction at the party identified in the sequence.
    /// </summary>
    [DataMember]
    public IsoMax35Text? ProcessingIdentification { get; init; } 
    /// <summary>
    /// Date and optionally the time, at which this transaction was processed by the party identified in this sequence.
    /// </summary>
    [DataMember]
    public DateAndDateTime2Choice_? ProcessingDate { get; init; } 
    /// <summary>
    /// Business relationship between two entities; one entity is the account owner, the other entity is the account servicer.
    /// </summary>
    [DataMember]
    public SubAccount5? SubAccount { get; init; } 
    /// <summary>
    /// Contact person and contact information.
    /// </summary>
    [DataMember]
    public ContactIdentification2? ContactPerson { get; init; } 
    
    #nullable disable
}
