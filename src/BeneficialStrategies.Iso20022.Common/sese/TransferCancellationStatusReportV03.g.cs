﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for TransferCancellationStatusReportV03.  ISO2002 ID# _By8j4fpcEeCPwaG9zjUPNQ.
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
/// This record is an implementation of the sese.010.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An executing party, for example, a transfer agent, sends the TransferCancellationStatusReport message to the instructing party, for example, an investment manager or one of its authorised representatives to provide the status of a previously received transfer cancellation instruction.
/// Usage
/// The TransferCancellationStatusReport message is used to report on the status of a transfer in or transfer out cancellation request.
/// The reference of the transfer instruction for which the cancellation status is reported is identified in TransferReference. The message identification of the transfer cancellation request message in which the transfer instruction was conveyed may also be quoted in RelatedReference.
/// The message identification of the transfer instruction request message in which the transfer instruction was conveyed may also be quoted in RelatedReference.
/// One of the following statuses can be reported:
/// - the transfer cancellation is accepted, or,
/// - the transfer cancellation has been sent to the next party, or,
/// - the transfer cancellation is complete and the reason for the status,
/// - the transfer cancellation pending and the reason for the status,
/// - the transfer cancellation is rejected and the reason for the status.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|An executing party, for example, a transfer agent, sends the TransferCancellationStatusReport message to the instructing party, for example, an investment manager or one of its authorised representatives to provide the status of a previously received transfer cancellation instruction.|Usage|The TransferCancellationStatusReport message is used to report on the status of a transfer in or transfer out cancellation request.|The reference of the transfer instruction for which the cancellation status is reported is identified in TransferReference. The message identification of the transfer cancellation request message in which the transfer instruction was conveyed may also be quoted in RelatedReference.|The message identification of the transfer instruction request message in which the transfer instruction was conveyed may also be quoted in RelatedReference.|One of the following statuses can be reported:|- the transfer cancellation is accepted, or,|- the transfer cancellation has been sent to the next party, or,|- the transfer cancellation is complete and the reason for the status,|- the transfer cancellation pending and the reason for the status,|- the transfer cancellation is rejected and the reason for the status.")]
public partial record TransferCancellationStatusReportV03 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.010.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "TrfCxlStsRpt";
    
    #nullable enable
    /// <summary>
    /// Reference that uniquely identifies a message from a business application standpoint.
    /// </summary>
    [IsoId("_By8j9fpcEeCPwaG9zjUPNQ")]
    [Description(@"Reference that uniquely identifies a message from a business application standpoint.")]
    [DataMember(Name="MsgId")]
    [XmlElement(ElementName="MsgId")]
    [Required]
    public required MessageIdentification1 MessageIdentification { get; init; }
    
    /// <summary>
    /// Unambiguous identification of the transfer allocated by the counterparty.
    /// </summary>
    [IsoId("_OSfsY_suEeCpzfkT8_hM5g")]
    [Description(@"Unambiguous identification of the transfer allocated by the counterparty.")]
    [DataMember(Name="CtrPtyRef")]
    [XmlElement(ElementName="CtrPtyRef")]
    public AdditionalReference2? CounterpartyReference { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_By8j-fpcEeCPwaG9zjUPNQ")]
    [Description(@"Reference to a linked message that was previously received.")]
    [DataMember(Name="RltdRef")]
    [XmlElement(ElementName="RltdRef")]
    public required IReadOnlyCollection<AdditionalReference3> RelatedReference { get; init; } = []; // Min=0, Max=2
    
    /// <summary>
    /// Reference to the linked message sent in a proprietary way or the reference of a system.
    /// </summary>
    [IsoId("_By8j_fpcEeCPwaG9zjUPNQ")]
    [Description(@"Reference to the linked message sent in a proprietary way or the reference of a system.")]
    [DataMember(Name="OthrRef")]
    [XmlElement(ElementName="OthrRef")]
    public required IReadOnlyCollection<AdditionalReference3> OtherReference { get; init; } = []; // Min=0, Max=2
    
    /// <summary>
    /// Status of the transfer cancellation instruction.
    /// </summary>
    [IsoId("_By8kAfpcEeCPwaG9zjUPNQ")]
    [Description(@"Status of the transfer cancellation instruction.")]
    [DataMember(Name="StsRpt")]
    [XmlElement(ElementName="StsRpt")]
    [Required]
    public required CancellationStatusAndReason2 StatusReport { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_By8kBfpcEeCPwaG9zjUPNQ")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="Xtnsn")]
    [XmlElement(ElementName="Xtnsn")]
    public Extension1? Extension { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="TransferCancellationStatusReportV03Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public TransferCancellationStatusReportV03Document ToDocument()
    {
        return new TransferCancellationStatusReportV03Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="TransferCancellationStatusReportV03"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record TransferCancellationStatusReportV03Document : IOuterDocument<TransferCancellationStatusReportV03>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.010.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="TransferCancellationStatusReportV03"/> is required.
    /// </summary>
    public required TransferCancellationStatusReportV03 Message { get; init; }
}
