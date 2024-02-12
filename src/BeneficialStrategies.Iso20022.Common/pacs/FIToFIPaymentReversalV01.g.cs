﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for FIToFIPaymentReversalV01.  ISO2002 ID# _elKe5dEuEd-BzquC8wXy7w_-1796587382.
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
/// This record is an implementation of the pacs.007.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The FinancialInstitutionToFinancialInstitutionPaymentReversal message is sent by an agent to the next party in the payment chain. It is used to reverse a payment previously executed.
/// Usage
/// The FIToFIPaymentReversal message is exchanged between agents to reverse a FIToFICustomerDirectDebit message that has been settled. The result will be a credit on the debtor account.
/// The FIToFIPaymentReversal message may or may not be the follow-up of a CustomerDirectDebitInitiation message.
/// The FIToFIPaymentReversal message refers to the original FIToFICustomerDirectDebit message by means of references only or by means of references and a set of elements from the original instruction.
/// The FIToFIPaymentReversal message can be used in domestic and cross-border scenarios.
/// 
/// </summary>
[Description(@"Scope|The FinancialInstitutionToFinancialInstitutionPaymentReversal message is sent by an agent to the next party in the payment chain. It is used to reverse a payment previously executed.|Usage|The FIToFIPaymentReversal message is exchanged between agents to reverse a FIToFICustomerDirectDebit message that has been settled. The result will be a credit on the debtor account.|The FIToFIPaymentReversal message may or may not be the follow-up of a CustomerDirectDebitInitiation message.|The FIToFIPaymentReversal message refers to the original FIToFICustomerDirectDebit message by means of references only or by means of references and a set of elements from the original instruction.|The FIToFIPaymentReversal message can be used in domestic and cross-border scenarios.|")]
[IsoId("_elKe5dEuEd-BzquC8wXy7w_-1796587382")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("FI To FI Payment Reversal V")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FIToFIPaymentReversalV01 : IOuterRecord<FIToFIPaymentReversalV01,FIToFIPaymentReversalV01Document>
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "pacs.007.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "pacs.007.001.01";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => FIToFIPaymentReversalV01Document.DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a FIToFIPaymentReversalV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public FIToFIPaymentReversalV01( GroupHeader9 reqGroupHeader,OriginalGroupInformation5 reqOriginalGroupInformation )
    {
        GroupHeader = reqGroupHeader;
        OriginalGroupInformation = reqOriginalGroupInformation;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Set of characteristics shared by all individual transactions included in the message.
    /// </summary>
    [IsoId("_elKe5tEuEd-BzquC8wXy7w_421348727")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Group Header")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required GroupHeader9 GroupHeader { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public GroupHeader9 GroupHeader { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GroupHeader9 GroupHeader { get; init; } 
    #else
    public GroupHeader9 GroupHeader { get; set; } 
    #endif
    
    /// <summary>
    /// Information concerning the original group of transactions, to which the message refers.
    /// </summary>
    [IsoId("_elKe59EuEd-BzquC8wXy7w_357436312")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Original Group Information")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required OriginalGroupInformation5 OriginalGroupInformation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public OriginalGroupInformation5 OriginalGroupInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OriginalGroupInformation5 OriginalGroupInformation { get; init; } 
    #else
    public OriginalGroupInformation5 OriginalGroupInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Information concerning the original transactions, to which the reversal message refers.
    /// </summary>
    [IsoId("_elKe6NEuEd-BzquC8wXy7w_-191011416")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Transaction Information")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentTransactionInformation5? TransactionInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentTransactionInformation5? TransactionInformation { get; init; } 
    #else
    public PaymentTransactionInformation5? TransactionInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="FIToFIPaymentReversalV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public FIToFIPaymentReversalV01Document ToDocument()
    {
        return new FIToFIPaymentReversalV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="FIToFIPaymentReversalV01"/>.
/// </summary>
[Serializable]
public partial record FIToFIPaymentReversalV01Document : IOuterDocument<FIToFIPaymentReversalV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:pacs.007.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="FIToFIPaymentReversalV01"/> is required.
    /// </summary>
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FIToFIPaymentReversalV01 Message { get; init; }
    #else
    public FIToFIPaymentReversalV01 Message { get; init; }
    #endif
}
