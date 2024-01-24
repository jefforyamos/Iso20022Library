﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for ReturnTransactionV10.  ISO2002 ID# _jx4toQKxEe2rHs6fbn9-0A.
//
namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// Scope
/// The ReturnTransaction message is sent by the transaction administrator to a member of the system.
/// It is used to provide information on transactions and booked entries held at the transaction administrator.
/// The Return Transaction message can be sent as a response to a related GetTransaction message (pull mode) or initiated by the transaction administrator (push mode). The push of information can take place either at prearranged times or as a warning or alarm when a problem has occurred.
/// Usage
/// Following normal business flows, transactions registered by the transaction administrator may be queued for later settlement (because of insufficient funds available, because of risk or liquidity limits, etc.). A transaction may have a series of statuses. These can be transient (such as pending or related types) and final (such as rejected or settled).
/// Members of a system need to receive information about the payments queue(s) and must have the ability to take action (that is, cancel or modify the transaction(s) to be settled). Note, however, that actions by a member will always concern transactions in a transient status.
/// At any time during operating hours of the system, the member can query the transaction administrator to get information about transactions, whatever their status.
/// These requests will concern either all transactions, all transactions within a particular status or a specific transaction.
/// The member can request information about transactions through a series of criteria, corresponding to the known information stored within the transaction administrator. Based on the criteria received within the request, the transaction administrator will select items that match the request and report them to the requester.
/// The transaction administrator may also send a ReturnTransaction message with pre-defined information at times previously agreed with the member or to warn the member about a particular problem that may have arisen and which needs attention.
/// The message from the transaction administrator can contain information based on the following elements:
/// - provenance or destination of the payment (payment to/payment from)
/// - transaction reference
/// - transfer value date
/// - payment instruction reference
/// - payment instruction status, as registered at the transaction administrator
/// - instructed amount and/or currency
/// - interbank settlement amount and/or currency
/// - credit/debit indicator of the payment instruction/transaction
/// - message used for the payment instruction
/// - priority of the payment transaction
/// - period in which the payment instruction should be processed (processing validity time)
/// - instructions given, related to the processing of the transaction
/// - type of payment instructed
/// - account identification (entries booked to a specific account)
/// - entry amount and/or currency
/// - entry debit/credit indicator (if absent, all entries should be reported)
/// - status of the entry (pending, booked.)
/// - entry date and time
/// - currency of the account
/// - type of the account
/// - entry reference
/// - entry date
/// - transfer reason
/// - details related to the status of the payment instruction
/// An element that is particular to the Get/Return Transaction pair is the Statement Report. When a GetTransaction message is sent requesting a statement report, the related ReturnTransaction message will provide a pre-defined set of return criteria per transaction. The information returned contains the following details for each transaction:
/// - value date
/// - entry date
/// - debit/credit code
/// - entry amount
/// - method of payment (payment instrument or message type)
/// - entry reference
/// - transaction reference
/// - supplementary details
/// Additional information on the generic design of the Get/Return messages can be found in the section How to Use the Cash Management Messages.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The ReturnTransaction message is sent by the transaction administrator to a member of the system.|It is used to provide information on transactions and booked entries held at the transaction administrator.|The Return Transaction message can be sent as a response to a related GetTransaction message (pull mode) or initiated by the transaction administrator (push mode). The push of information can take place either at prearranged times or as a warning or alarm when a problem has occurred.|Usage|Following normal business flows, transactions registered by the transaction administrator may be queued for later settlement (because of insufficient funds available, because of risk or liquidity limits, etc.). A transaction may have a series of statuses. These can be transient (such as pending or related types) and final (such as rejected or settled).|Members of a system need to receive information about the payments queue(s) and must have the ability to take action (that is, cancel or modify the transaction(s) to be settled). Note, however, that actions by a member will always concern transactions in a transient status.|At any time during operating hours of the system, the member can query the transaction administrator to get information about transactions, whatever their status.|These requests will concern either all transactions, all transactions within a particular status or a specific transaction.|The member can request information about transactions through a series of criteria, corresponding to the known information stored within the transaction administrator. Based on the criteria received within the request, the transaction administrator will select items that match the request and report them to the requester.|The transaction administrator may also send a ReturnTransaction message with pre-defined information at times previously agreed with the member or to warn the member about a particular problem that may have arisen and which needs attention.|The message from the transaction administrator can contain information based on the following elements:|- provenance or destination of the payment (payment to/payment from)|- transaction reference|- transfer value date|- payment instruction reference|- payment instruction status, as registered at the transaction administrator|- instructed amount and/or currency|- interbank settlement amount and/or currency|- credit/debit indicator of the payment instruction/transaction|- message used for the payment instruction|- priority of the payment transaction|- period in which the payment instruction should be processed (processing validity time)|- instructions given, related to the processing of the transaction|- type of payment instructed|- account identification (entries booked to a specific account)|- entry amount and/or currency|- entry debit/credit indicator (if absent, all entries should be reported)|- status of the entry (pending, booked.)|- entry date and time|- currency of the account|- type of the account|- entry reference|- entry date|- transfer reason|- details related to the status of the payment instruction|An element that is particular to the Get/Return Transaction pair is the Statement Report. When a GetTransaction message is sent requesting a statement report, the related ReturnTransaction message will provide a pre-defined set of return criteria per transaction. The information returned contains the following details for each transaction:|- value date|- entry date|- debit/credit code|- entry amount|- method of payment (payment instrument or message type)|- entry reference|- transaction reference|- supplementary details|Additional information on the generic design of the Get/Return messages can be found in the section How to Use the Cash Management Messages.")]
public partial record ReturnTransactionV10 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "RtrTx";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="ReturnTransactionV10Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public ReturnTransactionV10Document ToDocument()
    {
        return new ReturnTransactionV10Document { Message = this };
    }
}

/// <summary>
/// Scope
/// The ReturnTransaction message is sent by the transaction administrator to a member of the system.
/// It is used to provide information on transactions and booked entries held at the transaction administrator.
/// The Return Transaction message can be sent as a response to a related GetTransaction message (pull mode) or initiated by the transaction administrator (push mode). The push of information can take place either at prearranged times or as a warning or alarm when a problem has occurred.
/// Usage
/// Following normal business flows, transactions registered by the transaction administrator may be queued for later settlement (because of insufficient funds available, because of risk or liquidity limits, etc.). A transaction may have a series of statuses. These can be transient (such as pending or related types) and final (such as rejected or settled).
/// Members of a system need to receive information about the payments queue(s) and must have the ability to take action (that is, cancel or modify the transaction(s) to be settled). Note, however, that actions by a member will always concern transactions in a transient status.
/// At any time during operating hours of the system, the member can query the transaction administrator to get information about transactions, whatever their status.
/// These requests will concern either all transactions, all transactions within a particular status or a specific transaction.
/// The member can request information about transactions through a series of criteria, corresponding to the known information stored within the transaction administrator. Based on the criteria received within the request, the transaction administrator will select items that match the request and report them to the requester.
/// The transaction administrator may also send a ReturnTransaction message with pre-defined information at times previously agreed with the member or to warn the member about a particular problem that may have arisen and which needs attention.
/// The message from the transaction administrator can contain information based on the following elements:
/// - provenance or destination of the payment (payment to/payment from)
/// - transaction reference
/// - transfer value date
/// - payment instruction reference
/// - payment instruction status, as registered at the transaction administrator
/// - instructed amount and/or currency
/// - interbank settlement amount and/or currency
/// - credit/debit indicator of the payment instruction/transaction
/// - message used for the payment instruction
/// - priority of the payment transaction
/// - period in which the payment instruction should be processed (processing validity time)
/// - instructions given, related to the processing of the transaction
/// - type of payment instructed
/// - account identification (entries booked to a specific account)
/// - entry amount and/or currency
/// - entry debit/credit indicator (if absent, all entries should be reported)
/// - status of the entry (pending, booked.)
/// - entry date and time
/// - currency of the account
/// - type of the account
/// - entry reference
/// - entry date
/// - transfer reason
/// - details related to the status of the payment instruction
/// An element that is particular to the Get/Return Transaction pair is the Statement Report. When a GetTransaction message is sent requesting a statement report, the related ReturnTransaction message will provide a pre-defined set of return criteria per transaction. The information returned contains the following details for each transaction:
/// - value date
/// - entry date
/// - debit/credit code
/// - entry amount
/// - method of payment (payment instrument or message type)
/// - entry reference
/// - transaction reference
/// - supplementary details
/// Additional information on the generic design of the Get/Return messages can be found in the section How to Use the Cash Management Messages.
/// This is the outer document that contains <seealso cref="ReturnTransactionV10"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record ReturnTransactionV10Document : IOuterDocument<ReturnTransactionV10>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.006.001.10";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="ReturnTransactionV10"/> is required.
    /// </summary>
    public required ReturnTransactionV10 Message { get; init; }
}
