﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AcceptorDiagnosticRequestV08.  ISO2002 ID# _DS7ioQukEeqw5uEXxQ9H4g.
//
namespace BeneficialStrategies.Iso20022.caaa;

/// <summary>
/// The AcceptorDiagnosticRequest message is sent by an acceptor (or its agent) to the acquirer (or its agent), to check the end-to-end communication, to test the availability of this acquirer, or to validate the security environment.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The AcceptorDiagnosticRequest message is sent by an acceptor (or its agent) to the acquirer (or its agent), to check the end-to-end communication, to test the availability of this acquirer, or to validate the security environment.")]
public partial record AcceptorDiagnosticRequestV08 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AccptrDgnstcReq";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Diagnostic request message management information.
    /// </summary>
    [IsoId("_DS7ipQukEeqw5uEXxQ9H4g")]
    [Description(@"Diagnostic request message management information.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required Header58 Header { get; init; }
    
    /// <summary>
    /// Information related to the diagnostic request.
    /// </summary>
    [IsoId("_DS7ipwukEeqw5uEXxQ9H4g")]
    [Description(@"Information related to the diagnostic request.")]
    [DataMember(Name="DgnstcReq")]
    [XmlElement(ElementName="DgnstcReq")]
    [Required]
    public required AcceptorDiagnosticRequest8 DiagnosticRequest { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_DS7iqQukEeqw5uEXxQ9H4g")]
    [Description(@"Trailer of the message containing a MAC.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public ContentInformationType24? SecurityTrailer { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AcceptorDiagnosticRequestV08Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AcceptorDiagnosticRequestV08Document ToDocument()
    {
        return new AcceptorDiagnosticRequestV08Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="AcceptorDiagnosticRequestV08"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record AcceptorDiagnosticRequestV08Document : IOuterDocument<AcceptorDiagnosticRequestV08>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caaa.013.001.08";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AcceptorDiagnosticRequestV08"/> is required.
    /// </summary>
    public required AcceptorDiagnosticRequestV08 Message { get; init; }
}
