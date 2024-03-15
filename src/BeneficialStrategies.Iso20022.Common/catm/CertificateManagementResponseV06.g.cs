﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for CertificateManagementResponseV06.  ISO2002 ID# _2x9fsXPYEe2pK6udhxEaHA.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
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


namespace BeneficialStrategies.Iso20022.catm;

/// <summary>
/// This record is an implementation of the catm.008.001.06 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The CertificateManagementResponse is sent by a terminal manager in response to a CertificateManagementRequest to provide the outcome of the requested service.
/// </summary>
[Description(@"The CertificateManagementResponse is sent by a terminal manager in response to a CertificateManagementRequest to provide the outcome of the requested service.")]
[IsoId("_2x9fsXPYEe2pK6udhxEaHA")]
[DisplayName("Certificate Management Response V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CertificateManagementResponseV06 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "catm.008.001.06";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CertMgmtRspn";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:catm.008.001.06";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CertificateManagementResponseV06 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CertificateManagementResponseV06( TMSHeader1 reqHeader,CertificateManagementResponse3 reqCertificateManagementResponse )
    {
        Header = reqHeader;
        CertificateManagementResponse = reqCertificateManagementResponse;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Information related to the protocol management.
    /// </summary>
    [IsoId("_2x9fs3PYEe2pK6udhxEaHA")]
    [DisplayName("Header")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Hdr")]
    #endif
    [IsoXmlTag("Hdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TMSHeader1 Header { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TMSHeader1 Header { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TMSHeader1 Header { get; init; } 
    #else
    public TMSHeader1 Header { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to the result of the certificate management request.
    /// </summary>
    [IsoId("_2x9ftXPYEe2pK6udhxEaHA")]
    [DisplayName("Certificate Management Response")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CertMgmtRspn")]
    #endif
    [IsoXmlTag("CertMgmtRspn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CertificateManagementResponse3 CertificateManagementResponse { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CertificateManagementResponse3 CertificateManagementResponse { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CertificateManagementResponse3 CertificateManagementResponse { get; init; } 
    #else
    public CertificateManagementResponse3 CertificateManagementResponse { get; set; } 
    #endif
    
    /// <summary>
    /// Trailer of the message containing a MAC or a digital signature.
    /// </summary>
    [IsoId("_2x9ft3PYEe2pK6udhxEaHA")]
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
    
}


// Since CertificateManagementResponseV06Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to CertificateManagementResponseV06.

