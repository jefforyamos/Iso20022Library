﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AcceptorCancellationAdviceResponseV02.  ISO2002 ID# _7vg6sTSwEeKBdvYpL_aSEg.
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
/// This record is an implementation of the caaa.008.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The AcceptorCancellationAdviceResponse message is sent by the acquirer (or its agent) to acknowledge the acceptor (or its agent) about the notification of the payment cancellation.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The AcceptorCancellationAdviceResponse message is sent by the acquirer (or its agent) to acknowledge the acceptor (or its agent) about the notification of the payment cancellation.")]
public partial record AcceptorCancellationAdviceResponseV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "caaa.008.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AccptrCxlAdvcRspn";
    
    #nullable enable
    /// <summary>
    /// Cancellation advice response message management information.
    /// </summary>
    [IsoId("_7vg6szSwEeKBdvYpL_aSEg")]
    [Description(@"Cancellation advice response message management information.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required Header2 Header { get; init; }
    
    /// <summary>
    /// Information related to the cancellation advice response.
    /// </summary>
    [IsoId("_7vg6tzSwEeKBdvYpL_aSEg")]
    [Description(@"Information related to the cancellation advice response.")]
    [DataMember(Name="CxlAdvcRspn")]
    [XmlElement(ElementName="CxlAdvcRspn")]
    [Required]
    public required AcceptorCancellationAdviceResponse2 CancellationAdviceResponse { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_7vg6uzSwEeKBdvYpL_aSEg")]
    [Description(@"Trailer of the message containing a MAC.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    [Required]
    public required ContentInformationType6 SecurityTrailer { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AcceptorCancellationAdviceResponseV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AcceptorCancellationAdviceResponseV02Document ToDocument()
    {
        return new AcceptorCancellationAdviceResponseV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="AcceptorCancellationAdviceResponseV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record AcceptorCancellationAdviceResponseV02Document : IOuterDocument<AcceptorCancellationAdviceResponseV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caaa.008.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AcceptorCancellationAdviceResponseV02"/> is required.
    /// </summary>
    public required AcceptorCancellationAdviceResponseV02 Message { get; init; }
}
