﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SaleToPOIAdministrativeResponseV05.  ISO2002 ID# _ArzKEXPCEe2pK6udhxEaHA.
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
/// This record is an implementation of the casp.008.001.05 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The SaleToPOIAdministrativeResponse message is sent by a POI System to a sale system to provide response to an administrative service.
/// </summary>
[Description(@"The SaleToPOIAdministrativeResponse message is sent by a POI System to a sale system to provide response to an administrative service.")]
[IsoId("_ArzKEXPCEe2pK6udhxEaHA")]
[DisplayName("Sale To POI Administrative Response V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SaleToPOIAdministrativeResponseV05 : IOuterRecord<SaleToPOIAdministrativeResponseV05,SaleToPOIAdministrativeResponseV05Document>
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "casp.008.001.05";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SaleToPOIAdmstvRspn";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => SaleToPOIAdministrativeResponseV05Document.DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SaleToPOIAdministrativeResponseV05 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SaleToPOIAdministrativeResponseV05( Header41 reqHeader,AdministrativeResponse6 reqAdministrativeResponse )
    {
        Header = reqHeader;
        AdministrativeResponse = reqAdministrativeResponse;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Set of characteristics related to the transfer of the request.
    /// </summary>
    [IsoId("_ArzKE3PCEe2pK6udhxEaHA")]
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
    /// Information related to the response of an administrative request.
    /// </summary>
    [IsoId("_ArzKFXPCEe2pK6udhxEaHA")]
    [DisplayName("Administrative Response")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AdmstvRspn")]
    #endif
    [IsoXmlTag("AdmstvRspn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AdministrativeResponse6 AdministrativeResponse { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AdministrativeResponse6 AdministrativeResponse { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdministrativeResponse6 AdministrativeResponse { get; init; } 
    #else
    public AdministrativeResponse6 AdministrativeResponse { get; set; } 
    #endif
    
    /// <summary>
    /// Trailer of the message containing a MAC or a digital signature.
    /// </summary>
    [IsoId("_ArzKF3PCEe2pK6udhxEaHA")]
    [DisplayName("Security Trailer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctyTrlr")]
    #endif
    [IsoXmlTag("SctyTrlr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContentInformationType33? SecurityTrailer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContentInformationType33? SecurityTrailer { get; init; } 
    #else
    public ContentInformationType33? SecurityTrailer { get; set; } 
    #endif
    
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated &lt;seealso cref=&quot;SaleToPOIAdministrativeResponseV05Document&quot;/&gt;, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SaleToPOIAdministrativeResponseV05Document ToDocument()
    {
        return new SaleToPOIAdministrativeResponseV05Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying &lt;seealso cref=&quot;SaleToPOIAdministrativeResponseV05&quot;/&gt;.
/// </summary>
[Serializable]
public partial record SaleToPOIAdministrativeResponseV05Document : IOuterDocument<SaleToPOIAdministrativeResponseV05>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:casp.008.001.05";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of &lt;seealso cref=&quot;SaleToPOIAdministrativeResponseV05&quot;/&gt; is required.
    /// </summary>
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SaleToPOIAdministrativeResponseV05 Message { get; init; }
    #else
    public SaleToPOIAdministrativeResponseV05 Message { get; init; }
    #endif
}
