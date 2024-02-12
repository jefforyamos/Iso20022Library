﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for FIToFIPaymentStatusRequestV05.  ISO2002 ID# _jMaBadcBEeq_l4BJLVUF2Q.
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


namespace BeneficialStrategies.Iso20022.pacs;

/// <summary>
/// This record is an implementation of the pacs.028.001.05 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The FinancialInstitutionToFinancialInstitutionPaymentStatusRequest message is sent by the debtor agent to the creditor agent, directly or through other agents and/or a payment clearing and settlement system. It is used to request a FIToFIPaymentStatusReport message containing information on the status of a previously sent instruction. 
/// Usage
/// The FIToFIPaymentStatusRequest message is exchanged between agents to request status information about instructions previously sent. Its usage will always be governed by a bilateral agreement between the agents.
/// The FIToFIPaymentStatusRequest message can be used to request information about the status (such as rejection, acceptance) of a credit transfer instruction, a direct debit instruction, as well as other intra-agent instructions (for example FIToFIPaymentCancellationRequest).
/// The FIToFIPaymentStatusRequest message refers to the original instruction(s) by means of references only or by means of references and a set of elements from the original instruction.
/// The FIToFIPaymentStatusRequest message can be used in domestic and cross-border scenarios.
/// 
/// 
/// </summary>
[Description(@"Scope|The FinancialInstitutionToFinancialInstitutionPaymentStatusRequest message is sent by the debtor agent to the creditor agent, directly or through other agents and/or a payment clearing and settlement system. It is used to request a FIToFIPaymentStatusReport message containing information on the status of a previously sent instruction. |Usage|The FIToFIPaymentStatusRequest message is exchanged between agents to request status information about instructions previously sent. Its usage will always be governed by a bilateral agreement between the agents.|The FIToFIPaymentStatusRequest message can be used to request information about the status (such as rejection, acceptance) of a credit transfer instruction, a direct debit instruction, as well as other intra-agent instructions (for example FIToFIPaymentCancellationRequest).|The FIToFIPaymentStatusRequest message refers to the original instruction(s) by means of references only or by means of references and a set of elements from the original instruction.|The FIToFIPaymentStatusRequest message can be used in domestic and cross-border scenarios.||")]
[IsoId("_jMaBadcBEeq_l4BJLVUF2Q")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("FI To FI Payment Status Request V")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FIToFIPaymentStatusRequestV05 : IOuterRecord<FIToFIPaymentStatusRequestV05,FIToFIPaymentStatusRequestV05Document>
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "pacs.028.001.05";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FIToFIPmtStsReq";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => FIToFIPaymentStatusRequestV05Document.DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a FIToFIPaymentStatusRequestV05 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public FIToFIPaymentStatusRequestV05( GroupHeader91 reqGroupHeader )
    {
        GroupHeader = reqGroupHeader;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Set of characteristics shared by all individual transactions included in the status request message.
    /// </summary>
    [IsoId("_jMaoMdcBEeq_l4BJLVUF2Q")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Group Header")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required GroupHeader91 GroupHeader { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public GroupHeader91 GroupHeader { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GroupHeader91 GroupHeader { get; init; } 
    #else
    public GroupHeader91 GroupHeader { get; set; } 
    #endif
    
    /// <summary>
    /// Original group information concerning the group of transactions, to which the status request message refers to.
    /// </summary>
    [IsoId("_jMaoM9cBEeq_l4BJLVUF2Q")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Original Group Information")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OriginalGroupInformation27? OriginalGroupInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OriginalGroupInformation27? OriginalGroupInformation { get; init; } 
    #else
    public OriginalGroupInformation27? OriginalGroupInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Information concerning the original transaction, to which the status request message refers.
    /// </summary>
    [IsoId("_jMaoNdcBEeq_l4BJLVUF2Q")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Transaction Information")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentTransaction131? TransactionInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentTransaction131? TransactionInformation { get; init; } 
    #else
    public PaymentTransaction131? TransactionInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_jMaoN9cBEeq_l4BJLVUF2Q")]
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
    /// Using the state of this record, returns a populated <seealso cref="FIToFIPaymentStatusRequestV05Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public FIToFIPaymentStatusRequestV05Document ToDocument()
    {
        return new FIToFIPaymentStatusRequestV05Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="FIToFIPaymentStatusRequestV05"/>.
/// </summary>
[Serializable]
public partial record FIToFIPaymentStatusRequestV05Document : IOuterDocument<FIToFIPaymentStatusRequestV05>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:pacs.028.001.05";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="FIToFIPaymentStatusRequestV05"/> is required.
    /// </summary>
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FIToFIPaymentStatusRequestV05 Message { get; init; }
    #else
    public FIToFIPaymentStatusRequestV05 Message { get; init; }
    #endif
}
