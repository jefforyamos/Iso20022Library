﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AcceptorReconciliationRequestV09.  ISO2002 ID# _j7RWsS4_EeunNvJlR_vCbg.
//
namespace BeneficialStrategies.Iso20022.caaa;

/// <summary>
/// The AcceptorReconciliationRequest message is sent by an acceptor (or its agent) to the acquirer (or its agent), to ensure that the debits and credits performed by the acceptor matches the computed balances of the acquirer for the debits and credits performed during the same reconciliation period.
/// If the acceptor or the acquirer notices a difference in totals, the discrepancy will be resolved by other means, outside the scope of the protocol.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The AcceptorReconciliationRequest message is sent by an acceptor (or its agent) to the acquirer (or its agent), to ensure that the debits and credits performed by the acceptor matches the computed balances of the acquirer for the debits and credits performed during the same reconciliation period.|If the acceptor or the acquirer notices a difference in totals, the discrepancy will be resolved by other means, outside the scope of the protocol.")]
public partial record AcceptorReconciliationRequestV09 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AccptrRcncltnReq";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AcceptorReconciliationRequestV09Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AcceptorReconciliationRequestV09Document ToDocument()
    {
        return new AcceptorReconciliationRequestV09Document { Message = this };
    }
}

/// <summary>
/// The AcceptorReconciliationRequest message is sent by an acceptor (or its agent) to the acquirer (or its agent), to ensure that the debits and credits performed by the acceptor matches the computed balances of the acquirer for the debits and credits performed during the same reconciliation period.
/// If the acceptor or the acquirer notices a difference in totals, the discrepancy will be resolved by other means, outside the scope of the protocol.
/// This is the outer document that contains <seealso cref="AcceptorReconciliationRequestV09"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record AcceptorReconciliationRequestV09Document : IOuterDocument<AcceptorReconciliationRequestV09>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caaa.009.001.09";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AcceptorReconciliationRequestV09"/> is required.
    /// </summary>
    public required AcceptorReconciliationRequestV09 Message { get; init; }
}
