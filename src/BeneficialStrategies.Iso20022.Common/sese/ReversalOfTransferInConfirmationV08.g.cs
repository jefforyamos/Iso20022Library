﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for ReversalOfTransferInConfirmationV08.  ISO2002 ID# _2G_jUYZLEeemXK0UETsSiA.
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
/// The ReversalOfTransferInConfirmation message is sent by the executing party, for example, a transfer agent, to the instructing party, for example, an investment manager or its authorised representative, to cancel a previously sent transfer in confirmation.
/// Usage
/// The ReversalOfTransferInConfirmation message is used to reverse a previously sent transfer in confirmation.
/// To request the reversal of a transfer in confirmation, the transfer reference of the transfer in instruction, as specified in the original TransferInInstruction message, is specified in the transfer reference element. The executing party’s reference for the execution of the transfer may also be specified in the TransferConfirmationReference element.
/// The message identification of the original TransferInConfirmation message may also be quoted in PreviousReference but this is not recommended.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The ReversalOfTransferInConfirmation message is sent by the executing party, for example, a transfer agent, to the instructing party, for example, an investment manager or its authorised representative, to cancel a previously sent transfer in confirmation.|Usage|The ReversalOfTransferInConfirmation message is used to reverse a previously sent transfer in confirmation.|To request the reversal of a transfer in confirmation, the transfer reference of the transfer in instruction, as specified in the original TransferInInstruction message, is specified in the transfer reference element. The executing party’s reference for the execution of the transfer may also be specified in the TransferConfirmationReference element.|The message identification of the original TransferInConfirmation message may also be quoted in PreviousReference but this is not recommended.")]
public partial record ReversalOfTransferInConfirmationV08 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "RvslOfTrfInConf";
    
    #nullable enable
    /// <summary>
    /// Reference that uniquely identifies the message from a business application standpoint.
    /// </summary>
    [IsoId("_2G_jVYZLEeemXK0UETsSiA")]
    [Description(@"Reference that uniquely identifies the message from a business application standpoint.")]
    [DataMember(Name="MsgId")]
    [XmlElement(ElementName="MsgId")]
    [Required]
    public required MessageIdentification1 MessageIdentification { get; init; }
    
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_m_nYs4i1EeefvMoXmllHqg")]
    [Description(@"Collective reference identifying a set of messages.")]
    [DataMember(Name="PoolRef")]
    [XmlElement(ElementName="PoolRef")]
    public AdditionalReference9? PoolReference { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_m_nYtIi1EeefvMoXmllHqg")]
    [Description(@"Reference to a linked message that was previously sent.")]
    [DataMember(Name="PrvsRef")]
    [XmlElement(ElementName="PrvsRef")]
    public AdditionalReference8? PreviousReference { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_m_n_wIi1EeefvMoXmllHqg")]
    [Description(@"Reference to a linked message that was previously received.")]
    [DataMember(Name="RltdRef")]
    [XmlElement(ElementName="RltdRef")]
    public AdditionalReference8? RelatedReference { get; init; }
    
    /// <summary>
    /// Unique and unambiguous identifier for a group of individual transfers as assigned by the instructing party. This identifier links the individual transfers together.
    /// </summary>
    [IsoId("_yjJGQYi1EeefvMoXmllHqg")]
    [Description(@"Unique and unambiguous identifier for a group of individual transfers as assigned by the instructing party. This identifier links the individual transfers together.")]
    [DataMember(Name="MstrRef")]
    [XmlElement(ElementName="MstrRef")]
    public IsoMax35Text? MasterReference { get; init; }
    
    /// <summary>
    /// Function of the transfer-in, that is, whether the message is used as a reversal of a previously sent confirmation or as a reversal of a previously sent advice. The absence of Function indicates the message is a reversal of a previously sent confirmation.
    /// </summary>
    [IsoId("_2G_jWYZLEeemXK0UETsSiA")]
    [Description(@"Function of the transfer-in, that is, whether the message is used as a reversal of a previously sent confirmation or as a reversal of a previously sent advice. The absence of Function indicates the message is a reversal of a previously sent confirmation.")]
    [DataMember(Name="Fctn")]
    [XmlElement(ElementName="Fctn")]
    public TransferInFunction2Code? Function { get; init; }
    
    /// <summary>
    /// Reference of the transfer confirmation to be reversed.
    /// </summary>
    [IsoId("_wTn6sYi1EeefvMoXmllHqg")]
    [Description(@"Reference of the transfer confirmation to be reversed.")]
    [DataMember(Name="Ref")]
    [XmlElement(ElementName="Ref")]
    [Required]
    public required TransferReference12 Reference { get; init; }
    
    /// <summary>
    /// Identifies the market practice to which the message conforms.
    /// </summary>
    [IsoId("_2G_jXYZLEeemXK0UETsSiA")]
    [Description(@"Identifies the market practice to which the message conforms.")]
    [DataMember(Name="MktPrctcVrsn")]
    [XmlElement(ElementName="MktPrctcVrsn")]
    public MarketPracticeVersion1? MarketPracticeVersion { get; init; }
    
    /// <summary>
    /// Information provided when the message is a copy of a previous message.
    /// </summary>
    [IsoId("_2G_jX4ZLEeemXK0UETsSiA")]
    [Description(@"Information provided when the message is a copy of a previous message.")]
    [DataMember(Name="CpyDtls")]
    [XmlElement(ElementName="CpyDtls")]
    public CopyInformation4? CopyDetails { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="ReversalOfTransferInConfirmationV08Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public ReversalOfTransferInConfirmationV08Document ToDocument()
    {
        return new ReversalOfTransferInConfirmationV08Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="ReversalOfTransferInConfirmationV08"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record ReversalOfTransferInConfirmationV08Document : IOuterDocument<ReversalOfTransferInConfirmationV08>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.008.001.08";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="ReversalOfTransferInConfirmationV08"/> is required.
    /// </summary>
    public required ReversalOfTransferInConfirmationV08 Message { get; init; }
}
