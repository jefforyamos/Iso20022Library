﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for CustomerPaymentReversalV09.  ISO2002 ID# _eYI_x22PEei3KuUgpx7Xcw.
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
/// This record is an implementation of the pain.007.001.09 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The CustomerPaymentReversal message is sent by the initiating party to the next party in the payment chain. It is used to reverse a payment previously executed.
/// Usage
/// The CustomerPaymentReversal message is exchanged between a non-financial institution customer and an agent to reverse a CustomerDirectDebitInitiation message that has been settled. The result will be a credit on the debtor account.
/// The CustomerPaymentReversal message refers to the original CustomerDirectDebitInitiation message by means of references only or by means of references and a set of elements from the original instruction.
/// The CustomerPaymentReversal message can be used in domestic and cross-border scenarios.
/// </summary>
[Description(@"Scope|The CustomerPaymentReversal message is sent by the initiating party to the next party in the payment chain. It is used to reverse a payment previously executed.|Usage|The CustomerPaymentReversal message is exchanged between a non-financial institution customer and an agent to reverse a CustomerDirectDebitInitiation message that has been settled. The result will be a credit on the debtor account.|The CustomerPaymentReversal message refers to the original CustomerDirectDebitInitiation message by means of references only or by means of references and a set of elements from the original instruction.|The CustomerPaymentReversal message can be used in domestic and cross-border scenarios.")]
[IsoId("_eYI_x22PEei3KuUgpx7Xcw")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Customer Payment Reversal V")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CustomerPaymentReversalV09 : IOuterRecord<CustomerPaymentReversalV09,CustomerPaymentReversalV09Document>
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "pain.007.001.09";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CstmrPmtRvsl";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => CustomerPaymentReversalV09Document.DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CustomerPaymentReversalV09 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CustomerPaymentReversalV09( GroupHeader88 reqGroupHeader,OriginalGroupHeader16 reqOriginalGroupInformation )
    {
        GroupHeader = reqGroupHeader;
        OriginalGroupInformation = reqOriginalGroupInformation;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Set of characteristics shared by all individual transactions included in the message.
    /// </summary>
    [IsoId("_eYI_022PEei3KuUgpx7Xcw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Group Header")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required GroupHeader88 GroupHeader { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public GroupHeader88 GroupHeader { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GroupHeader88 GroupHeader { get; init; } 
    #else
    public GroupHeader88 GroupHeader { get; set; } 
    #endif
    
    /// <summary>
    /// Information concerning the original group of transactions, to which the message refers.
    /// </summary>
    [IsoId("_eYI_1W2PEei3KuUgpx7Xcw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Original Group Information")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required OriginalGroupHeader16 OriginalGroupInformation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public OriginalGroupHeader16 OriginalGroupInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OriginalGroupHeader16 OriginalGroupInformation { get; init; } 
    #else
    public OriginalGroupHeader16 OriginalGroupInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Information concerning the original payment information, to which the reversal message refers.
    /// </summary>
    [IsoId("_eYI_122PEei3KuUgpx7Xcw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Original Payment Information And Reversal")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OriginalPaymentInstruction33? OriginalPaymentInformationAndReversal { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OriginalPaymentInstruction33? OriginalPaymentInformationAndReversal { get; init; } 
    #else
    public OriginalPaymentInstruction33? OriginalPaymentInformationAndReversal { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_eYI_2W2PEei3KuUgpx7Xcw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Supplementary Data")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SupplementaryData1? SupplementaryData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SupplementaryData1? SupplementaryData { get; init; } 
    #else
    public SupplementaryData1? SupplementaryData { get; set; } 
    #endif
    
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="CustomerPaymentReversalV09Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public CustomerPaymentReversalV09Document ToDocument()
    {
        return new CustomerPaymentReversalV09Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="CustomerPaymentReversalV09"/>.
/// </summary>
[Serializable]
public partial record CustomerPaymentReversalV09Document : IOuterDocument<CustomerPaymentReversalV09>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:pain.007.001.09";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="CustomerPaymentReversalV09"/> is required.
    /// </summary>
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CustomerPaymentReversalV09 Message { get; init; }
    #else
    public CustomerPaymentReversalV09 Message { get; init; }
    #endif
}
