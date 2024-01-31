﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SaleToPOISessionManagementRequestV01.  ISO2002 ID# __7ONcYYAEemxIqbaFEE8-w.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.casp;


/// <summary>
/// This message is a request for several kind of Administrative services related to Session Management ' that the Sale System (Merchant I.S.) can send to the POI system (Card Acceptor system).
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"This message is a request for several kind of Administrative services related to Session Management ' that the Sale System (Merchant I.S.) can send to the POI system (Card Acceptor system).")]
public partial record SaleToPOISessionManagementRequestV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SaleToPOISsnMgmtReq";
    
    #nullable enable
    /// <summary>
    /// Set of characteristics related to the transfer of the request.
    /// </summary>
    [IsoId("__7ONc4YAEemxIqbaFEE8-w")]
    [Description(@"Set of characteristics related to the transfer of the request.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required Header37 Header { get; init; }
    
    /// <summary>
    /// Information related to the session management request.
    /// </summary>
    [IsoId("__7ONdYYAEemxIqbaFEE8-w")]
    [Description(@"Information related to the session management request.")]
    [DataMember(Name="SsnMgmtReq")]
    [XmlElement(ElementName="SsnMgmtReq")]
    [Required]
    public required SessionManagementRequest2 SessionManagementRequest { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC or a digital signature.
    /// </summary>
    [IsoId("__7ONd4YAEemxIqbaFEE8-w")]
    [Description(@"Trailer of the message containing a MAC or a digital signature.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public ContentInformationType18? SecurityTrailer { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SaleToPOISessionManagementRequestV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SaleToPOISessionManagementRequestV01Document ToDocument()
    {
        return new SaleToPOISessionManagementRequestV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="SaleToPOISessionManagementRequestV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record SaleToPOISessionManagementRequestV01Document : IOuterDocument<SaleToPOISessionManagementRequestV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:casp.005.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SaleToPOISessionManagementRequestV01"/> is required.
    /// </summary>
    public required SaleToPOISessionManagementRequestV01 Message { get; init; }
}
