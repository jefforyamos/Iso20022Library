﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for InitialBaselineSubmissionV04.  ISO2002 ID# _7DK6cdNTEeK-v49t1oWkNA.
//
namespace BeneficialStrategies.Iso20022.tsmt;

/// <summary>
/// Scope
/// The InitialBaselineSubmission message is sent by the initiator of a transaction to the matching application.
/// This message is used to initiate a transaction.
/// Usage
/// The InitialBaselineSubmission message can be sent by a party to register a transaction in the matching application. The message can be submitted with either lodge or push-through instruction.
/// When the push-through instruction is present, the matching application acknowledges the receipt of the message to the sender by sending an Acknowledgement message, stores the submitted information and informs the counterparty about the registration of the transaction by sending a FullPushThroughReport message. With the BaselineReSubmission message the counterparty responds with matching baseline information in order to establish the transaction (baseline).
/// When the lodge instruction is present, the matching application acknowledges the receipt of the message to the sender by sending an Acknowledgement message and stores the submitted information. No matching of the submitted baseline data with other baseline information will take place. For example the submission of an InitialBaselineSubmission message containing a lodge instruction establishes the transaction (baseline) in the matching application.
/// The InitialBaselineSubmission message consists of data which relates to the purchasing agreement covered by the transaction, for example line item details, shipping details.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The InitialBaselineSubmission message is sent by the initiator of a transaction to the matching application.|This message is used to initiate a transaction.|Usage|The InitialBaselineSubmission message can be sent by a party to register a transaction in the matching application. The message can be submitted with either lodge or push-through instruction.|When the push-through instruction is present, the matching application acknowledges the receipt of the message to the sender by sending an Acknowledgement message, stores the submitted information and informs the counterparty about the registration of the transaction by sending a FullPushThroughReport message. With the BaselineReSubmission message the counterparty responds with matching baseline information in order to establish the transaction (baseline).|When the lodge instruction is present, the matching application acknowledges the receipt of the message to the sender by sending an Acknowledgement message and stores the submitted information. No matching of the submitted baseline data with other baseline information will take place. For example the submission of an InitialBaselineSubmission message containing a lodge instruction establishes the transaction (baseline) in the matching application.|The InitialBaselineSubmission message consists of data which relates to the purchasing agreement covered by the transaction, for example line item details, shipping details.")]
public partial record InitialBaselineSubmissionV04 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "InitlBaselnSubmissn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Identifies the submitted information.
    /// </summary>
    [IsoId("_7DK6ddNTEeK-v49t1oWkNA")]
    [Description(@"Identifies the submitted information.")]
    [DataMember(Name="SubmissnId")]
    [XmlElement(ElementName="SubmissnId")]
    [Required]
    public required SomeSubmissionIdentificationRecord SubmissionIdentification { get; init; }
    
    /// <summary>
    /// Reference to the transaction for the requesting financial institution.
    /// </summary>
    [IsoId("_7DK6d9NTEeK-v49t1oWkNA")]
    [Description(@"Reference to the transaction for the requesting financial institution.")]
    [DataMember(Name="SubmitrTxRef")]
    [XmlElement(ElementName="SubmitrTxRef")]
    [Required]
    public required SomeSubmitterTransactionReferenceRecord SubmitterTransactionReference { get; init; }
    
    /// <summary>
    /// Specifies the instruction requested by the submitter by means of a code.
    /// </summary>
    [IsoId("_7DK6edNTEeK-v49t1oWkNA")]
    [Description(@"Specifies the instruction requested by the submitter by means of a code.")]
    [DataMember(Name="Instr")]
    [XmlElement(ElementName="Instr")]
    [Required]
    public required SomeInstructionRecord Instruction { get; init; }
    
    /// <summary>
    /// Specifies the commercial details of the underlying transaction.
    /// </summary>
    [IsoId("_7DK6e9NTEeK-v49t1oWkNA")]
    [Description(@"Specifies the commercial details of the underlying transaction.")]
    [DataMember(Name="Baseln")]
    [XmlElement(ElementName="Baseln")]
    [Required]
    public required SomeBaselineRecord Baseline { get; init; }
    
    /// <summary>
    /// Person to be contacted in the organisation of the buyer.
    /// </summary>
    [IsoId("_7DK6fdNTEeK-v49t1oWkNA")]
    [Description(@"Person to be contacted in the organisation of the buyer.")]
    [DataMember(Name="BuyrCtctPrsn")]
    [XmlElement(ElementName="BuyrCtctPrsn")]
    public SomeBuyerContactPersonRecord? BuyerContactPerson { get; init; }
    
    /// <summary>
    /// Person to be contacted in the organisation of the seller.
    /// </summary>
    [IsoId("_7DK6f9NTEeK-v49t1oWkNA")]
    [Description(@"Person to be contacted in the organisation of the seller.")]
    [DataMember(Name="SellrCtctPrsn")]
    [XmlElement(ElementName="SellrCtctPrsn")]
    public SomeSellerContactPersonRecord? SellerContactPerson { get; init; }
    
    /// <summary>
    /// Person to be contacted in the seller's bank or buyer's bank.
    /// </summary>
    [IsoId("_NtDmsDAaEeOKib24wnHaFg")]
    [Description(@"Person to be contacted in the seller's bank or buyer's bank.")]
    [DataMember(Name="BkCtctPrsn")]
    [XmlElement(ElementName="BkCtctPrsn")]
    [Required]
    public required SomeBankContactPersonRecord BankContactPerson { get; init; }
    
    /// <summary>
    /// Person to be contacted in another bank than seller or buyer's bank.
    /// </summary>
    [IsoId("_7DK6hdNTEeK-v49t1oWkNA")]
    [Description(@"Person to be contacted in another bank than seller or buyer's bank.")]
    [DataMember(Name="OthrBkCtctPrsn")]
    [XmlElement(ElementName="OthrBkCtctPrsn")]
    public SomeOtherBankContactPersonRecord? OtherBankContactPerson { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="InitialBaselineSubmissionV04Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public InitialBaselineSubmissionV04Document ToDocument()
    {
        return new InitialBaselineSubmissionV04Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="InitialBaselineSubmissionV04"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record InitialBaselineSubmissionV04Document : IOuterDocument<InitialBaselineSubmissionV04>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.019.001.04";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="InitialBaselineSubmissionV04"/> is required.
    /// </summary>
    public required InitialBaselineSubmissionV04 Message { get; init; }
}
