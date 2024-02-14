﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for ATMInquiryResponseV01.  ISO2002 ID# _ni6eUIqwEeSIDtZ76p6McQ.
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


namespace BeneficialStrategies.Iso20022.catp;

/// <summary>
/// This record is an implementation of the catp.007.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The ATMInquiryResponse message is sent by an ATM manager or its agent to the ATM to provide the information and the outcome of the verifications requested in the ATMInquiryRequest.
/// </summary>
[Description(@"The ATMInquiryResponse message is sent by an ATM manager or its agent to the ATM to provide the information and the outcome of the verifications requested in the ATMInquiryRequest.")]
[IsoId("_ni6eUIqwEeSIDtZ76p6McQ")]
[DisplayName("ATM Inquiry Response V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ATMInquiryResponseV01 : IOuterRecord<ATMInquiryResponseV01,ATMInquiryResponseV01Document>
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "catp.007.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ATMNqryRspn";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => ATMInquiryResponseV01Document.DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ATMInquiryResponseV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ATMInquiryResponseV01( Header20 reqHeader )
    {
        Header = reqHeader;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Information related to the protocol management on a segment of the path from the ATM to the acquirer.
    /// </summary>
    [IsoId("_wJq4wIqwEeSIDtZ76p6McQ")]
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
    [IsoId("_9db04IqwEeSIDtZ76p6McQ")]
    [DisplayName("Protected ATM Inquiry Response")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtctdATMNqryRspn")]
    #endif
    [IsoXmlTag("PrtctdATMNqryRspn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContentInformationType10? ProtectedATMInquiryResponse { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContentInformationType10? ProtectedATMInquiryResponse { get; init; } 
    #else
    public ContentInformationType10? ProtectedATMInquiryResponse { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to the response of an ATM inquiry from an ATM manager.
    /// </summary>
    [IsoId("_GOZUMIqxEeSIDtZ76p6McQ")]
    [DisplayName("ATM Inquiry Response")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ATMNqryRspn")]
    #endif
    [IsoXmlTag("ATMNqryRspn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ATMInquiryResponse1? ATMInquiryResponse { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMInquiryResponse1? ATMInquiryResponse { get; init; } 
    #else
    public ATMInquiryResponse1? ATMInquiryResponse { get; set; } 
    #endif
    
    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_MBxBAIqxEeSIDtZ76p6McQ")]
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
    /// Using the state of this record, returns a populated &lt;seealso cref=&quot;ATMInquiryResponseV01Document&quot;/&gt;, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public ATMInquiryResponseV01Document ToDocument()
    {
        return new ATMInquiryResponseV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying &lt;seealso cref=&quot;ATMInquiryResponseV01&quot;/&gt;.
/// </summary>
[Serializable]
public partial record ATMInquiryResponseV01Document : IOuterDocument<ATMInquiryResponseV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:catp.007.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of &lt;seealso cref=&quot;ATMInquiryResponseV01&quot;/&gt; is required.
    /// </summary>
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ATMInquiryResponseV01 Message { get; init; }
    #else
    public ATMInquiryResponseV01 Message { get; init; }
    #endif
}
