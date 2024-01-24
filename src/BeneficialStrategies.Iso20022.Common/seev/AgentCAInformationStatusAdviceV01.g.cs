﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AgentCAInformationStatusAdviceV01.  ISO2002 ID# _TOM7y9EwEd-BzquC8wXy7w_11240695.
//
namespace BeneficialStrategies.Iso20022.seev;

/// <summary>
/// Scope
/// This message is sent by an issuer (or its agent) to a CSD to report the status, or change in status, of an information advice.
/// Usage
/// This message must be used in response to an Agent Corporate Action Information Advice in the case of a rejection. However, it may also be used to report other statuses.
/// The information advice identification must be present to link this message to the information advice for which the status is provided.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|This message is sent by an issuer (or its agent) to a CSD to report the status, or change in status, of an information advice.|Usage|This message must be used in response to an Agent Corporate Action Information Advice in the case of a rejection. However, it may also be used to report other statuses.|The information advice identification must be present to link this message to the information advice for which the status is provided.")]
public partial record AgentCAInformationStatusAdviceV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AgtCAInfStsAdvc";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Identification assigned by the Sender to unambiguously identify the status advice.
    /// </summary>
    [IsoId("_TOM7zNEwEd-BzquC8wXy7w_1654735985")]
    [Description(@"Identification assigned by the Sender to unambiguously identify the status advice.")]
    [DataMember(Name="Id")]
    [XmlElement(ElementName="Id")]
    [Required]
    public required SomeIdentificationRecord Identification { get; init; }
    
    /// <summary>
    /// Identification of the linked Agent CA Information Advice for which a status is given.
    /// </summary>
    [IsoId("_TOWFsNEwEd-BzquC8wXy7w_1665816866")]
    [Description(@"Identification of the linked Agent CA Information Advice for which a status is given.")]
    [DataMember(Name="AgtCAInfAdvcId")]
    [XmlElement(ElementName="AgtCAInfAdvcId")]
    [Required]
    public required SomeAgentCAInformationAdviceIdentificationRecord AgentCAInformationAdviceIdentification { get; init; }
    
    /// <summary>
    /// Additional information about the corporate action such as the delivery details.
    /// </summary>
    [IsoId("_TOWFsdEwEd-BzquC8wXy7w_693722719")]
    [Description(@"Additional information about the corporate action such as the delivery details.")]
    [DataMember(Name="CorpActnAddtlInf")]
    [XmlElement(ElementName="CorpActnAddtlInf")]
    public SomeCorporateActionAdditionalInformationRecord? CorporateActionAdditionalInformation { get; init; }
    
    /// <summary>
    /// Status of the information advice sent by the CSD.
    /// </summary>
    [IsoId("_TOWFstEwEd-BzquC8wXy7w_-904563755")]
    [Description(@"Status of the information advice sent by the CSD.")]
    [DataMember(Name="InfStsDtls")]
    [XmlElement(ElementName="InfStsDtls")]
    [Required]
    public required SomeInformationStatusDetailsRecord InformationStatusDetails { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AgentCAInformationStatusAdviceV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AgentCAInformationStatusAdviceV01Document ToDocument()
    {
        return new AgentCAInformationStatusAdviceV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="AgentCAInformationStatusAdviceV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record AgentCAInformationStatusAdviceV01Document : IOuterDocument<AgentCAInformationStatusAdviceV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.024.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AgentCAInformationStatusAdviceV01"/> is required.
    /// </summary>
    public required AgentCAInformationStatusAdviceV01 Message { get; init; }
}
