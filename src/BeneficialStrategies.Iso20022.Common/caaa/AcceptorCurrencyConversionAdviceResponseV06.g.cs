﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AcceptorCurrencyConversionAdviceResponseV06.  ISO2002 ID# _h7qd8XMiEe2vXY6MoVq19w.
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
/// This record is an implementation of the caaa.019.001.06 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The AcceptorCurrencyConversionAdviceResponse message is sent by the service provider to acknowledge the acceptor about the notification of the reception of the currency conversion advice.
/// </summary>
[Description(@"The AcceptorCurrencyConversionAdviceResponse message is sent by the service provider to acknowledge the acceptor about the notification of the reception of the currency conversion advice.")]
[IsoId("_h7qd8XMiEe2vXY6MoVq19w")]
[DisplayName("Acceptor Currency Conversion Advice Response V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AcceptorCurrencyConversionAdviceResponseV06 : IOuterRecord<AcceptorCurrencyConversionAdviceResponseV06,AcceptorCurrencyConversionAdviceResponseV06Document>
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "caaa.019.001.06";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AccptrCcyConvsAdvcRspn";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => AcceptorCurrencyConversionAdviceResponseV06Document.DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AcceptorCurrencyConversionAdviceResponseV06 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AcceptorCurrencyConversionAdviceResponseV06( Header70 reqHeader,AcceptorCancellationAdviceResponse11 reqCurrencyConversionAdviceResponse )
    {
        Header = reqHeader;
        CurrencyConversionAdviceResponse = reqCurrencyConversionAdviceResponse;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Cancellation advice response message management information.
    /// </summary>
    [IsoId("_h7qd9XMiEe2vXY6MoVq19w")]
    [DisplayName("Header")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Hdr")]
    #endif
    [IsoXmlTag("Hdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Header70 Header { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Header70 Header { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Header70 Header { get; init; } 
    #else
    public Header70 Header { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to the currency conversion advice response.
    /// </summary>
    [IsoId("_h7qd93MiEe2vXY6MoVq19w")]
    [DisplayName("Currency Conversion Advice Response")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CcyConvsAdvcRspn")]
    #endif
    [IsoXmlTag("CcyConvsAdvcRspn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AcceptorCancellationAdviceResponse11 CurrencyConversionAdviceResponse { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AcceptorCancellationAdviceResponse11 CurrencyConversionAdviceResponse { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AcceptorCancellationAdviceResponse11 CurrencyConversionAdviceResponse { get; init; } 
    #else
    public AcceptorCancellationAdviceResponse11 CurrencyConversionAdviceResponse { get; set; } 
    #endif
    
    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_h7qd-XMiEe2vXY6MoVq19w")]
    [DisplayName("Security Trailer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctyTrlr")]
    #endif
    [IsoXmlTag("SctyTrlr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContentInformationType36? SecurityTrailer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContentInformationType36? SecurityTrailer { get; init; } 
    #else
    public ContentInformationType36? SecurityTrailer { get; set; } 
    #endif
    
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated &lt;seealso cref=&quot;AcceptorCurrencyConversionAdviceResponseV06Document&quot;/&gt;, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AcceptorCurrencyConversionAdviceResponseV06Document ToDocument()
    {
        return new AcceptorCurrencyConversionAdviceResponseV06Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying &lt;seealso cref=&quot;AcceptorCurrencyConversionAdviceResponseV06&quot;/&gt;.
/// </summary>
[Serializable]
public partial record AcceptorCurrencyConversionAdviceResponseV06Document : IOuterDocument<AcceptorCurrencyConversionAdviceResponseV06>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caaa.019.001.06";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of &lt;seealso cref=&quot;AcceptorCurrencyConversionAdviceResponseV06&quot;/&gt; is required.
    /// </summary>
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AcceptorCurrencyConversionAdviceResponseV06 Message { get; init; }
    #else
    public AcceptorCurrencyConversionAdviceResponseV06 Message { get; init; }
    #endif
}
