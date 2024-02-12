﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AcceptorAuthorisationResponseV04.  ISO2002 ID# _NVsYsWkgEeSTIuB9A-QJ6g.
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


namespace BeneficialStrategies.Iso20022.caaa;

/// <summary>
/// This record is an implementation of the caaa.002.001.04 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The AcceptorAuthorisationResponse message is sent by the acquirer (or its agent) to an acceptor (or its agent), to return the result of the validation made by issuer about the payment transaction.
/// </summary>
[Description(@"The AcceptorAuthorisationResponse message is sent by the acquirer (or its agent) to an acceptor (or its agent), to return the result of the validation made by issuer about the payment transaction.")]
[IsoId("_NVsYsWkgEeSTIuB9A-QJ6g")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Acceptor Authorisation Response V")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AcceptorAuthorisationResponseV04 : IOuterRecord<AcceptorAuthorisationResponseV04,AcceptorAuthorisationResponseV04Document>
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "caaa.002.001.04";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AccptrAuthstnRspn";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => AcceptorAuthorisationResponseV04Document.DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AcceptorAuthorisationResponseV04 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AcceptorAuthorisationResponseV04( Header10 reqHeader,AcceptorAuthorisationResponse4 reqAuthorisationResponse,ContentInformationType11 reqSecurityTrailer )
    {
        Header = reqHeader;
        AuthorisationResponse = reqAuthorisationResponse;
        SecurityTrailer = reqSecurityTrailer;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Authorisation response message management information.
    /// </summary>
    [IsoId("_NVsYtWkgEeSTIuB9A-QJ6g")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Header")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Header10 Header { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public Header10 Header { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Header10 Header { get; init; } 
    #else
    public Header10 Header { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to the response of the authorisation.
    /// </summary>
    [IsoId("_NVsYt2kgEeSTIuB9A-QJ6g")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Authorisation Response")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AcceptorAuthorisationResponse4 AuthorisationResponse { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public AcceptorAuthorisationResponse4 AuthorisationResponse { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AcceptorAuthorisationResponse4 AuthorisationResponse { get; init; } 
    #else
    public AcceptorAuthorisationResponse4 AuthorisationResponse { get; set; } 
    #endif
    
    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_NVsYuWkgEeSTIuB9A-QJ6g")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Security Trailer")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ContentInformationType11 SecurityTrailer { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public ContentInformationType11 SecurityTrailer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContentInformationType11 SecurityTrailer { get; init; } 
    #else
    public ContentInformationType11 SecurityTrailer { get; set; } 
    #endif
    
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AcceptorAuthorisationResponseV04Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AcceptorAuthorisationResponseV04Document ToDocument()
    {
        return new AcceptorAuthorisationResponseV04Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="AcceptorAuthorisationResponseV04"/>.
/// </summary>
[Serializable]
public partial record AcceptorAuthorisationResponseV04Document : IOuterDocument<AcceptorAuthorisationResponseV04>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caaa.002.001.04";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AcceptorAuthorisationResponseV04"/> is required.
    /// </summary>
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AcceptorAuthorisationResponseV04 Message { get; init; }
    #else
    public AcceptorAuthorisationResponseV04 Message { get; init; }
    #endif
}
