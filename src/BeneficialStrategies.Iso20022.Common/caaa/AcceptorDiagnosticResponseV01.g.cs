﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AcceptorDiagnosticResponseV01.  ISO2002 ID# _QI8DtaMVEeCJ6YNENx4h-w_1442328644.
//
namespace BeneficialStrategies.Iso20022.caaa;

/// <summary>
/// Scope
/// The AcceptorDiagnosticResponse message is sent by the acquirer to the card acceptor to confirm the availability of the acquirer. An agent never forwards the message.
/// Usage
/// The AcceptorDiagnosticResponse message is used to:
/// - confirm the availability of the acquirer;
/// - validate the security of the exchanges with the acquirer;
/// - validate the version of the configuration parameters.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The AcceptorDiagnosticResponse message is sent by the acquirer to the card acceptor to confirm the availability of the acquirer. An agent never forwards the message.|Usage|The AcceptorDiagnosticResponse message is used to:|- confirm the availability of the acquirer;|- validate the security of the exchanges with the acquirer;|- validate the version of the configuration parameters.")]
public partial record AcceptorDiagnosticResponseV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AccptrDgnstcRspn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Diagnostic response message management information.
    /// </summary>
    [IsoId("_QI8DtqMVEeCJ6YNENx4h-w_1563091658")]
    [Description(@"Diagnostic response message management information.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required SomeHeaderRecord Header { get; init; }
    
    /// <summary>
    /// Information related to the diagnostic response.
    /// </summary>
    [IsoId("_QI8Dt6MVEeCJ6YNENx4h-w_-853433637")]
    [Description(@"Information related to the diagnostic response.")]
    [DataMember(Name="DgnstcRspn")]
    [XmlElement(ElementName="DgnstcRspn")]
    [Required]
    public required SomeDiagnosticResponseRecord DiagnosticResponse { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_QI8DuKMVEeCJ6YNENx4h-w_37041844")]
    [Description(@"Trailer of the message containing a MAC.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    [Required]
    public required SomeSecurityTrailerRecord SecurityTrailer { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AcceptorDiagnosticResponseV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AcceptorDiagnosticResponseV01Document ToDocument()
    {
        return new AcceptorDiagnosticResponseV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="AcceptorDiagnosticResponseV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record AcceptorDiagnosticResponseV01Document : IOuterDocument<AcceptorDiagnosticResponseV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caaa.014.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AcceptorDiagnosticResponseV01"/> is required.
    /// </summary>
    public required AcceptorDiagnosticResponseV01 Message { get; init; }
}
