﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Header46.  ISO2002 ID# _M_LrIVW8EeeiG_nL4vgKnQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of characteristics related to the protocol.
/// Header for an amendment message.
/// </summary>
public partial record Header46
{
    #nullable enable
    
    /// <summary>
    /// Identifies the type of process related to the message.
    /// </summary>
    public required MessageFunction27Code MessageFunction { get; init; } 
    /// <summary>
    /// Version of the acquirer to issuer protocol specifications.
    /// </summary>
    public required IsoMax2048Text ProtocolVersion { get; init; } 
    /// <summary>
    /// Unique identification of an exchange of messages between two parties.
    /// </summary>
    public IsoMax35Text? ExchangeIdentification { get; init; } 
    /// <summary>
    /// Number of retransmission of the message. Incremented by one for each retransmission.
    /// </summary>
    public IsoMax3NumericText? ReTransmissionCounter { get; init; } 
    /// <summary>
    /// Date and time at which the message was sent.
    /// </summary>
    public required IsoISODateTime CreationDateTime { get; init; } 
    /// <summary>
    /// Information related to the batch and the collection to which the message belongs if any.
    /// </summary>
    public BatchManagementInformation1? BatchManagementInformation { get; init; } 
    /// <summary>
    /// Unique identification of the partner that has initiated the exchange.
    /// </summary>
    public required GenericIdentification172 InitiatingParty { get; init; } 
    /// <summary>
    /// Unique identification of the partner that is the recipient of the message exchange.
    /// </summary>
    public GenericIdentification172? RecipientParty { get; init; } 
    /// <summary>
    /// Information sent in the request message to be returned in the response one, for instance to help in the retrieval of the context of the exchange.
    /// ISO 8583:93/2003 bit 59
    /// </summary>
    public AdditionalData1? TraceData { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Identification of partners involved in exchange from the merchant to the issuer, with the relative timestamp of their exchanges.
    /// </summary>
    public Traceability7? Traceability { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
