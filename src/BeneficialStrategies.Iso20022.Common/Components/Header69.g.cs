﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Header69.  ISO2002 ID# _1lM-kRvQEey2RdTw-AkXzg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of characteristics related to the protocol.
/// </summary>
[IsoId("_1lM-kRvQEey2RdTw-AkXzg")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Header")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Header69
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Header69 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Header69( MessageFunction18Code reqMessageFunction,System.String reqProtocolVersion,System.DateTime reqCreationDateTime,GenericIdentification183 reqInitiatingParty )
    {
        MessageFunction = reqMessageFunction;
        ProtocolVersion = reqProtocolVersion;
        CreationDateTime = reqCreationDateTime;
        InitiatingParty = reqInitiatingParty;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the type of process related to the message.
    /// </summary>
    [IsoId("_1rfz0RvQEey2RdTw-AkXzg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Message Function")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageFunction18Code MessageFunction { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public MessageFunction18Code MessageFunction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageFunction18Code MessageFunction { get; init; } 
    #else
    public MessageFunction18Code MessageFunction { get; set; } 
    #endif
    
    /// <summary>
    /// Version of the acquirer to issuer protocol specifications.
    /// </summary>
    [IsoId("_1rfz0xvQEey2RdTw-AkXzg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Protocol Version")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 2048 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax2048Text ProtocolVersion { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.String ProtocolVersion { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ProtocolVersion { get; init; } 
    #else
    public System.String ProtocolVersion { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification of an exchange of messages between two parties.
    /// </summary>
    [IsoId("_1rfz1RvQEey2RdTw-AkXzg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Exchange Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ExchangeIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ExchangeIdentification { get; init; } 
    #else
    public System.String? ExchangeIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Number of retransmission of the message. Incremented by one for each retransmission.
    /// </summary>
    [IsoId("_1rfz1xvQEey2RdTw-AkXzg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Re Transmission Counter")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 0 ,MinimumLength = 0)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax3NumericText? ReTransmissionCounter { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ReTransmissionCounter { get; init; } 
    #else
    public System.String? ReTransmissionCounter { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time at which the message was sent.
    /// </summary>
    [IsoId("_1rfz2RvQEey2RdTw-AkXzg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Creation Date Time")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODateTime CreationDateTime { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.DateTime CreationDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime CreationDateTime { get; init; } 
    #else
    public System.DateTime CreationDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification of the partner that has initiated the exchange.
    /// </summary>
    [IsoId("_1rfz2xvQEey2RdTw-AkXzg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Initiating Party")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required GenericIdentification183 InitiatingParty { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public GenericIdentification183 InitiatingParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification183 InitiatingParty { get; init; } 
    #else
    public GenericIdentification183 InitiatingParty { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification of the partner that is the recipient of the message exchange.
    /// </summary>
    [IsoId("_1rfz3RvQEey2RdTw-AkXzg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Recipient Party")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification183? RecipientParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification183? RecipientParty { get; init; } 
    #else
    public GenericIdentification183? RecipientParty { get; set; } 
    #endif
    
    /// <summary>
    /// Information sent in the request message to be returned in the response one, for instance to help in the retrieval of the context of the exchange.
    /// </summary>
    [IsoId("_1rfz3xvQEey2RdTw-AkXzg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Trace Data")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalData1? TraceData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalData1? TraceData { get; init; } 
    #else
    public AdditionalData1? TraceData { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of partners involved in exchange from the merchant to the issuer, with the relative timestamp of their exchanges.
    /// </summary>
    [IsoId("_1rfz4RvQEey2RdTw-AkXzg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Traceability")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Traceability9? Traceability { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Traceability9? Traceability { get; init; } 
    #else
    public Traceability9? Traceability { get; set; } 
    #endif
    
    
    #nullable disable
    
}
