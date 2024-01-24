﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for GetTransactionV10.  ISO2002 ID# _jx3fgQKxEe2rHs6fbn9-0A.
//
namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// Scope
/// The GetTransaction message is sent by a member to the transaction administrator.
/// It is used to request information about payment instructions held at the transaction administrator. Payment instructions are either sent by the member, debiting or crediting its account at the transaction administrator or received by the transaction administrator, crediting or debiting the member's account.
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
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The GetTransaction message is sent by a member to the transaction administrator.|It is used to request information about payment instructions held at the transaction administrator. Payment instructions are either sent by the member, debiting or crediting its account at the transaction administrator or received by the transaction administrator, crediting or debiting the member's account.|Usage|Following normal business flows, transactions registered by the transaction administrator may be queued for later settlement (because of insufficient funds available, or because of risk or liquidity limits, etc.). A transaction may have a series of statuses. These can be transient (such as pending or related types) and final (such as rejected, revoked and/or settled).|Members of a system need to have information about the payments queue(s) and must have the ability to take action (that is, to cancel or modify the transaction(s) to be settled). Note, however, that actions by a member will always concern transactions in a transient status.|At any time during the operating hours of the system, the member can query the transaction administrator to get information about transactions, whatever their status.|These requests will concern either all transactions, all transactions with a particular status or a specific transaction.|The member can request information about transactions through a series of criteria, corresponding to the known information stored at the transaction administrator, based on the following elements:|- provenance or destination of the payment (payment to/payment from)|- transaction reference|- transfer value date|- payment instruction reference|- payment instruction status, as registered at the transaction administrator|- instructed amount and/or currency|- interbank settlement amount and/or currency|- credit/debit indicator of the payment instruction/transaction|- SWIFT FIN payment message used for the payment instruction|- priority of the payment transaction|- period in which the payment instruction should be processed (processing validity time)|- instructions given, related to the processing of the transaction|- type of payment instructed|- account identification (entries booked to a specific account)|- entry amount and/or currency|- entry debit/credit indicator (if absent, all entries should be reported).")]
public partial record GetTransactionV10 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "GetTx";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Common business identification for the message.
    /// </summary>
    [IsoId("_jx4GlwKxEe2rHs6fbn9-0A")]
    [Description(@"Common business identification for the message.")]
    [DataMember(Name="MsgHdr")]
    [XmlElement(ElementName="MsgHdr")]
    [Required]
    public required SomeMessageHeaderRecord MessageHeader { get; init; }
    
    /// <summary>
    /// Defines the transaction query criteria.
    /// </summary>
    [IsoId("_jx4GmQKxEe2rHs6fbn9-0A")]
    [Description(@"Defines the transaction query criteria.")]
    [DataMember(Name="TxQryDef")]
    [XmlElement(ElementName="TxQryDef")]
    public SomeTransactionQueryDefinitionRecord? TransactionQueryDefinition { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_jx4GmwKxEe2rHs6fbn9-0A")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SomeSupplementaryDataRecord? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="GetTransactionV10Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public GetTransactionV10Document ToDocument()
    {
        return new GetTransactionV10Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="GetTransactionV10"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record GetTransactionV10Document : IOuterDocument<GetTransactionV10>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.005.001.10";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="GetTransactionV10"/> is required.
    /// </summary>
    public required GetTransactionV10 Message { get; init; }
}
