﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for ReversalOfTransferInConfirmationV09.  ISO2002 ID# _dPLusZDhEem7fvtoGpNpow.
//
namespace BeneficialStrategies.Iso20022.sese;

/// <summary>
/// Scope
/// The ReversalOfTransferInConfirmation message is sent by an executing party, for example, a transfer agent, to the instructing party, for example, an investment manager or its authorised representative, to cancel a previously sent transfer in confirmation.
/// Usage
/// The ReversalOfTransferInConfirmation message is used to reverse a previously sent transfer in confirmation.
/// To request the reversal of a transfer in confirmation, the transfer reference of the transfer in instruction, as specified in the original TransferInInstruction message, is specified in the transfer reference element. The executing party’s reference for the execution of the transfer may also be specified in the TransferConfirmationReference element.
/// The message identification of the original TransferInConfirmation message may also be quoted in PreviousReference but this is not recommended.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The ReversalOfTransferInConfirmation message is sent by an executing party, for example, a transfer agent, to the instructing party, for example, an investment manager or its authorised representative, to cancel a previously sent transfer in confirmation.|Usage|The ReversalOfTransferInConfirmation message is used to reverse a previously sent transfer in confirmation.|To request the reversal of a transfer in confirmation, the transfer reference of the transfer in instruction, as specified in the original TransferInInstruction message, is specified in the transfer reference element. The executing party’s reference for the execution of the transfer may also be specified in the TransferConfirmationReference element.|The message identification of the original TransferInConfirmation message may also be quoted in PreviousReference but this is not recommended.")]
public partial record ReversalOfTransferInConfirmationV09 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "RvslOfTrfInConf";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="ReversalOfTransferInConfirmationV09Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public ReversalOfTransferInConfirmationV09Document ToDocument()
    {
        return new ReversalOfTransferInConfirmationV09Document { Message = this };
    }
}

/// <summary>
/// Scope
/// The ReversalOfTransferInConfirmation message is sent by an executing party, for example, a transfer agent, to the instructing party, for example, an investment manager or its authorised representative, to cancel a previously sent transfer in confirmation.
/// Usage
/// The ReversalOfTransferInConfirmation message is used to reverse a previously sent transfer in confirmation.
/// To request the reversal of a transfer in confirmation, the transfer reference of the transfer in instruction, as specified in the original TransferInInstruction message, is specified in the transfer reference element. The executing party’s reference for the execution of the transfer may also be specified in the TransferConfirmationReference element.
/// The message identification of the original TransferInConfirmation message may also be quoted in PreviousReference but this is not recommended.
/// This is the outer document that contains <seealso cref="ReversalOfTransferInConfirmationV09"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record ReversalOfTransferInConfirmationV09Document : IOuterDocument<ReversalOfTransferInConfirmationV09>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.008.001.09";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="ReversalOfTransferInConfirmationV09"/> is required.
    /// </summary>
    public required ReversalOfTransferInConfirmationV09 Message { get; init; }
}
