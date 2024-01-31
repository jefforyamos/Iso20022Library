﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for ReversalOfTransferOutConfirmationV02.  ISO2002 ID# _qHtUANE5Ed-BzquC8wXy7w_2129397572.
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
/// This record is an implementation of the sese.004.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An executing party, eg, a transfer agent, sends the ReversalOfTransferOutConfirmation message to the instructing party, eg, an investment manager or its authorised representative, to cancel a previously sent TransferOutConfirmation message.
/// Usage
/// The ReversalOfTransferOutConfirmation message is used to reverse a previously sent TransferOutConfirmation.
/// There are two ways to specify the reversal of the transfer out confirmation. Either:
/// - the business references, eg, TransferReference, TransferConfirmationIdentification, of the transfer confirmation are quoted, or,
/// - all the details of the transfer confirmation (this includes TransferReference and TransferConfirmationIdentification) are quoted but this is not recommended.
/// The message identification of the TransferOutConfirmation message in which the transfer out confirmation was conveyed may also be quoted in PreviousReference. The message identification of the TransferOutInstruction message in which the transfer out instruction was conveyed may also be quoted in RelatedReference.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|An executing party, eg, a transfer agent, sends the ReversalOfTransferOutConfirmation message to the instructing party, eg, an investment manager or its authorised representative, to cancel a previously sent TransferOutConfirmation message.|Usage|The ReversalOfTransferOutConfirmation message is used to reverse a previously sent TransferOutConfirmation.|There are two ways to specify the reversal of the transfer out confirmation. Either:|- the business references, eg, TransferReference, TransferConfirmationIdentification, of the transfer confirmation are quoted, or,|- all the details of the transfer confirmation (this includes TransferReference and TransferConfirmationIdentification) are quoted but this is not recommended.|The message identification of the TransferOutConfirmation message in which the transfer out confirmation was conveyed may also be quoted in PreviousReference. The message identification of the TransferOutInstruction message in which the transfer out instruction was conveyed may also be quoted in RelatedReference.")]
public partial record ReversalOfTransferOutConfirmationV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.004.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "RvslOfTrfOutConfV02";
    
    #nullable enable
    /// <summary>
    /// Reference that uniquely identifies a message from a business application standpoint.
    /// </summary>
    [IsoId("_qHtUAdE5Ed-BzquC8wXy7w_-1423982188")]
    [Description(@"Reference that uniquely identifies a message from a business application standpoint.")]
    [DataMember(Name="MsgId")]
    [XmlElement(ElementName="MsgId")]
    [Required]
    public required MessageIdentification1 MessageIdentification { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_qHtUAtE5Ed-BzquC8wXy7w_2129397591")]
    [Description(@"Reference to a linked message that was previously sent.")]
    [DataMember(Name="PrvsRef")]
    [XmlElement(ElementName="PrvsRef")]
    public AdditionalReference2? PreviousReference { get; init; }
    
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_qHtUA9E5Ed-BzquC8wXy7w_2129397693")]
    [Description(@"Collective reference identifying a set of messages.")]
    [DataMember(Name="PoolRef")]
    [XmlElement(ElementName="PoolRef")]
    public AdditionalReference2? PoolReference { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_qHtUBNE5Ed-BzquC8wXy7w_2129397650")]
    [Description(@"Reference to a linked message that was previously received.")]
    [DataMember(Name="RltdRef")]
    [XmlElement(ElementName="RltdRef")]
    public AdditionalReference2? RelatedReference { get; init; }
    
    /// <summary>
    /// Reference of the transfer out confirmation to be reversed.
    /// </summary>
    [IsoId("_qHtUBdE5Ed-BzquC8wXy7w_61046308")]
    [Description(@"Reference of the transfer out confirmation to be reversed.")]
    [DataMember(Name="RvslByRef")]
    [XmlElement(ElementName="RvslByRef")]
    public TransferReference2? ReversalByReference { get; init; }
    
    /// <summary>
    /// Copy of the transfer out confirmation to reverse.
    /// </summary>
    [IsoId("_qHtUBtE5Ed-BzquC8wXy7w_2129397633")]
    [Description(@"Copy of the transfer out confirmation to reverse.")]
    [DataMember(Name="RvslByTrfOutConfDtls")]
    [XmlElement(ElementName="RvslByTrfOutConfDtls")]
    public TransferOut6? ReversalByTransferOutConfirmationDetails { get; init; }
    
    /// <summary>
    /// Information provided when the message is a copy of a previous message.
    /// </summary>
    [IsoId("_qHtUB9E5Ed-BzquC8wXy7w_632775009")]
    [Description(@"Information provided when the message is a copy of a previous message.")]
    [DataMember(Name="CpyDtls")]
    [XmlElement(ElementName="CpyDtls")]
    public CopyInformation2? CopyDetails { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="ReversalOfTransferOutConfirmationV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public ReversalOfTransferOutConfirmationV02Document ToDocument()
    {
        return new ReversalOfTransferOutConfirmationV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="ReversalOfTransferOutConfirmationV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record ReversalOfTransferOutConfirmationV02Document : IOuterDocument<ReversalOfTransferOutConfirmationV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.004.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="ReversalOfTransferOutConfirmationV02"/> is required.
    /// </summary>
    public required ReversalOfTransferOutConfirmationV02 Message { get; init; }
}
