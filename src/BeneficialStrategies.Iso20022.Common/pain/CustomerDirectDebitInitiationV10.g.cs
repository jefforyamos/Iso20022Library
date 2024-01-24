﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for CustomerDirectDebitInitiationV10.  ISO2002 ID# _rUYN0dcBEeq_l4BJLVUF2Q.
//
namespace BeneficialStrategies.Iso20022.pain;

/// <summary>
/// Scope
/// The CustomerDirectDebitInitiation message is sent by the initiating party to the forwarding agent or creditor agent. It is used to request single or bulk collection(s) of funds from one or various debtor's account(s) for a creditor.
/// Usage
/// The CustomerDirectDebitInitiation message can contain one or more direct debit instructions.
/// The message can be used in a direct or a relay scenario:
/// - In a direct scenario, the message is sent directly to the creditor agent. The creditor agent is the account servicer of the creditor.
/// - In a relay scenario, the message is sent to a forwarding agent. The forwarding agent acts as a concentrating financial institution. It will forward the CustomerDirectDebitInitiation message to the creditor agent.
/// The message can also be used by an initiating party that has authority to send the message on behalf of the creditor. This caters for example for the scenario of a payments factory initiating all payments on behalf of a large corporate.
/// The CustomerDirectDebitInitiation message can be used in domestic and cross-border scenarios.
/// The CustomerDirectDebitInitiation may or may not contain mandate related information, i.e. extracts from a mandate, such as MandateIdentification or DateOfSignature. The CustomerDirectDebitInitiation message must not be considered as a mandate.
/// The CustomerDirectDebitInitiation message must not be used by the creditor agent to execute the direct debit instruction(s). The FIToFICustomerDirectDebit message must be used instead.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The CustomerDirectDebitInitiation message is sent by the initiating party to the forwarding agent or creditor agent. It is used to request single or bulk collection(s) of funds from one or various debtor's account(s) for a creditor.|Usage|The CustomerDirectDebitInitiation message can contain one or more direct debit instructions.|The message can be used in a direct or a relay scenario:|- In a direct scenario, the message is sent directly to the creditor agent. The creditor agent is the account servicer of the creditor.|- In a relay scenario, the message is sent to a forwarding agent. The forwarding agent acts as a concentrating financial institution. It will forward the CustomerDirectDebitInitiation message to the creditor agent.|The message can also be used by an initiating party that has authority to send the message on behalf of the creditor. This caters for example for the scenario of a payments factory initiating all payments on behalf of a large corporate.|The CustomerDirectDebitInitiation message can be used in domestic and cross-border scenarios.|The CustomerDirectDebitInitiation may or may not contain mandate related information, i.e. extracts from a mandate, such as MandateIdentification or DateOfSignature. The CustomerDirectDebitInitiation message must not be considered as a mandate.|The CustomerDirectDebitInitiation message must not be used by the creditor agent to execute the direct debit instruction(s). The FIToFICustomerDirectDebit message must be used instead.")]
public partial record CustomerDirectDebitInitiationV10 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CstmrDrctDbtInitn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="CustomerDirectDebitInitiationV10Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public CustomerDirectDebitInitiationV10Document ToDocument()
    {
        return new CustomerDirectDebitInitiationV10Document { Message = this };
    }
}

/// <summary>
/// Scope
/// The CustomerDirectDebitInitiation message is sent by the initiating party to the forwarding agent or creditor agent. It is used to request single or bulk collection(s) of funds from one or various debtor's account(s) for a creditor.
/// Usage
/// The CustomerDirectDebitInitiation message can contain one or more direct debit instructions.
/// The message can be used in a direct or a relay scenario:
/// - In a direct scenario, the message is sent directly to the creditor agent. The creditor agent is the account servicer of the creditor.
/// - In a relay scenario, the message is sent to a forwarding agent. The forwarding agent acts as a concentrating financial institution. It will forward the CustomerDirectDebitInitiation message to the creditor agent.
/// The message can also be used by an initiating party that has authority to send the message on behalf of the creditor. This caters for example for the scenario of a payments factory initiating all payments on behalf of a large corporate.
/// The CustomerDirectDebitInitiation message can be used in domestic and cross-border scenarios.
/// The CustomerDirectDebitInitiation may or may not contain mandate related information, i.e. extracts from a mandate, such as MandateIdentification or DateOfSignature. The CustomerDirectDebitInitiation message must not be considered as a mandate.
/// The CustomerDirectDebitInitiation message must not be used by the creditor agent to execute the direct debit instruction(s). The FIToFICustomerDirectDebit message must be used instead.
/// This is the outer document that contains <seealso cref="CustomerDirectDebitInitiationV10"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record CustomerDirectDebitInitiationV10Document : IOuterDocument<CustomerDirectDebitInitiationV10>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.10";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="CustomerDirectDebitInitiationV10"/> is required.
    /// </summary>
    public required CustomerDirectDebitInitiationV10 Message { get; init; }
}
