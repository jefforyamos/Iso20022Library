﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for GetTransactionV09.  ISO2002 ID# _ThPM_db6Eeq_l4BJLVUF2Q.
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


namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// This record is an implementation of the camt.005.001.09 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The GetTransaction message is sent by a member to the transaction administrator.
/// It is used to request information about payment instructions held at the transaction administrator. Payment instructions are either sent by the member, debiting or crediting its account at the transaction administrator or received by the transaction administrator, crediting or debiting the member&apos;s account.
/// Usage
/// Following normal business flows, transactions registered by the transaction administrator may be queued for later settlement (because of insufficient funds available, or because of risk or liquidity limits, etc.). A transaction may have a series of statuses. These can be transient (such as pending or related types) and final (such as rejected, revoked and/or settled).
/// Members of a system need to have information about the payments queue(s) and must have the ability to take action (that is, to cancel or modify the transaction(s) to be settled). Note, however, that actions by a member will always concern transactions in a transient status.
/// At any time during the operating hours of the system, the member can query the transaction administrator to get information about transactions, whatever their status.
/// These requests will concern either all transactions, all transactions with a particular status or a specific transaction.
/// The member can request information about transactions through a series of criteria, corresponding to the known information stored at the transaction administrator, based on the following elements:
/// - provenance or destination of the payment (payment to/payment from)
/// - transaction reference
/// - transfer value date
/// - payment instruction reference
/// - payment instruction status, as registered at the transaction administrator
/// - instructed amount and/or currency
/// - interbank settlement amount and/or currency
/// - credit/debit indicator of the payment instruction/transaction
/// - SWIFT FIN payment message used for the payment instruction
/// - priority of the payment transaction
/// - period in which the payment instruction should be processed (processing validity time)
/// - instructions given, related to the processing of the transaction
/// - type of payment instructed
/// - account identification (entries booked to a specific account)
/// - entry amount and/or currency
/// - entry debit/credit indicator (if absent, all entries should be reported).
/// </summary>
[Description(@"Scope|The GetTransaction message is sent by a member to the transaction administrator.|It is used to request information about payment instructions held at the transaction administrator. Payment instructions are either sent by the member, debiting or crediting its account at the transaction administrator or received by the transaction administrator, crediting or debiting the member's account.|Usage|Following normal business flows, transactions registered by the transaction administrator may be queued for later settlement (because of insufficient funds available, or because of risk or liquidity limits, etc.). A transaction may have a series of statuses. These can be transient (such as pending or related types) and final (such as rejected, revoked and/or settled).|Members of a system need to have information about the payments queue(s) and must have the ability to take action (that is, to cancel or modify the transaction(s) to be settled). Note, however, that actions by a member will always concern transactions in a transient status.|At any time during the operating hours of the system, the member can query the transaction administrator to get information about transactions, whatever their status.|These requests will concern either all transactions, all transactions with a particular status or a specific transaction.|The member can request information about transactions through a series of criteria, corresponding to the known information stored at the transaction administrator, based on the following elements:|- provenance or destination of the payment (payment to/payment from)|- transaction reference|- transfer value date|- payment instruction reference|- payment instruction status, as registered at the transaction administrator|- instructed amount and/or currency|- interbank settlement amount and/or currency|- credit/debit indicator of the payment instruction/transaction|- SWIFT FIN payment message used for the payment instruction|- priority of the payment transaction|- period in which the payment instruction should be processed (processing validity time)|- instructions given, related to the processing of the transaction|- type of payment instructed|- account identification (entries booked to a specific account)|- entry amount and/or currency|- entry debit/credit indicator (if absent, all entries should be reported).")]
[IsoId("_ThPM_db6Eeq_l4BJLVUF2Q")]
[DisplayName("Get Transaction V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record GetTransactionV09 : IOuterRecord<GetTransactionV09,GetTransactionV09Document>
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.005.001.09";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "GetTx";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => GetTransactionV09Document.DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a GetTransactionV09 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public GetTransactionV09( MessageHeader9 reqMessageHeader )
    {
        MessageHeader = reqMessageHeader;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Common business identification for the message.
    /// </summary>
    [IsoId("_ThPNA9b6Eeq_l4BJLVUF2Q")]
    [DisplayName("Message Header")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgHdr")]
    #endif
    [IsoXmlTag("MsgHdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageHeader9 MessageHeader { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MessageHeader9 MessageHeader { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageHeader9 MessageHeader { get; init; } 
    #else
    public MessageHeader9 MessageHeader { get; set; } 
    #endif
    
    /// <summary>
    /// Defines the transaction query criteria.
    /// </summary>
    [IsoId("_ThPNBdb6Eeq_l4BJLVUF2Q")]
    [DisplayName("Transaction Query Definition")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxQryDef")]
    #endif
    [IsoXmlTag("TxQryDef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionQuery6? TransactionQueryDefinition { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionQuery6? TransactionQueryDefinition { get; init; } 
    #else
    public TransactionQuery6? TransactionQueryDefinition { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_ThPNB9b6Eeq_l4BJLVUF2Q")]
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
    /// Using the state of this record, returns a populated &lt;seealso cref=&quot;GetTransactionV09Document&quot;/&gt;, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public GetTransactionV09Document ToDocument()
    {
        return new GetTransactionV09Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying &lt;seealso cref=&quot;GetTransactionV09&quot;/&gt;.
/// </summary>
[Serializable]
public partial record GetTransactionV09Document : IOuterDocument<GetTransactionV09>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.005.001.09";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of &lt;seealso cref=&quot;GetTransactionV09&quot;/&gt; is required.
    /// </summary>
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required GetTransactionV09 Message { get; init; }
    #else
    public GetTransactionV09 Message { get; init; }
    #endif
}
