﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for MandateSuspensionRequestV03.  ISO2002 ID# _rUYOLdcBEeq_l4BJLVUF2Q.
//
namespace BeneficialStrategies.Iso20022.pain;

/// <summary>
/// Scope
/// The MandateSuspensionRequest message is sent by the initiator of the request to its agent. The initiator can either be the debtor, debtor agent, creditor or creditor agent.
/// A MandateSuspensionRequest message is used to request the suspension of an existing mandate until the suspension is lifted. 
/// Usage
/// The MandateSuspensionRequest message can contain one or more suspension requests.
/// The messages can be exchanged between creditor and creditor agent or debtor and debtor agent and between creditor agent and debtor agent.
/// The MandateSuspensionRequest message can be used in domestic and cross-border scenarios.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The MandateSuspensionRequest message is sent by the initiator of the request to its agent. The initiator can either be the debtor, debtor agent, creditor or creditor agent.|A MandateSuspensionRequest message is used to request the suspension of an existing mandate until the suspension is lifted. |Usage|The MandateSuspensionRequest message can contain one or more suspension requests.|The messages can be exchanged between creditor and creditor agent or debtor and debtor agent and between creditor agent and debtor agent.|The MandateSuspensionRequest message can be used in domestic and cross-border scenarios.|")]
public partial record MandateSuspensionRequestV03 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MndtSspnsnReq";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Set of characteristics to identify the message and parties playing a role in the mandate suspension request, but which are not part of the mandate.
    /// </summary>
    [IsoId("_rUYON9cBEeq_l4BJLVUF2Q")]
    [Description(@"Set of characteristics to identify the message and parties playing a role in the mandate suspension request, but which are not part of the mandate.")]
    [DataMember(Name="GrpHdr")]
    [XmlElement(ElementName="GrpHdr")]
    [Required]
    public required GroupHeader80 GroupHeader { get; init; }
    
    /// <summary>
    /// Set of elements used to provide information on the suspension request of the mandate.
    /// </summary>
    [IsoId("_rUYOOdcBEeq_l4BJLVUF2Q")]
    [Description(@"Set of elements used to provide information on the suspension request of the mandate.")]
    [DataMember(Name="UndrlygSspnsnDtls")]
    [XmlElement(ElementName="UndrlygSspnsnDtls")]
    [Required]
    public required MandateSuspension3 UnderlyingSuspensionDetails { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_rUYOO9cBEeq_l4BJLVUF2Q")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="MandateSuspensionRequestV03Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public MandateSuspensionRequestV03Document ToDocument()
    {
        return new MandateSuspensionRequestV03Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="MandateSuspensionRequestV03"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record MandateSuspensionRequestV03Document : IOuterDocument<MandateSuspensionRequestV03>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:pain.018.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="MandateSuspensionRequestV03"/> is required.
    /// </summary>
    public required MandateSuspensionRequestV03 Message { get; init; }
}
