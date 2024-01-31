﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AcceptorRejectionV05.  ISO2002 ID# _xrr9MY0OEeWRYffwL7E13A.
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
/// This record is an implementation of the caaa.015.001.05 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The AcceptorRejection message is sent by the acquirer (or its agent) to reject a message request or advice sent by an acceptor (or its agent), to indicate that the received message could not be processed.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The AcceptorRejection message is sent by the acquirer (or its agent) to reject a message request or advice sent by an acceptor (or its agent), to indicate that the received message could not be processed.")]
public partial record AcceptorRejectionV05 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "caaa.015.001.05";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AccptrRjctn";
    
    #nullable enable
    /// <summary>
    /// Rejection message management information.
    /// </summary>
    [IsoId("_xrr9NY0OEeWRYffwL7E13A")]
    [Description(@"Rejection message management information.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required Header26 Header { get; init; }
    
    /// <summary>
    /// Information related to the reject.
    /// </summary>
    [IsoId("_xrr9N40OEeWRYffwL7E13A")]
    [Description(@"Information related to the reject.")]
    [DataMember(Name="Rjct")]
    [XmlElement(ElementName="Rjct")]
    [Required]
    public required AcceptorRejection2 Reject { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AcceptorRejectionV05Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AcceptorRejectionV05Document ToDocument()
    {
        return new AcceptorRejectionV05Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="AcceptorRejectionV05"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record AcceptorRejectionV05Document : IOuterDocument<AcceptorRejectionV05>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caaa.015.001.05";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AcceptorRejectionV05"/> is required.
    /// </summary>
    public required AcceptorRejectionV05 Message { get; init; }
}
