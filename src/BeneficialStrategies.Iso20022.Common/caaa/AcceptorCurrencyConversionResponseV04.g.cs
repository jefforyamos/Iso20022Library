﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AcceptorCurrencyConversionResponseV04.  ISO2002 ID# __dOKUap6EeanIZ10Ka8PnA.
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
/// This record is an implementation of the caaa.017.001.04 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The AcceptorCurrencyConversionResponse message is sent by currency conversion service provider to the card acceptor to return the result of a potential currency conversion for the cardholder.
/// 
/// </summary>
[Description(@"The AcceptorCurrencyConversionResponse message is sent by currency conversion service provider to the card acceptor to return the result of a potential currency conversion for the cardholder.|")]
[IsoId("__dOKUap6EeanIZ10Ka8PnA")]
[DisplayName("Acceptor Currency Conversion Response V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AcceptorCurrencyConversionResponseV04 : IOuterRecord<AcceptorCurrencyConversionResponseV04,AcceptorCurrencyConversionResponseV04Document>
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "caaa.017.001.04";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AccptrCcyConvsRspn";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => AcceptorCurrencyConversionResponseV04Document.DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AcceptorCurrencyConversionResponseV04 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AcceptorCurrencyConversionResponseV04( Header30 reqHeader,AcceptorCurrencyConversionResponse4 reqCurrencyConversionResponse )
    {
        Header = reqHeader;
        CurrencyConversionResponse = reqCurrencyConversionResponse;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Currency conversion response message management information.
    /// </summary>
    [IsoId("__dOKVap6EeanIZ10Ka8PnA")]
    [DisplayName("Header")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Hdr")]
    #endif
    [IsoXmlTag("Hdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Header30 Header { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Header30 Header { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Header30 Header { get; init; } 
    #else
    public Header30 Header { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to the outcome of the currency conversion.
    /// </summary>
    [IsoId("__dOKV6p6EeanIZ10Ka8PnA")]
    [DisplayName("Currency Conversion Response")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CcyConvsRspn")]
    #endif
    [IsoXmlTag("CcyConvsRspn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AcceptorCurrencyConversionResponse4 CurrencyConversionResponse { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AcceptorCurrencyConversionResponse4 CurrencyConversionResponse { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AcceptorCurrencyConversionResponse4 CurrencyConversionResponse { get; init; } 
    #else
    public AcceptorCurrencyConversionResponse4 CurrencyConversionResponse { get; set; } 
    #endif
    
    /// <summary>
    /// Trailer of the message containing a MAC (message authentication code).
    /// </summary>
    [IsoId("__dOKWap6EeanIZ10Ka8PnA")]
    [DisplayName("Security Trailer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctyTrlr")]
    #endif
    [IsoXmlTag("SctyTrlr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContentInformationType15? SecurityTrailer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContentInformationType15? SecurityTrailer { get; init; } 
    #else
    public ContentInformationType15? SecurityTrailer { get; set; } 
    #endif
    
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated &lt;seealso cref=&quot;AcceptorCurrencyConversionResponseV04Document&quot;/&gt;, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AcceptorCurrencyConversionResponseV04Document ToDocument()
    {
        return new AcceptorCurrencyConversionResponseV04Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying &lt;seealso cref=&quot;AcceptorCurrencyConversionResponseV04&quot;/&gt;.
/// </summary>
[Serializable]
public partial record AcceptorCurrencyConversionResponseV04Document : IOuterDocument<AcceptorCurrencyConversionResponseV04>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caaa.017.001.04";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of &lt;seealso cref=&quot;AcceptorCurrencyConversionResponseV04&quot;/&gt; is required.
    /// </summary>
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AcceptorCurrencyConversionResponseV04 Message { get; init; }
    #else
    public AcceptorCurrencyConversionResponseV04 Message { get; init; }
    #endif
}
