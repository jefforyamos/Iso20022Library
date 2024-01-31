﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AcceptorDiagnosticResponseV03.  ISO2002 ID# _Rt4lYTTcEeO5e9wx3yvd8g.
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
/// This record is an implementation of the caaa.014.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The AcceptorDiagnosticResponse message is sent by the acquirer (or its agent) to provide to the acceptor the result of the diagnostic request.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The AcceptorDiagnosticResponse message is sent by the acquirer (or its agent) to provide to the acceptor the result of the diagnostic request.")]
public partial record AcceptorDiagnosticResponseV03 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "caaa.014.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AccptrDgnstcRspn";
    
    #nullable enable
    /// <summary>
    /// Diagnostic response message management information.
    /// </summary>
    [IsoId("_Rt4lYzTcEeO5e9wx3yvd8g")]
    [Description(@"Diagnostic response message management information.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required Header7 Header { get; init; }
    
    /// <summary>
    /// Information related to the diagnostic response.
    /// </summary>
    [IsoId("_Rt4lZTTcEeO5e9wx3yvd8g")]
    [Description(@"Information related to the diagnostic response.")]
    [DataMember(Name="DgnstcRspn")]
    [XmlElement(ElementName="DgnstcRspn")]
    [Required]
    public required AcceptorDiagnosticResponse3 DiagnosticResponse { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_Rt4lZzTcEeO5e9wx3yvd8g")]
    [Description(@"Trailer of the message containing a MAC.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    [Required]
    public required ContentInformationType8 SecurityTrailer { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AcceptorDiagnosticResponseV03Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AcceptorDiagnosticResponseV03Document ToDocument()
    {
        return new AcceptorDiagnosticResponseV03Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="AcceptorDiagnosticResponseV03"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record AcceptorDiagnosticResponseV03Document : IOuterDocument<AcceptorDiagnosticResponseV03>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caaa.014.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AcceptorDiagnosticResponseV03"/> is required.
    /// </summary>
    public required AcceptorDiagnosticResponseV03 Message { get; init; }
}
