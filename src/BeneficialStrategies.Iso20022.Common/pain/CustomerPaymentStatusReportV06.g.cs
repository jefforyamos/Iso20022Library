﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for CustomerPaymentStatusReportV06.  ISO2002 ID# _NasXWRPeEeSVo-TFVwFHvA.
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
/// This record is an implementation of the pain.002.001.06 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The CustomerPaymentStatusReport message is sent by an instructed agent to the previous party in the payment chain. It is used to inform this party about the positive or negative status of an instruction (either single or file). It is also used to report on a pending instruction.
/// Usage
/// The CustomerPaymentStatusReport message is exchanged between an agent and a non-financial institution customer to provide status information on instructions previously sent. Its usage will always be governed by a bilateral agreement between the agent and the non-financial institution customer.
/// The CustomerPaymentStatusReport message can be used to provide information about the status (e.g. rejection, acceptance) of the initiation of a credit transfer, a direct debit, as well as on the initiation of other customer instructions.
/// The CustomerPaymentStatusReport message refers to the original instruction(s) by means of references only or by means of references and a set of elements from the original instruction.
/// The CustomerPaymentStatusReport message can be used in domestic and cross-border scenarios.
/// </summary>
[Description(@"Scope|The CustomerPaymentStatusReport message is sent by an instructed agent to the previous party in the payment chain. It is used to inform this party about the positive or negative status of an instruction (either single or file). It is also used to report on a pending instruction.|Usage|The CustomerPaymentStatusReport message is exchanged between an agent and a non-financial institution customer to provide status information on instructions previously sent. Its usage will always be governed by a bilateral agreement between the agent and the non-financial institution customer.|The CustomerPaymentStatusReport message can be used to provide information about the status (e.g. rejection, acceptance) of the initiation of a credit transfer, a direct debit, as well as on the initiation of other customer instructions.|The CustomerPaymentStatusReport message refers to the original instruction(s) by means of references only or by means of references and a set of elements from the original instruction.|The CustomerPaymentStatusReport message can be used in domestic and cross-border scenarios.")]
[IsoId("_NasXWRPeEeSVo-TFVwFHvA")]
[DisplayName("Customer Payment Status Report V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CustomerPaymentStatusReportV06 : IOuterRecord<CustomerPaymentStatusReportV06,CustomerPaymentStatusReportV06Document>
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "pain.002.001.06";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CstmrPmtStsRpt";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => CustomerPaymentStatusReportV06Document.DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CustomerPaymentStatusReportV06 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CustomerPaymentStatusReportV06( GroupHeader52 reqGroupHeader,OriginalGroupHeader1 reqOriginalGroupInformationAndStatus )
    {
        GroupHeader = reqGroupHeader;
        OriginalGroupInformationAndStatus = reqOriginalGroupInformationAndStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Set of characteristics shared by all individual transactions included in the status report message.
    /// </summary>
    [IsoId("_NasXZRPeEeSVo-TFVwFHvA")]
    [DisplayName("Group Header")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GrpHdr")]
    #endif
    [IsoXmlTag("GrpHdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required GroupHeader52 GroupHeader { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required GroupHeader52 GroupHeader { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GroupHeader52 GroupHeader { get; init; } 
    #else
    public GroupHeader52 GroupHeader { get; set; } 
    #endif
    
    /// <summary>
    /// Original group information concerning the group of transactions, to which the status report message refers to.
    /// </summary>
    [IsoId("_NasXZxPeEeSVo-TFVwFHvA")]
    [DisplayName("Original Group Information And Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlGrpInfAndSts")]
    #endif
    [IsoXmlTag("OrgnlGrpInfAndSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required OriginalGroupHeader1 OriginalGroupInformationAndStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required OriginalGroupHeader1 OriginalGroupInformationAndStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OriginalGroupHeader1 OriginalGroupInformationAndStatus { get; init; } 
    #else
    public OriginalGroupHeader1 OriginalGroupInformationAndStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Information concerning the original payment information, to which the status report message refers.
    /// </summary>
    [IsoId("_NasXaRPeEeSVo-TFVwFHvA")]
    [DisplayName("Original Payment Information And Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlPmtInfAndSts")]
    #endif
    [IsoXmlTag("OrgnlPmtInfAndSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OriginalPaymentInstruction12? OriginalPaymentInformationAndStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OriginalPaymentInstruction12? OriginalPaymentInformationAndStatus { get; init; } 
    #else
    public OriginalPaymentInstruction12? OriginalPaymentInformationAndStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_NasXaxPeEeSVo-TFVwFHvA")]
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
    /// Using the state of this record, returns a populated &lt;seealso cref=&quot;CustomerPaymentStatusReportV06Document&quot;/&gt;, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public CustomerPaymentStatusReportV06Document ToDocument()
    {
        return new CustomerPaymentStatusReportV06Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying &lt;seealso cref=&quot;CustomerPaymentStatusReportV06&quot;/&gt;.
/// </summary>
[Serializable]
public partial record CustomerPaymentStatusReportV06Document : IOuterDocument<CustomerPaymentStatusReportV06>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:pain.002.001.06";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of &lt;seealso cref=&quot;CustomerPaymentStatusReportV06&quot;/&gt; is required.
    /// </summary>
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CustomerPaymentStatusReportV06 Message { get; init; }
    #else
    public CustomerPaymentStatusReportV06 Message { get; init; }
    #endif
}
