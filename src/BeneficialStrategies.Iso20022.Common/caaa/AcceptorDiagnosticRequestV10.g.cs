﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AcceptorDiagnosticRequestV10.  ISO2002 ID# _7Z1LEU7SEeyGi9JAv6wq7Q.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.caaa;


/// <summary>
/// This record is an implementation of the caaa.013.001.10 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The AcceptorDiagnosticRequest message is sent by an acceptor (or its agent) to the acquirer (or its agent), to check the end-to-end communication, to test the availability of this acquirer, or to validate the security environment.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The AcceptorDiagnosticRequest message is sent by an acceptor (or its agent) to the acquirer (or its agent), to check the end-to-end communication, to test the availability of this acquirer, or to validate the security environment.")]
public partial record AcceptorDiagnosticRequestV10 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "caaa.013.001.10";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AccptrDgnstcReq";
    
    #nullable enable
    /// <summary>
    /// Diagnostic request message management information.
    /// </summary>
    [IsoId("_7Z1LFU7SEeyGi9JAv6wq7Q")]
    [Description(@"Diagnostic request message management information.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required Header59 Header { get; init; }
    
    /// <summary>
    /// Information related to the diagnostic request.
    /// </summary>
    [IsoId("_7Z1LF07SEeyGi9JAv6wq7Q")]
    [Description(@"Information related to the diagnostic request.")]
    [DataMember(Name="DgnstcReq")]
    [XmlElement(ElementName="DgnstcReq")]
    [Required]
    public required AcceptorDiagnosticRequest10 DiagnosticRequest { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_7Z1LGU7SEeyGi9JAv6wq7Q")]
    [Description(@"Trailer of the message containing a MAC.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public ContentInformationType31? SecurityTrailer { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AcceptorDiagnosticRequestV10Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AcceptorDiagnosticRequestV10Document ToDocument()
    {
        return new AcceptorDiagnosticRequestV10Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="AcceptorDiagnosticRequestV10"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record AcceptorDiagnosticRequestV10Document : IOuterDocument<AcceptorDiagnosticRequestV10>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caaa.013.001.10";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AcceptorDiagnosticRequestV10"/> is required.
    /// </summary>
    public required AcceptorDiagnosticRequestV10 Message { get; init; }
}
