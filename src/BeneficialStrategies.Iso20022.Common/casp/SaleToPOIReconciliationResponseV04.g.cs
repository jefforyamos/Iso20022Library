﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SaleToPOIReconciliationResponseV04.  ISO2002 ID# _wGUZ0U6uEeyGi9JAv6wq7Q.
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


namespace BeneficialStrategies.Iso20022.casp;

/// <summary>
/// This record is an implementation of the casp.004.001.04 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The SaleToPOIReconciliationResponse message is sent by a POI to provide the result of reconciliation process between sale and POI systems.
/// </summary>
[Description(@"The SaleToPOIReconciliationResponse message is sent by a POI to provide the result of reconciliation process between sale and POI systems.")]
[IsoId("_wGUZ0U6uEeyGi9JAv6wq7Q")]
[DisplayName("Sale To POI Reconciliation Response V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SaleToPOIReconciliationResponseV04 : IOuterRecord<SaleToPOIReconciliationResponseV04,SaleToPOIReconciliationResponseV04Document>
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "casp.004.001.04";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SaleToPOIRcncltnRspn";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => SaleToPOIReconciliationResponseV04Document.DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SaleToPOIReconciliationResponseV04 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SaleToPOIReconciliationResponseV04( Header41 reqHeader,ReconciliationResponse6 reqReconciliationResponse )
    {
        Header = reqHeader;
        ReconciliationResponse = reqReconciliationResponse;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Set of characteristics related to the transfer of the request.
    /// </summary>
    [IsoId("_wGVA4U6uEeyGi9JAv6wq7Q")]
    [DisplayName("Header")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Hdr")]
    #endif
    [IsoXmlTag("Hdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Header41 Header { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Header41 Header { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Header41 Header { get; init; } 
    #else
    public Header41 Header { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to the response of a reconciliation request.
    /// </summary>
    [IsoId("_wGVA406uEeyGi9JAv6wq7Q")]
    [DisplayName("Reconciliation Response")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcncltnRspn")]
    #endif
    [IsoXmlTag("RcncltnRspn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ReconciliationResponse6 ReconciliationResponse { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ReconciliationResponse6 ReconciliationResponse { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReconciliationResponse6 ReconciliationResponse { get; init; } 
    #else
    public ReconciliationResponse6 ReconciliationResponse { get; set; } 
    #endif
    
    /// <summary>
    /// Trailer of the message containing a MAC or a digital signature.
    /// </summary>
    [IsoId("_wGVA5U6uEeyGi9JAv6wq7Q")]
    [DisplayName("Security Trailer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctyTrlr")]
    #endif
    [IsoXmlTag("SctyTrlr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContentInformationType29? SecurityTrailer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContentInformationType29? SecurityTrailer { get; init; } 
    #else
    public ContentInformationType29? SecurityTrailer { get; set; } 
    #endif
    
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated &lt;seealso cref=&quot;SaleToPOIReconciliationResponseV04Document&quot;/&gt;, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SaleToPOIReconciliationResponseV04Document ToDocument()
    {
        return new SaleToPOIReconciliationResponseV04Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying &lt;seealso cref=&quot;SaleToPOIReconciliationResponseV04&quot;/&gt;.
/// </summary>
[Serializable]
public partial record SaleToPOIReconciliationResponseV04Document : IOuterDocument<SaleToPOIReconciliationResponseV04>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:casp.004.001.04";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of &lt;seealso cref=&quot;SaleToPOIReconciliationResponseV04&quot;/&gt; is required.
    /// </summary>
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SaleToPOIReconciliationResponseV04 Message { get; init; }
    #else
    public SaleToPOIReconciliationResponseV04 Message { get; init; }
    #endif
}
