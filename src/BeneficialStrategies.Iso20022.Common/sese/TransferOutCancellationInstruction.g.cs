﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for TransferOutCancellationInstruction.  ISO2002 ID# _K1LPztE6Ed-BzquC8wXy7w_-1400319754.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.sese;


/// <summary>
/// Scope
/// The TransferOutCancellationInstruction message is sent by an instructing party or an instructing party's designated agent to the executing party.
/// This message is used to request the cancellation of a TransferOutInstruction that was previously sent by the instructing party.
/// Usage
/// The TransferOutCancellationInstruction message is sent by an instructing party to request cancellation of a previously sent TransferOutInstruction.
/// This message must contain the reference of the message to be cancelled. The message may also contain all the details of the message to be cancelled, but this is not recommended.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The TransferOutCancellationInstruction message is sent by an instructing party or an instructing party's designated agent to the executing party.|This message is used to request the cancellation of a TransferOutInstruction that was previously sent by the instructing party.|Usage|The TransferOutCancellationInstruction message is sent by an instructing party to request cancellation of a previously sent TransferOutInstruction.|This message must contain the reference of the message to be cancelled. The message may also contain all the details of the message to be cancelled, but this is not recommended.")]
public partial record TransferOutCancellationInstruction : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "sese.002.001.01";
    
    #nullable enable
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_K1LPz9E6Ed-BzquC8wXy7w_1122541530")]
    [Description(@"Reference to a linked message that was previously sent.")]
    [DataMember(Name="PrvsRef")]
    [XmlElement(ElementName="PrvsRef")]
    [Required]
    public required AdditionalReference2 PreviousReference { get; init; }
    
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_K1LP0NE6Ed-BzquC8wXy7w_-627107887")]
    [Description(@"Collective reference identifying a set of messages.")]
    [DataMember(Name="PoolRef")]
    [XmlElement(ElementName="PoolRef")]
    public AdditionalReference2? PoolReference { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_K1UZsNE6Ed-BzquC8wXy7w_-615102237")]
    [Description(@"Reference to a linked message that was previously received.")]
    [DataMember(Name="RltdRef")]
    [XmlElement(ElementName="RltdRef")]
    public AdditionalReference2? RelatedReference { get; init; }
    
    /// <summary>
    /// </summary>
    [IsoId("_K1UZsdE6Ed-BzquC8wXy7w_-1481678373")]
    [Description(@"")]
    [DataMember(Name="TrfOutToBeCanc")]
    [XmlElement(ElementName="TrfOutToBeCanc")]
    public TransferOut2? TransferOutToBeCancelled { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="TransferOutCancellationInstructionDocument"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public TransferOutCancellationInstructionDocument ToDocument()
    {
        return new TransferOutCancellationInstructionDocument { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="TransferOutCancellationInstruction"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record TransferOutCancellationInstructionDocument : IOuterDocument<TransferOutCancellationInstruction>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.002.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="TransferOutCancellationInstruction"/> is required.
    /// </summary>
    public required TransferOutCancellationInstruction Message { get; init; }
}
