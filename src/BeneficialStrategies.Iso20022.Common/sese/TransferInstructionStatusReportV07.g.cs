﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for TransferInstructionStatusReportV07.  ISO2002 ID# _EObOgVNUEeijdq8ilaxyOA.
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
/// Scope|
/// The TransferInstructionStatusReport message is sent by an executing party, for example, a transfer agent, to the instructing party, for example, an investment manager or one of its authorised representatives to provide the status of a previously received request for holdings information, portfolio transfer or transfer instruction.| It may also be used to report the status of an event related to the asset being transferred or provide additional information.|
/// Usage|
/// The TransferInstructionStatusReport message is sent by an executing party, for example, a transfer agent, to the instructing party, for example, an investment manager or one of its authorised representatives to provide the status of a previously received request for holdings information, portfolio transfer or transfer instruction. It may also be used to report the status of an event related to the asset being transferred or provide additional information.
/// The message identification of the transfer instruction message in which the transfer instruction was conveyed may also be quoted in RelatedReference.|
/// One of the following statuses can be reported:|
/// - an accepted status, or,|
/// - an already executed status, or,|
/// - a sent to next party status, or,|
/// - a matched status, or,|
/// - a settled status, or,|
/// - a delayed status, or, 
/// - a pending settlement status and the reason for the status, or,|
/// - an unmatched status and the reason for the status, or,|
/// - an in-repair status and the reason for the status, or,|
/// - a rejected status and the reason for the status, or,|
/// - a failed settlement status and the reason for the status, or,|
/// - a cancelled status and the reason for the status, or,|
/// - a cancelled status and the reason for the status, or,|
/// - a cancellation pending status and the reason for the status.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope||The TransferInstructionStatusReport message is sent by an executing party, for example, a transfer agent, to the instructing party, for example, an investment manager or one of its authorised representatives to provide the status of a previously received request for holdings information, portfolio transfer or transfer instruction.| It may also be used to report the status of an event related to the asset being transferred or provide additional information.||Usage||The TransferInstructionStatusReport message is sent by an executing party, for example, a transfer agent, to the instructing party, for example, an investment manager or one of its authorised representatives to provide the status of a previously received request for holdings information, portfolio transfer or transfer instruction. It may also be used to report the status of an event related to the asset being transferred or provide additional information.|The message identification of the transfer instruction message in which the transfer instruction was conveyed may also be quoted in RelatedReference.||One of the following statuses can be reported:||- an accepted status, or,||- an already executed status, or,||- a sent to next party status, or,||- a matched status, or,||- a settled status, or,||- a delayed status, or, |- a pending settlement status and the reason for the status, or,||- an unmatched status and the reason for the status, or,||- an in-repair status and the reason for the status, or,||- a rejected status and the reason for the status, or,||- a failed settlement status and the reason for the status, or,||- a cancelled status and the reason for the status, or,||- a cancelled status and the reason for the status, or,||- a cancellation pending status and the reason for the status.")]
public partial record TransferInstructionStatusReportV07 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "TrfInstrStsRpt";
    
    #nullable enable
    /// <summary>
    /// Reference that uniquely identifies the message from a business application standpoint.
    /// </summary>
    [IsoId("_EObOh1NUEeijdq8ilaxyOA")]
    [Description(@"Reference that uniquely identifies the message from a business application standpoint.")]
    [DataMember(Name="MsgId")]
    [XmlElement(ElementName="MsgId")]
    [Required]
    public required MessageIdentification1 MessageIdentification { get; init; }
    
    /// <summary>
    /// Unambiguous identification of the transfer allocated by the counterparty.
    /// </summary>
    [IsoId("_EObOiVNUEeijdq8ilaxyOA")]
    [Description(@"Unambiguous identification of the transfer allocated by the counterparty.")]
    [DataMember(Name="CtrPtyRef")]
    [XmlElement(ElementName="CtrPtyRef")]
    public AdditionalReference10? CounterpartyReference { get; init; }
    
    /// <summary>
    /// Reference to the message or communication that was previously received.
    /// </summary>
    [IsoId("_EObOi1NUEeijdq8ilaxyOA")]
    [Description(@"Reference to the message or communication that was previously received.")]
    [DataMember(Name="Ref")]
    [XmlElement(ElementName="Ref")]
    public IReferences64Choice? Reference { get; init; }
    
    /// <summary>
    /// Status of the transfer instruction.
    /// </summary>
    [IsoId("_EObOjVNUEeijdq8ilaxyOA")]
    [Description(@"Status of the transfer instruction.")]
    [DataMember(Name="StsRpt")]
    [XmlElement(ElementName="StsRpt")]
    [Required]
    public required TransferStatusAndReason6 StatusReport { get; init; }
    
    /// <summary>
    /// Identifies the market practice to which the message conforms.
    /// </summary>
    [IsoId("_EObOj1NUEeijdq8ilaxyOA")]
    [Description(@"Identifies the market practice to which the message conforms.")]
    [DataMember(Name="MktPrctcVrsn")]
    [XmlElement(ElementName="MktPrctcVrsn")]
    public MarketPracticeVersion1? MarketPracticeVersion { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_EObOkVNUEeijdq8ilaxyOA")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="Xtnsn")]
    [XmlElement(ElementName="Xtnsn")]
    public Extension1? Extension { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="TransferInstructionStatusReportV07Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public TransferInstructionStatusReportV07Document ToDocument()
    {
        return new TransferInstructionStatusReportV07Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="TransferInstructionStatusReportV07"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record TransferInstructionStatusReportV07Document : IOuterDocument<TransferInstructionStatusReportV07>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.011.001.07";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="TransferInstructionStatusReportV07"/> is required.
    /// </summary>
    public required TransferInstructionStatusReportV07 Message { get; init; }
}
