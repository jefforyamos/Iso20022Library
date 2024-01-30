﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SwitchOrderConfirmationV02.  ISO2002 ID# _7TxshtE7Ed-BzquC8wXy7w_-1591679635.
//
namespace BeneficialStrategies.Iso20022.setr;

/// <summary>
/// Scope
/// The SwitchOrderConfirmation message is sent by an executing party, eg, a transfer agent, to an instruction party, eg, an investment manager or its authorised representative. There may be one or more intermediary parties between the instructing party and the executing party. The intermediary party is, for example, an intermediary or a concentrator.
/// This message is used to confirm the details of the execution of a SwitchOrder message.
/// Usage
/// The SwitchOrderConfirmation message is sent to confirm that all the legs of the switch have been executed.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The SwitchOrderConfirmation message is sent by an executing party, eg, a transfer agent, to an instruction party, eg, an investment manager or its authorised representative. There may be one or more intermediary parties between the instructing party and the executing party. The intermediary party is, for example, an intermediary or a concentrator.|This message is used to confirm the details of the execution of a SwitchOrder message.|Usage|The SwitchOrderConfirmation message is sent to confirm that all the legs of the switch have been executed.")]
public partial record SwitchOrderConfirmationV02 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "setr.015.001.02";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Reference assigned to a set of orders or trades in order to link them together.
    /// </summary>
    [IsoId("_7Txsh9E7Ed-BzquC8wXy7w_433338806")]
    [Description(@"Reference assigned to a set of orders or trades in order to link them together.")]
    [DataMember(Name="MstrRef")]
    [XmlElement(ElementName="MstrRef")]
    public AdditionalReference3? MasterReference { get; init; }
    
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_7TxsiNE7Ed-BzquC8wXy7w_444423035")]
    [Description(@"Collective reference identifying a set of messages.")]
    [DataMember(Name="PoolRef")]
    [XmlElement(ElementName="PoolRef")]
    public AdditionalReference3? PoolReference { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_7TxsidE7Ed-BzquC8wXy7w_428723166")]
    [Description(@"Reference to a linked message that was previously sent.")]
    [DataMember(Name="PrvsRef")]
    [XmlElement(ElementName="PrvsRef")]
    public AdditionalReference3? PreviousReference { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_7T7dgNE7Ed-BzquC8wXy7w_442574644")]
    [Description(@"Reference to a linked message that was previously received.")]
    [DataMember(Name="RltdRef")]
    [XmlElement(ElementName="RltdRef")]
    [Required]
    public required AdditionalReference3 RelatedReference { get; init; }
    
    /// <summary>
    /// Information related to a switch execution.
    /// </summary>
    [IsoId("_7T7dgdE7Ed-BzquC8wXy7w_-1414365507")]
    [Description(@"Information related to a switch execution.")]
    [DataMember(Name="SwtchExctnDtls")]
    [XmlElement(ElementName="SwtchExctnDtls")]
    [Required]
    public required SwitchExecution3 SwitchExecutionDetails { get; init; }
    
    /// <summary>
    /// Confirmation of the information related to an intermediary.
    /// </summary>
    [IsoId("_7T7dgtE7Ed-BzquC8wXy7w_1133369220")]
    [Description(@"Confirmation of the information related to an intermediary.")]
    [DataMember(Name="IntrmyDtls")]
    [XmlElement(ElementName="IntrmyDtls")]
    public required IReadonlyCollection<Intermediary4> IntermediaryDetails { get; init; } // Min=0, Max=10
    
    /// <summary>
    /// Information provided when the message is a copy of a previous message.
    /// </summary>
    [IsoId("_7T7dg9E7Ed-BzquC8wXy7w_976977118")]
    [Description(@"Information provided when the message is a copy of a previous message.")]
    [DataMember(Name="CpyDtls")]
    [XmlElement(ElementName="CpyDtls")]
    public CopyInformation1? CopyDetails { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_7T7dhNE7Ed-BzquC8wXy7w_147041061")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="Xtnsn")]
    [XmlElement(ElementName="Xtnsn")]
    public Extension1? Extension { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SwitchOrderConfirmationV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SwitchOrderConfirmationV02Document ToDocument()
    {
        return new SwitchOrderConfirmationV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="SwitchOrderConfirmationV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record SwitchOrderConfirmationV02Document : IOuterDocument<SwitchOrderConfirmationV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:setr.015.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SwitchOrderConfirmationV02"/> is required.
    /// </summary>
    public required SwitchOrderConfirmationV02 Message { get; init; }
}
