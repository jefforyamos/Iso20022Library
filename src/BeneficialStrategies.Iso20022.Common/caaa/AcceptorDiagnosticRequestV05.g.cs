﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AcceptorDiagnosticRequestV05.  ISO2002 ID# _fSm6wY3XEeW56qaqQ8B0kQ.
//
namespace BeneficialStrategies.Iso20022.caaa;

/// <summary>
/// The AcceptorDiagnosticRequest message is sent by an acceptor (or its agent) to the acquirer (or its agent), to check the end-to-end communication, to test the availability of this acquirer, or to validate the security environment.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The AcceptorDiagnosticRequest message is sent by an acceptor (or its agent) to the acquirer (or its agent), to check the end-to-end communication, to test the availability of this acquirer, or to validate the security environment.")]
public partial record AcceptorDiagnosticRequestV05 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AccptrDgnstcReq";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Diagnostic request message management information.
    /// </summary>
    [IsoId("_fSm6xY3XEeW56qaqQ8B0kQ")]
    [Description(@"Diagnostic request message management information.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required SomeHeaderRecord Header { get; init; }
    
    /// <summary>
    /// Information related to the diagnostic request.
    /// </summary>
    [IsoId("_fSm6x43XEeW56qaqQ8B0kQ")]
    [Description(@"Information related to the diagnostic request.")]
    [DataMember(Name="DgnstcReq")]
    [XmlElement(ElementName="DgnstcReq")]
    [Required]
    public required SomeDiagnosticRequestRecord DiagnosticRequest { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_fSm6yY3XEeW56qaqQ8B0kQ")]
    [Description(@"Trailer of the message containing a MAC.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public SomeSecurityTrailerRecord? SecurityTrailer { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AcceptorDiagnosticRequestV05Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AcceptorDiagnosticRequestV05Document ToDocument()
    {
        return new AcceptorDiagnosticRequestV05Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="AcceptorDiagnosticRequestV05"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record AcceptorDiagnosticRequestV05Document : IOuterDocument<AcceptorDiagnosticRequestV05>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caaa.013.001.05";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AcceptorDiagnosticRequestV05"/> is required.
    /// </summary>
    public required AcceptorDiagnosticRequestV05 Message { get; init; }
}
