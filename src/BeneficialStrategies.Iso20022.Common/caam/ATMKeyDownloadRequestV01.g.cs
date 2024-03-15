﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for ATMKeyDownloadRequestV01.  ISO2002 ID# _ohA3UItKEeSxlKlAGYErFg.
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


namespace BeneficialStrategies.Iso20022.caam;

/// <summary>
/// This record is an implementation of the caam.003.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The ATMKeyDownloadRequest message is sent by an ATM to an ATM manager to initiate the download of one or several cryptographic keys.
/// </summary>
[Description(@"The ATMKeyDownloadRequest message is sent by an ATM to an ATM manager to initiate the download of one or several cryptographic keys.")]
[IsoId("_ohA3UItKEeSxlKlAGYErFg")]
[DisplayName("ATM Key Download Request V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ATMKeyDownloadRequestV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "caam.003.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ATMKeyDwnldReq";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caam.003.001.01";
    
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
    /// Constructs a ATMKeyDownloadRequestV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ATMKeyDownloadRequestV01( Header20 reqHeader )
    {
        Header = reqHeader;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Information related to the protocol management on a segment of the path from the ATM to the acquirer.
    /// </summary>
    [IsoId("_vxyWQItKEeSxlKlAGYErFg")]
    [DisplayName("Header")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Hdr")]
    #endif
    [IsoXmlTag("Hdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Header20 Header { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Header20 Header { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Header20 Header { get; init; } 
    #else
    public Header20 Header { get; set; } 
    #endif
    
    /// <summary>
    /// Encrypted body of the message.
    /// </summary>
    [IsoId("_367noItKEeSxlKlAGYErFg")]
    [DisplayName("Protected ATM Key Download Request")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtctdATMKeyDwnldReq")]
    #endif
    [IsoXmlTag("PrtctdATMKeyDwnldReq")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContentInformationType10? ProtectedATMKeyDownloadRequest { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContentInformationType10? ProtectedATMKeyDownloadRequest { get; init; } 
    #else
    public ContentInformationType10? ProtectedATMKeyDownloadRequest { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to the request of a key download from an ATM.
    /// </summary>
    [IsoId("_A7d0AItLEeSxlKlAGYErFg")]
    [DisplayName("ATM Key Download Request")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ATMKeyDwnldReq")]
    #endif
    [IsoXmlTag("ATMKeyDwnldReq")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ATMKeyDownloadRequest1? ATMKeyDownloadRequest { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMKeyDownloadRequest1? ATMKeyDownloadRequest { get; init; } 
    #else
    public ATMKeyDownloadRequest1? ATMKeyDownloadRequest { get; set; } 
    #endif
    
    /// <summary>
    /// Trailer of the message containing a MAC or a digital signature.
    /// </summary>
    [IsoId("_FP42kItLEeSxlKlAGYErFg")]
    [DisplayName("Security Trailer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctyTrlr")]
    #endif
    [IsoXmlTag("SctyTrlr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContentInformationType13? SecurityTrailer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContentInformationType13? SecurityTrailer { get; init; } 
    #else
    public ContentInformationType13? SecurityTrailer { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since ATMKeyDownloadRequestV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ATMKeyDownloadRequestV01.

