﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AcceptorReconciliationResponseV01.  ISO2002 ID# _OV5_1aMVEeCJ6YNENx4h-w_2086001955.
//
namespace BeneficialStrategies.Iso20022.caaa;

/// <summary>
/// Scope
/// The AcceptorReconciliationResponse message is sent by the acquirer to communicate to the card acceptor the totals of the card payment transaction performed for the reconciliation period. An agent never forwards the message.
/// Usage
/// The AcceptorReconciliationResponse message is used to compare the totals between a card acceptor and an acquirer for the reconciliation period.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The AcceptorReconciliationResponse message is sent by the acquirer to communicate to the card acceptor the totals of the card payment transaction performed for the reconciliation period. An agent never forwards the message.|Usage|The AcceptorReconciliationResponse message is used to compare the totals between a card acceptor and an acquirer for the reconciliation period.")]
public partial record AcceptorReconciliationResponseV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AccptrRcncltnRspn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Reconciliation response message management information.
    /// </summary>
    [IsoId("_OV5_1qMVEeCJ6YNENx4h-w_1779414946")]
    [Description(@"Reconciliation response message management information.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required SomeHeaderRecord Header { get; init; }
    
    /// <summary>
    /// Information related to thereconciliation response.
    /// </summary>
    [IsoId("_OV5_16MVEeCJ6YNENx4h-w_2117740989")]
    [Description(@"Information related to thereconciliation response.")]
    [DataMember(Name="RcncltnRspn")]
    [XmlElement(ElementName="RcncltnRspn")]
    [Required]
    public required SomeReconciliationResponseRecord ReconciliationResponse { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_OV5_2KMVEeCJ6YNENx4h-w_-1540723473")]
    [Description(@"Trailer of the message containing a MAC.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    [Required]
    public required SomeSecurityTrailerRecord SecurityTrailer { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AcceptorReconciliationResponseV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AcceptorReconciliationResponseV01Document ToDocument()
    {
        return new AcceptorReconciliationResponseV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="AcceptorReconciliationResponseV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record AcceptorReconciliationResponseV01Document : IOuterDocument<AcceptorReconciliationResponseV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caaa.010.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AcceptorReconciliationResponseV01"/> is required.
    /// </summary>
    public required AcceptorReconciliationResponseV01 Message { get; init; }
}