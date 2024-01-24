﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for CustomerCreditTransferInitiationV04.  ISO2002 ID# _r-Z7IFkyEeGeoaLUQk__nA_834448268.
//
namespace BeneficialStrategies.Iso20022.pain;

/// <summary>
/// Scope
/// The CustomerCreditTransferInitiation message is sent by the initiating party to the forwarding agent or debtor agent. It is used to request movement of funds from the debtor account to a creditor.
/// Usage
/// The CustomerCreditTransferInitiation message can contain one or more customer credit transfer instructions.
/// The CustomerCreditTransferInitiation message is used to exchange:
/// - One or more instances of a credit transfer initiation;
/// - Payment transactions that result in book transfers at the debtor agent or payments to another financial institution;
/// - Payment transactions that result in an electronic cash transfer to the creditor account or in the emission of a cheque.
/// The message can be used in a direct or a relay scenario:
/// - In a direct scenario, the message is sent directly to the debtor agent. The debtor agent is the account servicer of the debtor.
/// - In a relay scenario, the message is sent to a forwarding agent. The forwarding agent acts as a concentrating financial institution. It will forward the CustomerCreditTransferInitiation message to the debtor agent.
/// The message can also be used by an initiating party that has authority to send the message on behalf of the debtor. This caters for example for the scenario of a payments factory initiating all payments on behalf of a large corporate.
/// The CustomerCreditTransferInitiation message can be used in domestic and cross-border scenarios.
/// The CustomerCreditTransferInitiation message must not be used by the debtor agent to execute the credit transfer instruction(s). The FIToFICustomerCreditTransfer message must be used instead.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The CustomerCreditTransferInitiation message is sent by the initiating party to the forwarding agent or debtor agent. It is used to request movement of funds from the debtor account to a creditor.|Usage|The CustomerCreditTransferInitiation message can contain one or more customer credit transfer instructions.|The CustomerCreditTransferInitiation message is used to exchange:|- One or more instances of a credit transfer initiation;|- Payment transactions that result in book transfers at the debtor agent or payments to another financial institution;|- Payment transactions that result in an electronic cash transfer to the creditor account or in the emission of a cheque.|The message can be used in a direct or a relay scenario:|- In a direct scenario, the message is sent directly to the debtor agent. The debtor agent is the account servicer of the debtor.|- In a relay scenario, the message is sent to a forwarding agent. The forwarding agent acts as a concentrating financial institution. It will forward the CustomerCreditTransferInitiation message to the debtor agent.|The message can also be used by an initiating party that has authority to send the message on behalf of the debtor. This caters for example for the scenario of a payments factory initiating all payments on behalf of a large corporate.|The CustomerCreditTransferInitiation message can be used in domestic and cross-border scenarios.|The CustomerCreditTransferInitiation message must not be used by the debtor agent to execute the credit transfer instruction(s). The FIToFICustomerCreditTransfer message must be used instead.")]
public partial record CustomerCreditTransferInitiationV04 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CstmrCdtTrfInitn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="CustomerCreditTransferInitiationV04Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public CustomerCreditTransferInitiationV04Document ToDocument()
    {
        return new CustomerCreditTransferInitiationV04Document { Message = this };
    }
}

/// <summary>
/// Scope
/// The CustomerCreditTransferInitiation message is sent by the initiating party to the forwarding agent or debtor agent. It is used to request movement of funds from the debtor account to a creditor.
/// Usage
/// The CustomerCreditTransferInitiation message can contain one or more customer credit transfer instructions.
/// The CustomerCreditTransferInitiation message is used to exchange:
/// - One or more instances of a credit transfer initiation;
/// - Payment transactions that result in book transfers at the debtor agent or payments to another financial institution;
/// - Payment transactions that result in an electronic cash transfer to the creditor account or in the emission of a cheque.
/// The message can be used in a direct or a relay scenario:
/// - In a direct scenario, the message is sent directly to the debtor agent. The debtor agent is the account servicer of the debtor.
/// - In a relay scenario, the message is sent to a forwarding agent. The forwarding agent acts as a concentrating financial institution. It will forward the CustomerCreditTransferInitiation message to the debtor agent.
/// The message can also be used by an initiating party that has authority to send the message on behalf of the debtor. This caters for example for the scenario of a payments factory initiating all payments on behalf of a large corporate.
/// The CustomerCreditTransferInitiation message can be used in domestic and cross-border scenarios.
/// The CustomerCreditTransferInitiation message must not be used by the debtor agent to execute the credit transfer instruction(s). The FIToFICustomerCreditTransfer message must be used instead.
/// This is the outer document that contains <seealso cref="CustomerCreditTransferInitiationV04"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record CustomerCreditTransferInitiationV04Document : IOuterDocument<CustomerCreditTransferInitiationV04>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.04";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="CustomerCreditTransferInitiationV04"/> is required.
    /// </summary>
    public required CustomerCreditTransferInitiationV04 Message { get; init; }
}
