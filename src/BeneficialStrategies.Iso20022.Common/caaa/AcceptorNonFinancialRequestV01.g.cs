﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AcceptorNonFinancialRequestV01.  ISO2002 ID# _6n8LsC_bEeugIJ3Gvoevmg.
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
/// This record is an implementation of the caaa.022.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The AcceptorNonFinancialRequest message is sent by the POI to receive additional information from the Acquirer (or its agent).
/// </summary>
[Description(@"The AcceptorNonFinancialRequest message is sent by the POI to receive additional information from the Acquirer (or its agent).")]
[IsoId("_6n8LsC_bEeugIJ3Gvoevmg")]
[DisplayName("Acceptor Non Financial Request V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AcceptorNonFinancialRequestV01 : IOuterRecord<AcceptorNonFinancialRequestV01,AcceptorNonFinancialRequestV01Document>
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "caaa.022.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AccptrNonFinReq";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => AcceptorNonFinancialRequestV01Document.DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AcceptorNonFinancialRequestV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AcceptorNonFinancialRequestV01( Header59 reqHeader,NonFinancialRequestComponent1 reqNonFinancialRequest )
    {
        Header = reqHeader;
        NonFinancialRequest = reqNonFinancialRequest;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Non Financial request message management information.
    /// </summary>
    [IsoId("_jSU6sy_cEeugIJ3Gvoevmg")]
    [DisplayName("Header")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Hdr")]
    #endif
    [IsoXmlTag("Hdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Header59 Header { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Header59 Header { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Header59 Header { get; init; } 
    #else
    public Header59 Header { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to the non financial request.
    /// </summary>
    [IsoId("_mpdbUC_sEeugIJ3Gvoevmg")]
    [DisplayName("Non Financial Request")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NonFinReq")]
    #endif
    [IsoXmlTag("NonFinReq")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required NonFinancialRequestComponent1 NonFinancialRequest { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required NonFinancialRequestComponent1 NonFinancialRequest { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NonFinancialRequestComponent1 NonFinancialRequest { get; init; } 
    #else
    public NonFinancialRequestComponent1 NonFinancialRequest { get; set; } 
    #endif
    
    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_jSU6tS_cEeugIJ3Gvoevmg")]
    [DisplayName("Security Trailer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctyTrlr")]
    #endif
    [IsoXmlTag("SctyTrlr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContentInformationType27? SecurityTrailer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContentInformationType27? SecurityTrailer { get; init; } 
    #else
    public ContentInformationType27? SecurityTrailer { get; set; } 
    #endif
    
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated &lt;seealso cref=&quot;AcceptorNonFinancialRequestV01Document&quot;/&gt;, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AcceptorNonFinancialRequestV01Document ToDocument()
    {
        return new AcceptorNonFinancialRequestV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying &lt;seealso cref=&quot;AcceptorNonFinancialRequestV01&quot;/&gt;.
/// </summary>
[Serializable]
public partial record AcceptorNonFinancialRequestV01Document : IOuterDocument<AcceptorNonFinancialRequestV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caaa.022.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of &lt;seealso cref=&quot;AcceptorNonFinancialRequestV01&quot;/&gt; is required.
    /// </summary>
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AcceptorNonFinancialRequestV01 Message { get; init; }
    #else
    public AcceptorNonFinancialRequestV01 Message { get; init; }
    #endif
}
