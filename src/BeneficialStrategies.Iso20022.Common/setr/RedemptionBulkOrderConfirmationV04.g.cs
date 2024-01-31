﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for RedemptionBulkOrderConfirmationV04.  ISO2002 ID# _Aab6ATbLEead9bDRE_1DAQ.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.setr;


/// <summary>
/// This record is an implementation of the setr.003.001.04 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The RedemptionBulkOrderConfirmation message is sent by an executing party, for example, a transfer agent, to the instructing party, for example, an investment manager or its authorised representative, to confirm the details of execution for a previously received RedemptionBulkOrder message.
/// Usage
/// The RedemptionBulkOrderConfirmation message is used to confirm the execution of all individual orders included in a previously sent RedemptionBulkOrder message.
/// There is usually one bulk confirmation message for one bulk order message.
/// Each individual order confirmation specified is identified in DealReference. The reference of the original individual order is specified in OrderReference. The message identification of the RedemptionBulkOrder message in which the individual order was conveyed may also be quoted in RelatedReference, but this is not recommended.
/// A RedemptionBulkOrder must in all cases be responded to by a RedemptionBulkOrderConfirmation and in no circumstances by a RedemptionOrderConfirmation.
/// If the executing party needs to confirm a RedemptionOrder instruction, then the RedemptionOrderConfirmation must be used.
/// When the message is used to convey a confirmation amendment/s, the AmendmentIndicator must be present with the value ‘true’ or ‘1’. When this is the case, the message must only contain a confirmation amendment/s and not contain both a confirmation amendment/s and a ‘new’ confirmation/s.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The RedemptionBulkOrderConfirmation message is sent by an executing party, for example, a transfer agent, to the instructing party, for example, an investment manager or its authorised representative, to confirm the details of execution for a previously received RedemptionBulkOrder message.|Usage|The RedemptionBulkOrderConfirmation message is used to confirm the execution of all individual orders included in a previously sent RedemptionBulkOrder message.|There is usually one bulk confirmation message for one bulk order message.|Each individual order confirmation specified is identified in DealReference. The reference of the original individual order is specified in OrderReference. The message identification of the RedemptionBulkOrder message in which the individual order was conveyed may also be quoted in RelatedReference, but this is not recommended.|A RedemptionBulkOrder must in all cases be responded to by a RedemptionBulkOrderConfirmation and in no circumstances by a RedemptionOrderConfirmation.|If the executing party needs to confirm a RedemptionOrder instruction, then the RedemptionOrderConfirmation must be used.|When the message is used to convey a confirmation amendment/s, the AmendmentIndicator must be present with the value ‘true’ or ‘1’. When this is the case, the message must only contain a confirmation amendment/s and not contain both a confirmation amendment/s and a ‘new’ confirmation/s.")]
public partial record RedemptionBulkOrderConfirmationV04 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "setr.003.001.04";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "RedBlkOrdrConf";
    
    #nullable enable
    /// <summary>
    /// Reference that uniquely identifies the message from a business application standpoint.
    /// </summary>
    [IsoId("_Aab6CzbLEead9bDRE_1DAQ")]
    [Description(@"Reference that uniquely identifies the message from a business application standpoint.")]
    [DataMember(Name="MsgId")]
    [XmlElement(ElementName="MsgId")]
    [Required]
    public required MessageIdentification1 MessageIdentification { get; init; }
    
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_Aab6DTbLEead9bDRE_1DAQ")]
    [Description(@"Collective reference identifying a set of messages.")]
    [DataMember(Name="PoolRef")]
    [XmlElement(ElementName="PoolRef")]
    public AdditionalReference9? PoolReference { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_Aab6DzbLEead9bDRE_1DAQ")]
    [Description(@"Reference to a linked message that was previously sent.")]
    [DataMember(Name="PrvsRef")]
    [XmlElement(ElementName="PrvsRef")]
    public AdditionalReference8? PreviousReference { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_Aab6ETbLEead9bDRE_1DAQ")]
    [Description(@"Reference to a linked message that was previously received.")]
    [DataMember(Name="RltdRef")]
    [XmlElement(ElementName="RltdRef")]
    public AdditionalReference8? RelatedReference { get; init; }
    
    /// <summary>
    /// General information related to the execution of the orders.
    /// </summary>
    [IsoId("_Aab6EzbLEead9bDRE_1DAQ")]
    [Description(@"General information related to the execution of the orders.")]
    [DataMember(Name="BlkExctnDtls")]
    [XmlElement(ElementName="BlkExctnDtls")]
    [Required]
    public required RedemptionBulkExecution5 BulkExecutionDetails { get; init; }
    
    /// <summary>
    /// Information provided when the message is a copy of a previous message.
    /// </summary>
    [IsoId("_Aab6FzbLEead9bDRE_1DAQ")]
    [Description(@"Information provided when the message is a copy of a previous message.")]
    [DataMember(Name="CpyDtls")]
    [XmlElement(ElementName="CpyDtls")]
    public CopyInformation4? CopyDetails { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_Aab6GTbLEead9bDRE_1DAQ")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="Xtnsn")]
    [XmlElement(ElementName="Xtnsn")]
    public Extension1? Extension { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="RedemptionBulkOrderConfirmationV04Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public RedemptionBulkOrderConfirmationV04Document ToDocument()
    {
        return new RedemptionBulkOrderConfirmationV04Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="RedemptionBulkOrderConfirmationV04"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record RedemptionBulkOrderConfirmationV04Document : IOuterDocument<RedemptionBulkOrderConfirmationV04>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:setr.003.001.04";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="RedemptionBulkOrderConfirmationV04"/> is required.
    /// </summary>
    public required RedemptionBulkOrderConfirmationV04 Message { get; init; }
}
