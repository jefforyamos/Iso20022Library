﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Header17.  ISO2002 ID# _l60LgXq_EeSA34QF-FhTBw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of characteristics related to the protocol.
/// </summary>
public partial record Header17
{
    #nullable enable
    
    /// <summary>
    /// Identifies the type of process related to the message.
    /// </summary>
    public required MessageFunction6Code MessageFunction { get; init; } 
    /// <summary>
    /// Version of the acquirer to issuer protocol specifications.
    /// </summary>
    public required IsoMax6Text ProtocolVersion { get; init; } 
    /// <summary>
    /// Unique identification of an exchange occurrence.
    /// </summary>
    public required IsoMax3NumericText ExchangeIdentification { get; init; } 
    /// <summary>
    /// Number of retransmission of the message. Incremented by one for each retransmission.
    /// </summary>
    public IsoMax3NumericText? ReTransmissionCounter { get; init; } 
    /// <summary>
    /// Date and time at which the message was sent.
    /// </summary>
    public required IsoISODateTime CreationDateTime { get; init; } 
    /// <summary>
    /// Unique identification of the partner that has initiated the exchange.
    /// </summary>
    public required GenericIdentification73 InitiatingParty { get; init; } 
    /// <summary>
    /// Unique identification of the partner that is the recipient of the message exchange.
    /// </summary>
    public GenericIdentification73? RecipientParty { get; init; } 
    /// <summary>
    /// Identification of partners involved in exchange from the merchant to the issuer, with the relative timestamp of their exchanges.
    /// </summary>
    public Traceability3[] Traceability { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
