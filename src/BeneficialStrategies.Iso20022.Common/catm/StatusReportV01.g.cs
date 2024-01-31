﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for StatusReportV01.  ISO2002 ID# _8ki24OQWEeCGktPI9k4Dlw_716782601.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.catm;


/// <summary>
/// This record is an implementation of the catm.001.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The StatusReport message is sent by the card acceptor to the master terminal manager or delegated terminal manager to inform these entities about the status of the acceptor system.
/// Usage
/// The StatusReport message may embed the information required by the master terminal manager or delegated terminal manager for preparing the needed TMS actions in the management plan to be replaced and the acceptor parameters to be updated.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The StatusReport message is sent by the card acceptor to the master terminal manager or delegated terminal manager to inform these entities about the status of the acceptor system.|Usage|The StatusReport message may embed the information required by the master terminal manager or delegated terminal manager for preparing the needed TMS actions in the management plan to be replaced and the acceptor parameters to be updated.")]
public partial record StatusReportV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "catm.001.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "StsRpt";
    
    #nullable enable
    /// <summary>
    /// Set of characteristics related to the transfer of the status report.
    /// </summary>
    [IsoId("_8ki24eQWEeCGktPI9k4Dlw_817647362")]
    [Description(@"Set of characteristics related to the transfer of the status report.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required Header4 Header { get; init; }
    
    /// <summary>
    /// Status of the point of interaction (POI), its components and their installed versions.
    /// </summary>
    [IsoId("_8ki24uQWEeCGktPI9k4Dlw_2054938442")]
    [Description(@"Status of the point of interaction (POI), its components and their installed versions.")]
    [DataMember(Name="StsRpt")]
    [XmlElement(ElementName="StsRpt")]
    [Required]
    public required StatusReport1 StatusReport { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC or a digital signature.
    /// </summary>
    [IsoId("_8ki24-QWEeCGktPI9k4Dlw_1773797778")]
    [Description(@"Trailer of the message containing a MAC or a digital signature.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    [Required]
    public required ContentInformationType1 SecurityTrailer { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="StatusReportV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public StatusReportV01Document ToDocument()
    {
        return new StatusReportV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="StatusReportV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record StatusReportV01Document : IOuterDocument<StatusReportV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:catm.001.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="StatusReportV01"/> is required.
    /// </summary>
    public required StatusReportV01 Message { get; init; }
}
