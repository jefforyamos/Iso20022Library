﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for CurrencyControlSupportingDocumentDeliveryV01.  ISO2002 ID# _5RUDUNLpEeSDLevdaFPXHw.
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


namespace BeneficialStrategies.Iso20022.auth;

/// <summary>
/// This record is an implementation of the auth.025.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The CurrencyControlSupportingDocumentDelivery message is sent by either the reporting party (respectively the registration agent or the registration agent (respectively the reporting party) in response to the supporting document request.
/// </summary>
[Description(@"The CurrencyControlSupportingDocumentDelivery message is sent by either the reporting party (respectively the registration agent or the registration agent (respectively the reporting party) in response to the supporting document request.")]
[IsoId("_5RUDUNLpEeSDLevdaFPXHw")]
[DisplayName("Currency Control Supporting Document Delivery V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CurrencyControlSupportingDocumentDeliveryV01 : IOuterRecord<CurrencyControlSupportingDocumentDeliveryV01,CurrencyControlSupportingDocumentDeliveryV01Document>
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "auth.025.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CcyCtrlSpprtgDocDlvry";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => CurrencyControlSupportingDocumentDeliveryV01Document.DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CurrencyControlSupportingDocumentDeliveryV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CurrencyControlSupportingDocumentDeliveryV01( CurrencyControlHeader3 reqGroupHeader,SupportingDocument1 reqSupportingDocument )
    {
        GroupHeader = reqGroupHeader;
        SupportingDocument = reqSupportingDocument;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Characteristics shared by all individual items included in the message.
    /// </summary>
    [IsoId("_AKIVQNLqEeSDLevdaFPXHw")]
    [DisplayName("Group Header")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GrpHdr")]
    #endif
    [IsoXmlTag("GrpHdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CurrencyControlHeader3 GroupHeader { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CurrencyControlHeader3 GroupHeader { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyControlHeader3 GroupHeader { get; init; } 
    #else
    public CurrencyControlHeader3 GroupHeader { get; set; } 
    #endif
    
    /// <summary>
    /// Details of the supporting document provided for the registered contract.
    /// </summary>
    [IsoId("_9sPhENLqEeSDLevdaFPXHw")]
    [DisplayName("Supporting Document")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SpprtgDoc")]
    #endif
    [IsoXmlTag("SpprtgDoc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SupportingDocument1 SupportingDocument { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SupportingDocument1 SupportingDocument { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SupportingDocument1 SupportingDocument { get; init; } 
    #else
    public SupportingDocument1 SupportingDocument { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_CltKYdLrEeSDLevdaFPXHw")]
    [DisplayName("Supplementary Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SplmtryData")]
    #endif
    [IsoXmlTag("SplmtryData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SupplementaryData1? SupplementaryData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SupplementaryData1? SupplementaryData { get; init; } 
    #else
    public SupplementaryData1? SupplementaryData { get; set; } 
    #endif
    
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated &lt;seealso cref=&quot;CurrencyControlSupportingDocumentDeliveryV01Document&quot;/&gt;, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public CurrencyControlSupportingDocumentDeliveryV01Document ToDocument()
    {
        return new CurrencyControlSupportingDocumentDeliveryV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying &lt;seealso cref=&quot;CurrencyControlSupportingDocumentDeliveryV01&quot;/&gt;.
/// </summary>
[Serializable]
public partial record CurrencyControlSupportingDocumentDeliveryV01Document : IOuterDocument<CurrencyControlSupportingDocumentDeliveryV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.025.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of &lt;seealso cref=&quot;CurrencyControlSupportingDocumentDeliveryV01&quot;/&gt; is required.
    /// </summary>
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CurrencyControlSupportingDocumentDeliveryV01 Message { get; init; }
    #else
    public CurrencyControlSupportingDocumentDeliveryV01 Message { get; init; }
    #endif
}
