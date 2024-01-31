﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AcceptorAuthorisationResponseV11.  ISO2002 ID# _spAG4U0YEeybj420QgWBkA.
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
/// This record is an implementation of the caaa.002.001.11 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The AcceptorAuthorisationResponse message is sent by the acquirer (or its agent) to an acceptor (or its agent), to return the result of the validation made by issuer about the payment transaction.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The AcceptorAuthorisationResponse message is sent by the acquirer (or its agent) to an acceptor (or its agent), to return the result of the validation made by issuer about the payment transaction.")]
public partial record AcceptorAuthorisationResponseV11 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "caaa.002.001.11";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AccptrAuthstnRspn";
    
    #nullable enable
    /// <summary>
    /// Authorisation response message management information.
    /// </summary>
    [IsoId("_spAG5U0YEeybj420QgWBkA")]
    [Description(@"Authorisation response message management information.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required Header59 Header { get; init; }
    
    /// <summary>
    /// Information related to the response of the authorisation.
    /// </summary>
    [IsoId("_spAG500YEeybj420QgWBkA")]
    [Description(@"Information related to the response of the authorisation.")]
    [DataMember(Name="AuthstnRspn")]
    [XmlElement(ElementName="AuthstnRspn")]
    [Required]
    public required AcceptorAuthorisationResponse11 AuthorisationResponse { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_spAG6U0YEeybj420QgWBkA")]
    [Description(@"Trailer of the message containing a MAC.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public ContentInformationType31? SecurityTrailer { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AcceptorAuthorisationResponseV11Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AcceptorAuthorisationResponseV11Document ToDocument()
    {
        return new AcceptorAuthorisationResponseV11Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="AcceptorAuthorisationResponseV11"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record AcceptorAuthorisationResponseV11Document : IOuterDocument<AcceptorAuthorisationResponseV11>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caaa.002.001.11";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AcceptorAuthorisationResponseV11"/> is required.
    /// </summary>
    public required AcceptorAuthorisationResponseV11 Message { get; init; }
}
