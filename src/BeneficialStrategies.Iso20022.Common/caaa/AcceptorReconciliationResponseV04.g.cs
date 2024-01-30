﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AcceptorReconciliationResponseV04.  ISO2002 ID# _lHle8WmAEeSxgrJ0GX4SQQ.
//
namespace BeneficialStrategies.Iso20022.caaa;

/// <summary>
/// The AcceptorReconciliationResponse message is sent by the acquirer (or its agent) to an acceptor (or its agent), to ensure that the debits and credits performed by the acceptor matches the computed balances of the acquirer for the debits and credits performed during the same reconciliation period.
/// If the acceptor or the acquirer notices a difference in totals, the discrepancy will be resolved by other means, outside the scope of the protocol.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The AcceptorReconciliationResponse message is sent by the acquirer (or its agent) to an acceptor (or its agent), to ensure that the debits and credits performed by the acceptor matches the computed balances of the acquirer for the debits and credits performed during the same reconciliation period.|If the acceptor or the acquirer notices a difference in totals, the discrepancy will be resolved by other means, outside the scope of the protocol.")]
public partial record AcceptorReconciliationResponseV04 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AccptrRcncltnRspn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Reconciliation response message management information.
    /// </summary>
    [IsoId("_lHmGA2mAEeSxgrJ0GX4SQQ")]
    [Description(@"Reconciliation response message management information.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required Header10 Header { get; init; }
    
    /// <summary>
    /// Information related to the reconciliation response.
    /// </summary>
    [IsoId("_lHmGBWmAEeSxgrJ0GX4SQQ")]
    [Description(@"Information related to the reconciliation response.")]
    [DataMember(Name="RcncltnRspn")]
    [XmlElement(ElementName="RcncltnRspn")]
    [Required]
    public required AcceptorReconciliationResponse3 ReconciliationResponse { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_lHmGB2mAEeSxgrJ0GX4SQQ")]
    [Description(@"Trailer of the message containing a MAC.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    [Required]
    public required ContentInformationType11 SecurityTrailer { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AcceptorReconciliationResponseV04Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AcceptorReconciliationResponseV04Document ToDocument()
    {
        return new AcceptorReconciliationResponseV04Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="AcceptorReconciliationResponseV04"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record AcceptorReconciliationResponseV04Document : IOuterDocument<AcceptorReconciliationResponseV04>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caaa.010.001.04";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AcceptorReconciliationResponseV04"/> is required.
    /// </summary>
    public required AcceptorReconciliationResponseV04 Message { get; init; }
}
