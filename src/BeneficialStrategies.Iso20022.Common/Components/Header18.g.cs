﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Header18.  ISO2002 ID# _LJERUXuxEeS2Z_kGi7H1VQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of characteristics related to the protocol.
/// </summary>
[DataContract]
[XmlType]
public partial record Header18
{
    #nullable enable
    
    /// <summary>
    /// Identifies the type of process related to the message.
    /// </summary>
    [DataMember]
    public required MessageFunction6Code MessageFunction { get; init; } 
    /// <summary>
    /// Identifies the type of process related to the message which has to be reversed.
    /// </summary>
    [DataMember]
    public required MessageFunction6Code OriginalMessageFunction { get; init; } 
    /// <summary>
    /// Version of the acquirer to issuer protocol specifications.
    /// </summary>
    [DataMember]
    public required IsoMax6Text ProtocolVersion { get; init; } 
    /// <summary>
    /// Unique identification of an exchange occurrence.
    /// </summary>
    [DataMember]
    public required IsoMax3NumericText ExchangeIdentification { get; init; } 
    /// <summary>
    /// Number of retransmission of the message. Incremented by 1 for each retransmission.
    /// </summary>
    [DataMember]
    public IsoMax3NumericText? ReTransmissionCounter { get; init; } 
    /// <summary>
    /// Date and time at which the message was created.
    /// </summary>
    [DataMember]
    public required IsoISODateTime CreationDateTime { get; init; } 
    /// <summary>
    /// Unique identification of the partner that has initiated the exchange.
    /// </summary>
    [DataMember]
    public required GenericIdentification73 InitiatingParty { get; init; } 
    /// <summary>
    /// Unique identification of the partner that is the recipient of the message exchange.
    /// </summary>
    [DataMember]
    public GenericIdentification73? RecipientParty { get; init; } 
    /// <summary>
    /// Identification of partners involved in exchange from the merchant to the issuer, with the relative timestamp of their exchanges.
    /// </summary>
    [DataMember]
    public ValueList<Traceability3> Traceability { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
