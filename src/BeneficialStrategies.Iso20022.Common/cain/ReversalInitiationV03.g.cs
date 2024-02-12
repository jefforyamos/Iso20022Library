﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for ReversalInitiationV03.  ISO2002 ID# _U0x9oYHOEeuwq_rv81SdXw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif


namespace BeneficialStrategies.Iso20022.cain;

/// <summary>
/// This record is an implementation of the cain.005.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The ReversalInitiation message is sent by an acquirer, an originator or an agent to an issuer to request or advise of the reversal of an authorisation by the issuer. A reversal is a partial or complete nullification of the effects of a previous authorisation, financial presentment or financial accumulation presentment that cannot be processed as instructed (for example, is undeliverable and cancelled or the acquirer timed out waiting for a response).
/// </summary>
[Description(@"The ReversalInitiation message is sent by an acquirer, an originator or an agent to an issuer to request or advise of the reversal of an authorisation by the issuer. A reversal is a partial or complete nullification of the effects of a previous authorisation, financial presentment or financial accumulation presentment that cannot be processed as instructed (for example, is undeliverable and cancelled or the acquirer timed out waiting for a response).")]
[IsoId("_U0x9oYHOEeuwq_rv81SdXw")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Reversal Initiation V")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ReversalInitiationV03 : IOuterRecord<ReversalInitiationV03,ReversalInitiationV03Document>
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "cain.005.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "RvslInitn";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => ReversalInitiationV03Document.DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ReversalInitiationV03 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ReversalInitiationV03( Header62 reqHeader,ReversalInitiation2 reqBody )
    {
        Header = reqHeader;
        Body = reqBody;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Information related to the management of the protocol.
    /// </summary>
    [IsoId("_U0yksYHOEeuwq_rv81SdXw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Header")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Header62 Header { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public Header62 Header { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Header62 Header { get; init; } 
    #else
    public Header62 Header { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to the reversal of an authorisation or financial transaction.
    /// </summary>
    [IsoId("_U0yks4HOEeuwq_rv81SdXw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Body")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ReversalInitiation2 Body { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public ReversalInitiation2 Body { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReversalInitiation2 Body { get; init; } 
    #else
    public ReversalInitiation2 Body { get; set; } 
    #endif
    
    /// <summary>
    /// Trailer of the message containing a MAC
    /// </summary>
    [IsoId("_U0yktYHOEeuwq_rv81SdXw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Security Trailer")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContentInformationType20? SecurityTrailer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContentInformationType20? SecurityTrailer { get; init; } 
    #else
    public ContentInformationType20? SecurityTrailer { get; set; } 
    #endif
    
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="ReversalInitiationV03Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public ReversalInitiationV03Document ToDocument()
    {
        return new ReversalInitiationV03Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="ReversalInitiationV03"/>.
/// </summary>
[Serializable]
public partial record ReversalInitiationV03Document : IOuterDocument<ReversalInitiationV03>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:cain.005.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="ReversalInitiationV03"/> is required.
    /// </summary>
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ReversalInitiationV03 Message { get; init; }
    #else
    public ReversalInitiationV03 Message { get; init; }
    #endif
}
