﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for TransferInCancellationRequestV08.  ISO2002 ID# _xYYfIYZLEeemXK0UETsSiA.
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
/// The TransferInCancellationRequest message is sent by, for example, an investment manager or its authorised representative, to the executing party, for example, a transfer agent, to request the cancellation of a previously sent transfer in instruction.
/// Usage
/// The TransferInCancellationRequest message is used to request the cancellation of one or more transfer in instructions.
/// There is no amendment, but a cancellation and re-instruct policy.
/// To request the cancellation of one or more transfer in instructions, the transfer reference of the transfer, as specified in the original TransferInInstruction message, is specified in the transfer reference element.
/// The message identification of the original TransferOutInstruction message may also be quoted in PreviousReference but this is not recommended.
/// The deadline and acceptance of a cancellation request is subject to a service level agreement (SLA). This cancellation message is a cancellation request. There is no automatic acceptance of the cancellation.
/// The rejection or acceptance of a TransferInCancellationRequest is made using an TransferCancellationStatusReport message.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The TransferInCancellationRequest message is sent by, for example, an investment manager or its authorised representative, to the executing party, for example, a transfer agent, to request the cancellation of a previously sent transfer in instruction.|Usage|The TransferInCancellationRequest message is used to request the cancellation of one or more transfer in instructions.|There is no amendment, but a cancellation and re-instruct policy.|To request the cancellation of one or more transfer in instructions, the transfer reference of the transfer, as specified in the original TransferInInstruction message, is specified in the transfer reference element.|The message identification of the original TransferOutInstruction message may also be quoted in PreviousReference but this is not recommended.|The deadline and acceptance of a cancellation request is subject to a service level agreement (SLA). This cancellation message is a cancellation request. There is no automatic acceptance of the cancellation.|The rejection or acceptance of a TransferInCancellationRequest is made using an TransferCancellationStatusReport message.")]
public partial record TransferInCancellationRequestV08 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "TrfInCxlReq";
    
    #nullable enable
    /// <summary>
    /// Reference that uniquely identifies the message from a business application standpoint.
    /// </summary>
    [IsoId("_xYYfI4ZLEeemXK0UETsSiA")]
    [Description(@"Reference that uniquely identifies the message from a business application standpoint.")]
    [DataMember(Name="MsgId")]
    [XmlElement(ElementName="MsgId")]
    [Required]
    public required MessageIdentification1 MessageIdentification { get; init; }
    
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_uoh8w4izEeefvMoXmllHqg")]
    [Description(@"Collective reference identifying a set of messages.")]
    [DataMember(Name="PoolRef")]
    [XmlElement(ElementName="PoolRef")]
    public AdditionalReference9? PoolReference { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_uoh8xIizEeefvMoXmllHqg")]
    [Description(@"Reference to a linked message that was previously sent.")]
    [DataMember(Name="PrvsRef")]
    [XmlElement(ElementName="PrvsRef")]
    public AdditionalReference8? PreviousReference { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_uoh8xYizEeefvMoXmllHqg")]
    [Description(@"Reference to a linked message that was previously received.")]
    [DataMember(Name="RltdRef")]
    [XmlElement(ElementName="RltdRef")]
    public AdditionalReference8? RelatedReference { get; init; }
    
    /// <summary>
    /// Function of the transfer-in, that is, whether the message is used as a request to cancel a previously sent instruction or as a cancellation of a previously sent advice and request for information. The absence of Function indicates the message is a request to cancel a previously sent instruction.
    /// </summary>
    [IsoId("_xYYfJ4ZLEeemXK0UETsSiA")]
    [Description(@"Function of the transfer-in, that is, whether the message is used as a request to cancel a previously sent instruction or as a cancellation of a previously sent advice and request for information. The absence of Function indicates the message is a request to cancel a previously sent instruction.")]
    [DataMember(Name="Fctn")]
    [XmlElement(ElementName="Fctn")]
    public TransferInFunction1Code? Function { get; init; }
    
    /// <summary>
    /// Reference of the transfer to be cancelled.
    /// </summary>
    [IsoId("_4WRNYYizEeefvMoXmllHqg")]
    [Description(@"Reference of the transfer to be cancelled.")]
    [DataMember(Name="Refs")]
    [XmlElement(ElementName="Refs")]
    [Required]
    public required TransferReference11 References { get; init; }
    
    /// <summary>
    /// Identifies the market practice to which the message conforms.
    /// </summary>
    [IsoId("_xYYfK4ZLEeemXK0UETsSiA")]
    [Description(@"Identifies the market practice to which the message conforms.")]
    [DataMember(Name="MktPrctcVrsn")]
    [XmlElement(ElementName="MktPrctcVrsn")]
    public MarketPracticeVersion1? MarketPracticeVersion { get; init; }
    
    /// <summary>
    /// Information provided when the message is a copy of a previous message.
    /// </summary>
    [IsoId("_xYYfLYZLEeemXK0UETsSiA")]
    [Description(@"Information provided when the message is a copy of a previous message.")]
    [DataMember(Name="CpyDtls")]
    [XmlElement(ElementName="CpyDtls")]
    public CopyInformation4? CopyDetails { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="TransferInCancellationRequestV08Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public TransferInCancellationRequestV08Document ToDocument()
    {
        return new TransferInCancellationRequestV08Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="TransferInCancellationRequestV08"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record TransferInCancellationRequestV08Document : IOuterDocument<TransferInCancellationRequestV08>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.006.001.08";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="TransferInCancellationRequestV08"/> is required.
    /// </summary>
    public required TransferInCancellationRequestV08 Message { get; init; }
}
