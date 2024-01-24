﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AcceptorBatchTransferV05.  ISO2002 ID# _5M7M4Y3FEeWjkqXgn_0Imw.
//
namespace BeneficialStrategies.Iso20022.caaa;

/// <summary>
/// The AcceptorBatchTransfer is sent by an acceptor (or its agent) to transfer the financial data of a collection of transactions to the acquirer (or its agent).
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The AcceptorBatchTransfer is sent by an acceptor (or its agent) to transfer the financial data of a collection of transactions to the acquirer (or its agent).")]
public partial record AcceptorBatchTransferV05 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AccptrBtchTrf";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Batch capture message management information.
    /// </summary>
    [IsoId("_5M7M5Y3FEeWjkqXgn_0Imw")]
    [Description(@"Batch capture message management information.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required SomeHeaderRecord Header { get; init; }
    
    /// <summary>
    /// Card payment transactions from one or several data set of transactions.
    /// </summary>
    [IsoId("_5M7M543FEeWjkqXgn_0Imw")]
    [Description(@"Card payment transactions from one or several data set of transactions.")]
    [DataMember(Name="BtchTrf")]
    [XmlElement(ElementName="BtchTrf")]
    [Required]
    public required SomeBatchTransferRecord BatchTransfer { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC or a digital signature.
    /// </summary>
    [IsoId("_5M7M6Y3FEeWjkqXgn_0Imw")]
    [Description(@"Trailer of the message containing a MAC or a digital signature.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public SomeSecurityTrailerRecord? SecurityTrailer { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AcceptorBatchTransferV05Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AcceptorBatchTransferV05Document ToDocument()
    {
        return new AcceptorBatchTransferV05Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="AcceptorBatchTransferV05"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record AcceptorBatchTransferV05Document : IOuterDocument<AcceptorBatchTransferV05>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caaa.011.001.05";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AcceptorBatchTransferV05"/> is required.
    /// </summary>
    public required AcceptorBatchTransferV05 Message { get; init; }
}
