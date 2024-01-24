﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for RequestForDuplicateInstruction.  ISO2002 ID# _RNxXSNE_Ed-BzquC8wXy7w_-694421225.
//
namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// Scope|The Request For Duplicate message is sent by the case assignee to the case creator or case assigner.|This message is used to request a copy of the original payment instruction considered in the case.|Usage|The Request For Duplicate message: |- must be answered with a Duplicate message|- must be used when a case assignee requests a copy of the original payment instruction. This occurs, for example, when the case assignee cannot trace the payment instruction based on the elements mentioned in the case assignment message|- covers one and only one instruction at a time. If several payment instruction copies are needed by the case assignee, then multiple Request For Duplicate messages must be sent|- must be used exclusively between the case assignee and its case creator/case assigner.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The Request For Duplicate message is sent by the case assignee to the case creator or case assigner.|This message is used to request a copy of the original payment instruction considered in the case.|Usage|The Request For Duplicate message: |- must be answered with a Duplicate message|- must be used when a case assignee requests a copy of the original payment instruction. This occurs, for example, when the case assignee cannot trace the payment instruction based on the elements mentioned in the case assignment message|- covers one and only one instruction at a time. If several payment instruction copies are needed by the case assignee, then multiple Request For Duplicate messages must be sent|- must be used exclusively between the case assignee and its case creator/case assigner.")]
public partial record RequestForDuplicateInstruction : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "camt.033.001.01";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// </summary>
    [IsoId("_RNxXSdE_Ed-BzquC8wXy7w_1708467998")]
    [Description(@"")]
    [DataMember(Name="Assgnmt")]
    [XmlElement(ElementName="Assgnmt")]
    [Required]
    public required SomeAssignmentRecord Assignment { get; init; }
    
    /// <summary>
    /// </summary>
    [IsoId("_RNxXStE_Ed-BzquC8wXy7w_1751874887")]
    [Description(@"")]
    [DataMember(Name="Case")]
    [XmlElement(ElementName="Case")]
    [Required]
    public required SomeCaseRecord Case { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="RequestForDuplicateInstructionDocument"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public RequestForDuplicateInstructionDocument ToDocument()
    {
        return new RequestForDuplicateInstructionDocument { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="RequestForDuplicateInstruction"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record RequestForDuplicateInstructionDocument : IOuterDocument<RequestForDuplicateInstruction>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.033.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="RequestForDuplicateInstruction"/> is required.
    /// </summary>
    public required RequestForDuplicateInstruction Message { get; init; }
}
