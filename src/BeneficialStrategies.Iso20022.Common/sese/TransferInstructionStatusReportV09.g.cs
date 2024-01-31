﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for TransferInstructionStatusReportV09.  ISO2002 ID# _NesJgdx9EeqKxsvOxFQHKA.
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
/// This record is an implementation of the sese.011.001.09 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The TransferInstructionStatusReport message is sent by an executing party, for example, a transfer agent, to the instructing party, for example, an investment manager or one of its authorised representatives to provide the status of a previously received request for holdings information, portfolio transfer or transfer instruction.
///  It may also be used to report the status of an event related to the asset being transferred or provide additional information.
/// The TransferInstructionStatusReport message may also be sent by any party in the transfer transaction to another party in the transfer transaction chain to provide information relevant for the settlement of a transfer transaction. 
/// Usage
/// The TransferInstructionStatusReport message is used to provide the status of a previously received request for holdings information, portfolio transfer or transfer instruction, or in response to a RequestForTransferStatus message. It may also be used to report the status of an event related to the asset being transferred or provide additional information.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The TransferInstructionStatusReport message is sent by an executing party, for example, a transfer agent, to the instructing party, for example, an investment manager or one of its authorised representatives to provide the status of a previously received request for holdings information, portfolio transfer or transfer instruction.| It may also be used to report the status of an event related to the asset being transferred or provide additional information.|The TransferInstructionStatusReport message may also be sent by any party in the transfer transaction to another party in the transfer transaction chain to provide information relevant for the settlement of a transfer transaction. |Usage|The TransferInstructionStatusReport message is used to provide the status of a previously received request for holdings information, portfolio transfer or transfer instruction, or in response to a RequestForTransferStatus message. It may also be used to report the status of an event related to the asset being transferred or provide additional information.")]
public partial record TransferInstructionStatusReportV09 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.011.001.09";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "TrfInstrStsRpt";
    
    #nullable enable
    /// <summary>
    /// Reference that uniquely identifies the message from a business application standpoint.
    /// </summary>
    [IsoId("_NesJi9x9EeqKxsvOxFQHKA")]
    [Description(@"Reference that uniquely identifies the message from a business application standpoint.")]
    [DataMember(Name="MsgId")]
    [XmlElement(ElementName="MsgId")]
    [Required]
    public required MessageIdentification1 MessageIdentification { get; init; }
    
    /// <summary>
    /// Unambiguous identification of the transfer allocated by the counterparty.
    /// </summary>
    [IsoId("_NesJjdx9EeqKxsvOxFQHKA")]
    [Description(@"Unambiguous identification of the transfer allocated by the counterparty.")]
    [DataMember(Name="CtrPtyRef")]
    [XmlElement(ElementName="CtrPtyRef")]
    public AdditionalReference10? CounterpartyReference { get; init; }
    
    /// <summary>
    /// Reference to the message or communication that was previously received.
    /// </summary>
    [IsoId("_NesJj9x9EeqKxsvOxFQHKA")]
    [Description(@"Reference to the message or communication that was previously received.")]
    [DataMember(Name="Ref")]
    [XmlElement(ElementName="Ref")]
    public IReferences64Choice? Reference { get; init; }
    
    /// <summary>
    /// Status of the transfer instruction.
    /// </summary>
    [IsoId("_NesJkdx9EeqKxsvOxFQHKA")]
    [Description(@"Status of the transfer instruction.")]
    [DataMember(Name="StsRpt")]
    [XmlElement(ElementName="StsRpt")]
    [Required]
    public required TransferStatusAndReason8 StatusReport { get; init; }
    
    /// <summary>
    /// Identifies the market practice to which the message conforms.
    /// </summary>
    [IsoId("_NesJk9x9EeqKxsvOxFQHKA")]
    [Description(@"Identifies the market practice to which the message conforms.")]
    [DataMember(Name="MktPrctcVrsn")]
    [XmlElement(ElementName="MktPrctcVrsn")]
    public MarketPracticeVersion1? MarketPracticeVersion { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_NesJldx9EeqKxsvOxFQHKA")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="Xtnsn")]
    [XmlElement(ElementName="Xtnsn")]
    public Extension1? Extension { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="TransferInstructionStatusReportV09Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public TransferInstructionStatusReportV09Document ToDocument()
    {
        return new TransferInstructionStatusReportV09Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="TransferInstructionStatusReportV09"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record TransferInstructionStatusReportV09Document : IOuterDocument<TransferInstructionStatusReportV09>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.011.001.09";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="TransferInstructionStatusReportV09"/> is required.
    /// </summary>
    public required TransferInstructionStatusReportV09 Message { get; init; }
}
