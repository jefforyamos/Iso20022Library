﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for FraudDispositionResponseV02.  ISO2002 ID# _rUbNxMr8EeuNe7RtB4qFHw.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.cafr;


/// <summary>
/// A FraudDispositionResponse message is sent by an issuer or acquirer to an agent (processor, agent) in response to a FraudDispositionInitiation message.|
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"A FraudDispositionResponse message is sent by an issuer or acquirer to an agent (processor, agent) in response to a FraudDispositionInitiation message.||")]
public partial record FraudDispositionResponseV02 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FrdDspstnRspn";
    
    #nullable enable
    /// <summary>
    /// Information related to the management of the protocol.
    /// </summary>
    [IsoId("_rUbNxcr8EeuNe7RtB4qFHw")]
    [Description(@"Information related to the management of the protocol.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required Header66 Header { get; init; }
    
    /// <summary>
    /// Information related to the response of the fraud disposition.
    /// </summary>
    [IsoId("_rUbNx8r8EeuNe7RtB4qFHw")]
    [Description(@"Information related to the response of the fraud disposition.")]
    [DataMember(Name="Body")]
    [XmlElement(ElementName="Body")]
    [Required]
    public required FraudDispositionResponse2 Body { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_rUbNxsr8EeuNe7RtB4qFHw")]
    [Description(@"Trailer of the message containing a MAC.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public ContentInformationType20? SecurityTrailer { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="FraudDispositionResponseV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public FraudDispositionResponseV02Document ToDocument()
    {
        return new FraudDispositionResponseV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="FraudDispositionResponseV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record FraudDispositionResponseV02Document : IOuterDocument<FraudDispositionResponseV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:cafr.004.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="FraudDispositionResponseV02"/> is required.
    /// </summary>
    public required FraudDispositionResponseV02 Message { get; init; }
}
