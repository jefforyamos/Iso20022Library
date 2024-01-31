﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for ResendRequestV01.  ISO2002 ID# _5xUioZb3Eee4htziCyV8eA.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.admi;


/// <summary>
/// This record is an implementation of the admi.006.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// A system member or any parties authorised by them send a ResendRequest message to the Central System (such as the T2S platform). The purpose of this request is, that the requesting party wants to receive the “original” message once again. This might be caused through technical problems on the receiving side (message could not be received or processed or is missing in the message sequencing) or for archiving purposes.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"A system member or any parties authorised by them send a ResendRequest message to the Central System (such as the T2S platform). The purpose of this request is, that the requesting party wants to receive the “original” message once again. This might be caused through technical problems on the receiving side (message could not be received or processed or is missing in the message sequencing) or for archiving purposes.")]
public partial record ResendRequestV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "admi.006.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "RsndReq";
    
    #nullable enable
    /// <summary>
    /// Set of elements to identify the resend message.
    /// </summary>
    [IsoId("_5xUio5b3Eee4htziCyV8eA")]
    [Description(@"Set of elements to identify the resend message.")]
    [DataMember(Name="MsgHdr")]
    [XmlElement(ElementName="MsgHdr")]
    [Required]
    public required MessageHeader7 MessageHeader { get; init; }
    
    /// <summary>
    /// Defines the criteria to unambiguously identify the information to be resent.
    /// </summary>
    [IsoId("_5xUipZb3Eee4htziCyV8eA")]
    [Description(@"Defines the criteria to unambiguously identify the information to be resent.")]
    [DataMember(Name="RsndSchCrit")]
    [XmlElement(ElementName="RsndSchCrit")]
    [Required]
    public required ResendSearchCriteria2 ResendSearchCriteria { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_5xUip5b3Eee4htziCyV8eA")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="ResendRequestV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public ResendRequestV01Document ToDocument()
    {
        return new ResendRequestV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="ResendRequestV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record ResendRequestV01Document : IOuterDocument<ResendRequestV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:admi.006.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="ResendRequestV01"/> is required.
    /// </summary>
    public required ResendRequestV01 Message { get; init; }
}
