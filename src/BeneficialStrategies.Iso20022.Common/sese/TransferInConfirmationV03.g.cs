﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for TransferInConfirmationV03.  ISO2002 ID# _69cEofpbEeCPwaG9zjUPNQ.
//
namespace BeneficialStrategies.Iso20022.sese;

/// <summary>
/// Scope
/// An executing party, for example, a transfer agent, sends the TransferInConfirmation message to the instructing party, for example, an investment manager or its authorised representative, to confirm the receipt of a financial instrument, free of payment, on a given date, from a specified party.
/// This message may also be used to confirm the receipt of a financial instrument, free of payment, from another of the instructing parties own accounts or from a third party.
/// Usage
/// The TransferInConfirmation message is used to confirm receipt of a financial instrument, either from another account owned by the instructing party or from a third party. The reference of the transfer confirmation is identified in TransferConfirmationReference.
/// The reference of the original transfer instruction is specified in TransferReference. The message identification of the TransferInInstruction message in which the transfer instruction was conveyed may also be quoted in RelatedReference.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|An executing party, for example, a transfer agent, sends the TransferInConfirmation message to the instructing party, for example, an investment manager or its authorised representative, to confirm the receipt of a financial instrument, free of payment, on a given date, from a specified party.|This message may also be used to confirm the receipt of a financial instrument, free of payment, from another of the instructing parties own accounts or from a third party.|Usage|The TransferInConfirmation message is used to confirm receipt of a financial instrument, either from another account owned by the instructing party or from a third party. The reference of the transfer confirmation is identified in TransferConfirmationReference.|The reference of the original transfer instruction is specified in TransferReference. The message identification of the TransferInInstruction message in which the transfer instruction was conveyed may also be quoted in RelatedReference.")]
public partial record TransferInConfirmationV03 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "TrfInConf";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Reference that uniquely identifies a message from a business application standpoint.
    /// </summary>
    [IsoId("_69cEpfpbEeCPwaG9zjUPNQ")]
    [Description(@"Reference that uniquely identifies a message from a business application standpoint.")]
    [DataMember(Name="MsgId")]
    [XmlElement(ElementName="MsgId")]
    [Required]
    public required MessageIdentification1 MessageIdentification { get; init; }
    
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_GvR0QENIEeGHJ_bHJRPaIQ_-1379795432")]
    [Description(@"Collective reference identifying a set of messages.")]
    [DataMember(Name="PoolRef")]
    [XmlElement(ElementName="PoolRef")]
    public AdditionalReference2? PoolReference { get; init; }
    
    /// <summary>
    /// Reference of the linked message that was previously sent.
    /// </summary>
    [IsoId("_IKoX8ENIEeGHJ_bHJRPaIQ_265472003")]
    [Description(@"Reference of the linked message that was previously sent.")]
    [DataMember(Name="PrvsRef")]
    [XmlElement(ElementName="PrvsRef")]
    public AdditionalReference2? PreviousReference { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_IKoX8UNIEeGHJ_bHJRPaIQ_1804260445")]
    [Description(@"Reference to a linked message that was previously received.")]
    [DataMember(Name="RltdRef")]
    [XmlElement(ElementName="RltdRef")]
    public AdditionalReference2? RelatedReference { get; init; }
    
    /// <summary>
    /// Unique and unambiguous identifier for a group of individual transfers as assigned by the instructing party. This identifier links the individual transfers together.
    /// </summary>
    [IsoId("_IKoX8kNIEeGHJ_bHJRPaIQ_1099145830")]
    [Description(@"Unique and unambiguous identifier for a group of individual transfers as assigned by the instructing party. This identifier links the individual transfers together.")]
    [DataMember(Name="MstrRef")]
    [XmlElement(ElementName="MstrRef")]
    public IsoMax35Text? MasterReference { get; init; }
    
    /// <summary>
    /// General information related to the transfer of a financial instrument.
    /// </summary>
    [IsoId("_69cEtfpbEeCPwaG9zjUPNQ")]
    [Description(@"General information related to the transfer of a financial instrument.")]
    [DataMember(Name="TrfDtls")]
    [XmlElement(ElementName="TrfDtls")]
    [Required]
    public required Transfer18 TransferDetails { get; init; }
    
    /// <summary>
    /// Information related to the account into which the financial instrument was received.
    /// </summary>
    [IsoId("_69cEvfpbEeCPwaG9zjUPNQ")]
    [Description(@"Information related to the account into which the financial instrument was received.")]
    [DataMember(Name="AcctDtls")]
    [XmlElement(ElementName="AcctDtls")]
    [Required]
    public required InvestmentAccount22 AccountDetails { get; init; }
    
    /// <summary>
    /// Information related to the delivering side of the transfer.
    /// </summary>
    [IsoId("_69cEwfpbEeCPwaG9zjUPNQ")]
    [Description(@"Information related to the delivering side of the transfer.")]
    [DataMember(Name="SttlmDtls")]
    [XmlElement(ElementName="SttlmDtls")]
    [Required]
    public required DeliverInformation6 SettlementDetails { get; init; }
    
    /// <summary>
    /// Information provided when the message is a copy of a previous message.
    /// </summary>
    [IsoId("_69cExfpbEeCPwaG9zjUPNQ")]
    [Description(@"Information provided when the message is a copy of a previous message.")]
    [DataMember(Name="CpyDtls")]
    [XmlElement(ElementName="CpyDtls")]
    public CopyInformation2? CopyDetails { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_69cEyfpbEeCPwaG9zjUPNQ")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="Xtnsn")]
    [XmlElement(ElementName="Xtnsn")]
    public Extension1? Extension { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="TransferInConfirmationV03Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public TransferInConfirmationV03Document ToDocument()
    {
        return new TransferInConfirmationV03Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="TransferInConfirmationV03"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record TransferInConfirmationV03Document : IOuterDocument<TransferInConfirmationV03>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.007.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="TransferInConfirmationV03"/> is required.
    /// </summary>
    public required TransferInConfirmationV03 Message { get; init; }
}
