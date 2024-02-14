﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AcceptorCompletionAdviceResponseV08.  ISO2002 ID# _46JYoQudEeqw5uEXxQ9H4g.
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
/// This record is an implementation of the caaa.004.001.08 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The AcceptorCompletionAdviceResponse message is sent by the acquirer (or its agent) to acknowledge the acceptor (or its agent) of the outcome of the payment transaction, and the transfer the financial data of the transaction contained in the completion advice.
/// </summary>
[Description(@"The AcceptorCompletionAdviceResponse message is sent by the acquirer (or its agent) to acknowledge the acceptor (or its agent) of the outcome of the payment transaction, and the transfer the financial data of the transaction contained in the completion advice.")]
[IsoId("_46JYoQudEeqw5uEXxQ9H4g")]
[DisplayName("Acceptor Completion Advice Response V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AcceptorCompletionAdviceResponseV08 : IOuterRecord<AcceptorCompletionAdviceResponseV08,AcceptorCompletionAdviceResponseV08Document>
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "caaa.004.001.08";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AccptrCmpltnAdvcRspn";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => AcceptorCompletionAdviceResponseV08Document.DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AcceptorCompletionAdviceResponseV08 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AcceptorCompletionAdviceResponseV08( Header58 reqHeader,AcceptorCompletionAdviceResponse8 reqCompletionAdviceResponse )
    {
        Header = reqHeader;
        CompletionAdviceResponse = reqCompletionAdviceResponse;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Completion advice response message management information.
    /// </summary>
    [IsoId("_46JYpQudEeqw5uEXxQ9H4g")]
    [DisplayName("Header")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Hdr")]
    #endif
    [IsoXmlTag("Hdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Header58 Header { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Header58 Header { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Header58 Header { get; init; } 
    #else
    public Header58 Header { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to the completion advice response.
    /// </summary>
    [IsoId("_46JYpwudEeqw5uEXxQ9H4g")]
    [DisplayName("Completion Advice Response")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CmpltnAdvcRspn")]
    #endif
    [IsoXmlTag("CmpltnAdvcRspn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AcceptorCompletionAdviceResponse8 CompletionAdviceResponse { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AcceptorCompletionAdviceResponse8 CompletionAdviceResponse { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AcceptorCompletionAdviceResponse8 CompletionAdviceResponse { get; init; } 
    #else
    public AcceptorCompletionAdviceResponse8 CompletionAdviceResponse { get; set; } 
    #endif
    
    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_46JYqQudEeqw5uEXxQ9H4g")]
    [DisplayName("Security Trailer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctyTrlr")]
    #endif
    [IsoXmlTag("SctyTrlr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContentInformationType24? SecurityTrailer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContentInformationType24? SecurityTrailer { get; init; } 
    #else
    public ContentInformationType24? SecurityTrailer { get; set; } 
    #endif
    
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated &lt;seealso cref=&quot;AcceptorCompletionAdviceResponseV08Document&quot;/&gt;, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AcceptorCompletionAdviceResponseV08Document ToDocument()
    {
        return new AcceptorCompletionAdviceResponseV08Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying &lt;seealso cref=&quot;AcceptorCompletionAdviceResponseV08&quot;/&gt;.
/// </summary>
[Serializable]
public partial record AcceptorCompletionAdviceResponseV08Document : IOuterDocument<AcceptorCompletionAdviceResponseV08>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caaa.004.001.08";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of &lt;seealso cref=&quot;AcceptorCompletionAdviceResponseV08&quot;/&gt; is required.
    /// </summary>
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AcceptorCompletionAdviceResponseV08 Message { get; init; }
    #else
    public AcceptorCompletionAdviceResponseV08 Message { get; init; }
    #endif
}
