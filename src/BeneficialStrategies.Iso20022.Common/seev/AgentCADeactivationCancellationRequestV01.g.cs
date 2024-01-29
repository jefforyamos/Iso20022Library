﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AgentCADeactivationCancellationRequestV01.  ISO2002 ID# _TL9gGdEwEd-BzquC8wXy7w_1830397138.
//
namespace BeneficialStrategies.Iso20022.seev;

/// <summary>
/// Scope
/// This message is sent by an issuer (or its agent) to the CSD to request the cancellation of a previously sent corporate action deactivation instruction.
/// Usage
/// This message is used to request the cancellation of a pending deactivation instruction. The cancellation must apply to exactly the same level as the original instruction, ie to the entire CA event or to an option as per the original instruction.
/// This message must be sent before the deactivation execution date.
/// In case a corporate action or option is already deactivated, this message can not be used to reactivate the corporate action entire event or option; the notification advice message must be used to reactivate a corporate action or option.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|This message is sent by an issuer (or its agent) to the CSD to request the cancellation of a previously sent corporate action deactivation instruction.|Usage|This message is used to request the cancellation of a pending deactivation instruction. The cancellation must apply to exactly the same level as the original instruction, ie to the entire CA event or to an option as per the original instruction.|This message must be sent before the deactivation execution date.|In case a corporate action or option is already deactivated, this message can not be used to reactivate the corporate action entire event or option; the notification advice message must be used to reactivate a corporate action or option.")]
public partial record AgentCADeactivationCancellationRequestV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AgtCADeactvtnCxlReq";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Identification assigned by the Sender to unambiguously identify the cancellation request.
    /// </summary>
    [IsoId("_TMHRENEwEd-BzquC8wXy7w_118262265")]
    [Description(@"Identification assigned by the Sender to unambiguously identify the cancellation request.")]
    [DataMember(Name="Id")]
    [XmlElement(ElementName="Id")]
    [Required]
    public required SomeIdentificationRecord Identification { get; init; }
    
    /// <summary>
    /// Identification of the Agent CA Deactivation Instruction to be cancelled.
    /// </summary>
    [IsoId("_TMHREdEwEd-BzquC8wXy7w_-1093662480")]
    [Description(@"Identification of the Agent CA Deactivation Instruction to be cancelled.")]
    [DataMember(Name="AgtCADeactvtnInstrId")]
    [XmlElement(ElementName="AgtCADeactvtnInstrId")]
    [Required]
    public required SomeAgentCADeactivationInstructionIdentificationRecord AgentCADeactivationInstructionIdentification { get; init; }
    
    /// <summary>
    /// General information about the corporate action event.
    /// </summary>
    [IsoId("_TMHREtEwEd-BzquC8wXy7w_-541518720")]
    [Description(@"General information about the corporate action event.")]
    [DataMember(Name="CorpActnGnlInf")]
    [XmlElement(ElementName="CorpActnGnlInf")]
    [Required]
    public required SomeCorporateActionGeneralInformationRecord CorporateActionGeneralInformation { get; init; }
    
    /// <summary>
    /// Details of the deactivation instruction to be cancelled.
    /// </summary>
    [IsoId("_TMHRE9EwEd-BzquC8wXy7w_-1594611016")]
    [Description(@"Details of the deactivation instruction to be cancelled.")]
    [DataMember(Name="DeactvtnInstrDtls")]
    [XmlElement(ElementName="DeactvtnInstrDtls")]
    public SomeDeactivationInstructionDetailsRecord? DeactivationInstructionDetails { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AgentCADeactivationCancellationRequestV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AgentCADeactivationCancellationRequestV01Document ToDocument()
    {
        return new AgentCADeactivationCancellationRequestV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="AgentCADeactivationCancellationRequestV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record AgentCADeactivationCancellationRequestV01Document : IOuterDocument<AgentCADeactivationCancellationRequestV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.029.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AgentCADeactivationCancellationRequestV01"/> is required.
    /// </summary>
    public required AgentCADeactivationCancellationRequestV01 Message { get; init; }
}