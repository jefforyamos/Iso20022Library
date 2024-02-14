﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for CreditorPaymentActivationRequestStatusReportV06.  ISO2002 ID# _8mXpEZRtEeazAtAtDSg0Nw.
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


namespace BeneficialStrategies.Iso20022.pain;

/// <summary>
/// This record is an implementation of the pain.014.001.06 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The CreditorPaymentActivationRequestStatusReport message is sent by a party to the next party in the creditor payment activation request chain. It is used to inform the latter about the positive or negative status of a creditor payment activation request (either single or file).
/// </summary>
[Description(@"The CreditorPaymentActivationRequestStatusReport message is sent by a party to the next party in the creditor payment activation request chain. It is used to inform the latter about the positive or negative status of a creditor payment activation request (either single or file).")]
[IsoId("_8mXpEZRtEeazAtAtDSg0Nw")]
[DisplayName("Creditor Payment Activation Request Status Report V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CreditorPaymentActivationRequestStatusReportV06 : IOuterRecord<CreditorPaymentActivationRequestStatusReportV06,CreditorPaymentActivationRequestStatusReportV06Document>
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "pain.014.001.06";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CdtrPmtActvtnReqStsRpt";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => CreditorPaymentActivationRequestStatusReportV06Document.DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CreditorPaymentActivationRequestStatusReportV06 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CreditorPaymentActivationRequestStatusReportV06( GroupHeader46 reqGroupHeader,OriginalGroupInformation28 reqOriginalGroupInformationAndStatus )
    {
        GroupHeader = reqGroupHeader;
        OriginalGroupInformationAndStatus = reqOriginalGroupInformationAndStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Set of characteristics shared by all individual transactions included in the message.
    /// </summary>
    [IsoId("_8mXpHZRtEeazAtAtDSg0Nw")]
    [DisplayName("Group Header")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GrpHdr")]
    #endif
    [IsoXmlTag("GrpHdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required GroupHeader46 GroupHeader { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required GroupHeader46 GroupHeader { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GroupHeader46 GroupHeader { get; init; } 
    #else
    public GroupHeader46 GroupHeader { get; set; } 
    #endif
    
    /// <summary>
    /// Original group information concerning the group of transactions, to which the status report message refers to.
    /// </summary>
    [IsoId("_8mXpH5RtEeazAtAtDSg0Nw")]
    [DisplayName("Original Group Information And Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlGrpInfAndSts")]
    #endif
    [IsoXmlTag("OrgnlGrpInfAndSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required OriginalGroupInformation28 OriginalGroupInformationAndStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required OriginalGroupInformation28 OriginalGroupInformationAndStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OriginalGroupInformation28 OriginalGroupInformationAndStatus { get; init; } 
    #else
    public OriginalGroupInformation28 OriginalGroupInformationAndStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Information concerning the original payment information, to which the status report message refers.
    /// </summary>
    [IsoId("_8mXpIZRtEeazAtAtDSg0Nw")]
    [DisplayName("Original Payment Information And Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlPmtInfAndSts")]
    #endif
    [IsoXmlTag("OrgnlPmtInfAndSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OriginalPaymentInstruction24? OriginalPaymentInformationAndStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OriginalPaymentInstruction24? OriginalPaymentInformationAndStatus { get; init; } 
    #else
    public OriginalPaymentInstruction24? OriginalPaymentInformationAndStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_8mXpI5RtEeazAtAtDSg0Nw")]
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
    /// Using the state of this record, returns a populated &lt;seealso cref=&quot;CreditorPaymentActivationRequestStatusReportV06Document&quot;/&gt;, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public CreditorPaymentActivationRequestStatusReportV06Document ToDocument()
    {
        return new CreditorPaymentActivationRequestStatusReportV06Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying &lt;seealso cref=&quot;CreditorPaymentActivationRequestStatusReportV06&quot;/&gt;.
/// </summary>
[Serializable]
public partial record CreditorPaymentActivationRequestStatusReportV06Document : IOuterDocument<CreditorPaymentActivationRequestStatusReportV06>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:pain.014.001.06";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of &lt;seealso cref=&quot;CreditorPaymentActivationRequestStatusReportV06&quot;/&gt; is required.
    /// </summary>
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CreditorPaymentActivationRequestStatusReportV06 Message { get; init; }
    #else
    public CreditorPaymentActivationRequestStatusReportV06 Message { get; init; }
    #endif
}
