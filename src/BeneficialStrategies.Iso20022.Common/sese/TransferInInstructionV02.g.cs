﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for TransferInInstructionV02.  ISO2002 ID# _K0bo69E6Ed-BzquC8wXy7w_1159942342.
//
namespace BeneficialStrategies.Iso20022.sese;

/// <summary>
/// Scope
/// An instructing party, eg, an investment manager or its authorised representative, sends the TransferInInstruction message to the executing party, eg, a transfer agent, to instruct the receipt of a financial instrument, free of payment, on a given date from a specified party.
/// This message may also be used to instruct the receipt of a financial instrument, free of payment, from another of the instructing parties own accounts or from a third party.
/// Usage
/// The TransferInInstruction message is used to instruct the receipt of a financial instrument from another account, either owned by the instructing party or by a third party.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|An instructing party, eg, an investment manager or its authorised representative, sends the TransferInInstruction message to the executing party, eg, a transfer agent, to instruct the receipt of a financial instrument, free of payment, on a given date from a specified party.|This message may also be used to instruct the receipt of a financial instrument, free of payment, from another of the instructing parties own accounts or from a third party.|Usage|The TransferInInstruction message is used to instruct the receipt of a financial instrument from another account, either owned by the instructing party or by a third party.")]
public partial record TransferInInstructionV02 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "TrfInInstrV02";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Reference that uniquely identifies a message from a business application standpoint.
    /// </summary>
    [IsoId("_K0bo7NE6Ed-BzquC8wXy7w_1702048913")]
    [Description(@"Reference that uniquely identifies a message from a business application standpoint.")]
    [DataMember(Name="MsgId")]
    [XmlElement(ElementName="MsgId")]
    [Required]
    public required SomeMessageIdentificationRecord MessageIdentification { get; init; }
    
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_K0ky0NE6Ed-BzquC8wXy7w_1159942481")]
    [Description(@"Collective reference identifying a set of messages.")]
    [DataMember(Name="PoolRef")]
    [XmlElement(ElementName="PoolRef")]
    public SomePoolReferenceRecord? PoolReference { get; init; }
    
    /// <summary>
    /// Reference of the linked message which was previously sent.
    /// </summary>
    [IsoId("_K0ky0dE6Ed-BzquC8wXy7w_1159942764")]
    [Description(@"Reference of the linked message which was previously sent.")]
    [DataMember(Name="PrvsRef")]
    [XmlElement(ElementName="PrvsRef")]
    public SomePreviousReferenceRecord? PreviousReference { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_K0ky0tE6Ed-BzquC8wXy7w_1159942781")]
    [Description(@"Reference to a linked message that was previously received.")]
    [DataMember(Name="RltdRef")]
    [XmlElement(ElementName="RltdRef")]
    public SomeRelatedReferenceRecord? RelatedReference { get; init; }
    
    /// <summary>
    /// General information related to the transfer of a financial instrument.
    /// </summary>
    [IsoId("_K0ky09E6Ed-BzquC8wXy7w_1159942361")]
    [Description(@"General information related to the transfer of a financial instrument.")]
    [DataMember(Name="TrfDtls")]
    [XmlElement(ElementName="TrfDtls")]
    [Required]
    public required SomeTransferDetailsRecord TransferDetails { get; init; }
    
    /// <summary>
    /// Information related to the financial instrument to be received.
    /// </summary>
    [IsoId("_K0ky1NE6Ed-BzquC8wXy7w_1159942378")]
    [Description(@"Information related to the financial instrument to be received.")]
    [DataMember(Name="FinInstrmDtls")]
    [XmlElement(ElementName="FinInstrmDtls")]
    [Required]
    public required SomeFinancialInstrumentDetailsRecord FinancialInstrumentDetails { get; init; }
    
    /// <summary>
    /// Information related to the account into which the financial instrument is to be received.
    /// </summary>
    [IsoId("_K0ky1dE6Ed-BzquC8wXy7w_1159942421")]
    [Description(@"Information related to the account into which the financial instrument is to be received.")]
    [DataMember(Name="AcctDtls")]
    [XmlElement(ElementName="AcctDtls")]
    [Required]
    public required SomeAccountDetailsRecord AccountDetails { get; init; }
    
    /// <summary>
    /// Information related to the delivering side of the transfer.
    /// </summary>
    [IsoId("_K0ky1tE6Ed-BzquC8wXy7w_1159942438")]
    [Description(@"Information related to the delivering side of the transfer.")]
    [DataMember(Name="SttlmDtls")]
    [XmlElement(ElementName="SttlmDtls")]
    [Required]
    public required SomeSettlementDetailsRecord SettlementDetails { get; init; }
    
    /// <summary>
    /// Information provided when the message is a copy of a previous message.
    /// </summary>
    [IsoId("_K0uj0NE6Ed-BzquC8wXy7w_-79917810")]
    [Description(@"Information provided when the message is a copy of a previous message.")]
    [DataMember(Name="CpyDtls")]
    [XmlElement(ElementName="CpyDtls")]
    public SomeCopyDetailsRecord? CopyDetails { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_K0uj0dE6Ed-BzquC8wXy7w_1159942824")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="Xtnsn")]
    [XmlElement(ElementName="Xtnsn")]
    public SomeExtensionRecord? Extension { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="TransferInInstructionV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public TransferInInstructionV02Document ToDocument()
    {
        return new TransferInInstructionV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="TransferInInstructionV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record TransferInInstructionV02Document : IOuterDocument<TransferInInstructionV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.005.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="TransferInInstructionV02"/> is required.
    /// </summary>
    public required TransferInInstructionV02 Message { get; init; }
}
