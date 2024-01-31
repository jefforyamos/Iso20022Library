﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AcceptorAuthorisationRequestV05.  ISO2002 ID# _saAdoY0NEeWRYffwL7E13A.
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
/// The AcceptorAuthorisationRequest message is sent by an acceptor (or its agent) to the acquirer (or its agent), to check with the issuer (or its agent) that the account associated to the card has the resources to fund the payment. This checking will include validation of the card data and any additional transaction data provided.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The AcceptorAuthorisationRequest message is sent by an acceptor (or its agent) to the acquirer (or its agent), to check with the issuer (or its agent) that the account associated to the card has the resources to fund the payment. This checking will include validation of the card data and any additional transaction data provided.")]
public partial record AcceptorAuthorisationRequestV05 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AccptrAuthstnReq";
    
    #nullable enable
    /// <summary>
    /// Authorisation request message management information.
    /// </summary>
    [IsoId("_saAdpY0NEeWRYffwL7E13A")]
    [Description(@"Authorisation request message management information.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required Header30 Header { get; init; }
    
    /// <summary>
    /// Information related to the authorisation request.
    /// </summary>
    [IsoId("_saAdp40NEeWRYffwL7E13A")]
    [Description(@"Information related to the authorisation request.")]
    [DataMember(Name="AuthstnReq")]
    [XmlElement(ElementName="AuthstnReq")]
    [Required]
    public required AcceptorAuthorisationRequest5 AuthorisationRequest { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_saAdqY0NEeWRYffwL7E13A")]
    [Description(@"Trailer of the message containing a MAC.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public ContentInformationType15? SecurityTrailer { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AcceptorAuthorisationRequestV05Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AcceptorAuthorisationRequestV05Document ToDocument()
    {
        return new AcceptorAuthorisationRequestV05Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="AcceptorAuthorisationRequestV05"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record AcceptorAuthorisationRequestV05Document : IOuterDocument<AcceptorAuthorisationRequestV05>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caaa.001.001.05";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AcceptorAuthorisationRequestV05"/> is required.
    /// </summary>
    public required AcceptorAuthorisationRequestV05 Message { get; init; }
}
