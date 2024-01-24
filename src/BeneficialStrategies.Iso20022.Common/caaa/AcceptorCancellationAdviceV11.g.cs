﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AcceptorCancellationAdviceV11.  ISO2002 ID# _fursEU1FEeybj420QgWBkA.
//
namespace BeneficialStrategies.Iso20022.caaa;

/// <summary>
/// The AcceptorCancellationAdvice message is sent by an acceptor (or its agent) to notify the acquirer (or its agent) of the cancellation of a successfully completed transaction. The transaction has been completed without financial transfer, or the acceptor is aware that the transaction was not cleared by the acquirer.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The AcceptorCancellationAdvice message is sent by an acceptor (or its agent) to notify the acquirer (or its agent) of the cancellation of a successfully completed transaction. The transaction has been completed without financial transfer, or the acceptor is aware that the transaction was not cleared by the acquirer.")]
public partial record AcceptorCancellationAdviceV11 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AccptrCxlAdvc";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Cancellation advice message management information.
    /// </summary>
    [IsoId("_fursFU1FEeybj420QgWBkA")]
    [Description(@"Cancellation advice message management information.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required SomeHeaderRecord Header { get; init; }
    
    /// <summary>
    /// Information related to the cancellation advice.
    /// </summary>
    [IsoId("_fursF01FEeybj420QgWBkA")]
    [Description(@"Information related to the cancellation advice.")]
    [DataMember(Name="CxlAdvc")]
    [XmlElement(ElementName="CxlAdvc")]
    [Required]
    public required SomeCancellationAdviceRecord CancellationAdvice { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_fursGU1FEeybj420QgWBkA")]
    [Description(@"Trailer of the message containing a MAC.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public SomeSecurityTrailerRecord? SecurityTrailer { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AcceptorCancellationAdviceV11Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AcceptorCancellationAdviceV11Document ToDocument()
    {
        return new AcceptorCancellationAdviceV11Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="AcceptorCancellationAdviceV11"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record AcceptorCancellationAdviceV11Document : IOuterDocument<AcceptorCancellationAdviceV11>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caaa.007.001.11";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AcceptorCancellationAdviceV11"/> is required.
    /// </summary>
    public required AcceptorCancellationAdviceV11 Message { get; init; }
}
