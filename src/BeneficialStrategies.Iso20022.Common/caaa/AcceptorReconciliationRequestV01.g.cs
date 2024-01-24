﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AcceptorReconciliationRequestV01.  ISO2002 ID# _PNo5FaMVEeCJ6YNENx4h-w_-594784238.
//
namespace BeneficialStrategies.Iso20022.caaa;

/// <summary>
/// Scope
/// The AcceptorReconciliationRequest message is sent by the card acceptor to the acquirer or an agent to communicate the totals of the card payment transaction for a reconciliation period. An agent never forwards the message.
/// Usage
/// The AcceptorReconciliationRequest message is used to ensure that the debits and credits correspond to the balances computed by the acquirer or its agent for the same reconciliation period.
/// The AcceptorReconciliationRequest message is also used to close a reconciliation period.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The AcceptorReconciliationRequest message is sent by the card acceptor to the acquirer or an agent to communicate the totals of the card payment transaction for a reconciliation period. An agent never forwards the message.|Usage|The AcceptorReconciliationRequest message is used to ensure that the debits and credits correspond to the balances computed by the acquirer or its agent for the same reconciliation period.|The AcceptorReconciliationRequest message is also used to close a reconciliation period.")]
public partial record AcceptorReconciliationRequestV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AccptrRcncltnReq";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AcceptorReconciliationRequestV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AcceptorReconciliationRequestV01Document ToDocument()
    {
        return new AcceptorReconciliationRequestV01Document { Message = this };
    }
}

/// <summary>
/// Scope
/// The AcceptorReconciliationRequest message is sent by the card acceptor to the acquirer or an agent to communicate the totals of the card payment transaction for a reconciliation period. An agent never forwards the message.
/// Usage
/// The AcceptorReconciliationRequest message is used to ensure that the debits and credits correspond to the balances computed by the acquirer or its agent for the same reconciliation period.
/// The AcceptorReconciliationRequest message is also used to close a reconciliation period.
/// This is the outer document that contains <seealso cref="AcceptorReconciliationRequestV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record AcceptorReconciliationRequestV01Document : IOuterDocument<AcceptorReconciliationRequestV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caaa.009.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AcceptorReconciliationRequestV01"/> is required.
    /// </summary>
    public required AcceptorReconciliationRequestV01 Message { get; init; }
}
