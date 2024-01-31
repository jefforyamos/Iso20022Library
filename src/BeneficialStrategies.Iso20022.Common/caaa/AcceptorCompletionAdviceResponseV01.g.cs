﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AcceptorCompletionAdviceResponseV01.  ISO2002 ID# _X7-iNaMVEeCJ6YNENx4h-w_1511843266.
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
/// Scope
/// The AcceptorCompletionAdviceResponse message is sent by the acquirer to acknowledge the proper receipt of an AcceptorCompletionAdvice. The message can be sent directly to the card acceptor or through an agent.
/// Usage
/// The AcceptorCompletionAdviceResponse message is used to acknowledge the data capture process performed by the acquirer based on the data required to carry out the financial clearing and settlement of the transaction.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The AcceptorCompletionAdviceResponse message is sent by the acquirer to acknowledge the proper receipt of an AcceptorCompletionAdvice. The message can be sent directly to the card acceptor or through an agent.|Usage|The AcceptorCompletionAdviceResponse message is used to acknowledge the data capture process performed by the acquirer based on the data required to carry out the financial clearing and settlement of the transaction.")]
public partial record AcceptorCompletionAdviceResponseV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AccptrCmpltnAdvcRspn";
    
    #nullable enable
    /// <summary>
    /// Completion advice response message management information.
    /// </summary>
    [IsoId("_X7-iNqMVEeCJ6YNENx4h-w_-827371409")]
    [Description(@"Completion advice response message management information.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required Header2 Header { get; init; }
    
    /// <summary>
    /// Information related to the completion advice response.
    /// </summary>
    [IsoId("_X7-iN6MVEeCJ6YNENx4h-w_-1291534155")]
    [Description(@"Information related to the completion advice response.")]
    [DataMember(Name="CmpltnAdvcRspn")]
    [XmlElement(ElementName="CmpltnAdvcRspn")]
    [Required]
    public required AcceptorCompletionAdviceResponse1 CompletionAdviceResponse { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_X7-iOKMVEeCJ6YNENx4h-w_-2123909944")]
    [Description(@"Trailer of the message containing a MAC.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    [Required]
    public required ContentInformationType3 SecurityTrailer { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AcceptorCompletionAdviceResponseV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AcceptorCompletionAdviceResponseV01Document ToDocument()
    {
        return new AcceptorCompletionAdviceResponseV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="AcceptorCompletionAdviceResponseV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record AcceptorCompletionAdviceResponseV01Document : IOuterDocument<AcceptorCompletionAdviceResponseV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caaa.004.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AcceptorCompletionAdviceResponseV01"/> is required.
    /// </summary>
    public required AcceptorCompletionAdviceResponseV01 Message { get; init; }
}
