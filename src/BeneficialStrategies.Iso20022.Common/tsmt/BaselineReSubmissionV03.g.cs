﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for BaselineReSubmissionV03.  ISO2002 ID# _mYyq4tE8Ed-BzquC8wXy7w_-2146835428.
//
namespace BeneficialStrategies.Iso20022.tsmt;

/// <summary>
/// Scope
/// The BaselineReSubmission message is sent by either the counterparty or the initiator of a transaction (baseline) to the matching application.
/// This message is used by the counterparty to respond on the registration of a push-through transaction in the matching application or by the initiator or counterparty to re-send earlier mis-matched baseline information.
/// Usage
/// The BaselineReSubmission message can be sent by the counterparty of a transaction to the matching application in response to a FullPushThroughReport message received from the matching application conveying the details of an InitialBaselineSubmission message. The objective of the BaselineReSubmission message sent in the outlined scenario is to achieve a successful match of two baseline initiation messages in order to establish a transaction in the matching application.
/// or
/// The BaselineReSubmission message can be sent by the initiator of a transaction to the matching application in response to a BaselineMatchReport message indicating mis-matches. The objective of the BaselineReSubmission message sent in the outlined scenario is to correct an InitialBaselineSubmission or BaselineReSubmission message submitted earlier in order to achieve the establishment of a transaction in the matching application.
/// or
/// The BaselineReSubmission message can be sent by the counterparty of a transaction to the matching application in response to a BaselineMatchReport message indicating mis-matches. The objective of the BaselineReSubmission message sent in the outlined scenario is to correct a BaselineReSubmission message submitted earlier in order to achieve the establishment of a transaction in the matching application.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The BaselineReSubmission message is sent by either the counterparty or the initiator of a transaction (baseline) to the matching application.|This message is used by the counterparty to respond on the registration of a push-through transaction in the matching application or by the initiator or counterparty to re-send earlier mis-matched baseline information.|Usage|The BaselineReSubmission message can be sent by the counterparty of a transaction to the matching application in response to a FullPushThroughReport message received from the matching application conveying the details of an InitialBaselineSubmission message. The objective of the BaselineReSubmission message sent in the outlined scenario is to achieve a successful match of two baseline initiation messages in order to establish a transaction in the matching application.|or|The BaselineReSubmission message can be sent by the initiator of a transaction to the matching application in response to a BaselineMatchReport message indicating mis-matches. The objective of the BaselineReSubmission message sent in the outlined scenario is to correct an InitialBaselineSubmission or BaselineReSubmission message submitted earlier in order to achieve the establishment of a transaction in the matching application.|or|The BaselineReSubmission message can be sent by the counterparty of a transaction to the matching application in response to a BaselineMatchReport message indicating mis-matches. The objective of the BaselineReSubmission message sent in the outlined scenario is to correct a BaselineReSubmission message submitted earlier in order to achieve the establishment of a transaction in the matching application.")]
public partial record BaselineReSubmissionV03 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "BaselnReSubmissn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Identifies the submitted information.
    /// </summary>
    [IsoId("_mYyq49E8Ed-BzquC8wXy7w_-2146835384")]
    [Description(@"Identifies the submitted information.")]
    [DataMember(Name="SubmissnId")]
    [XmlElement(ElementName="SubmissnId")]
    [Required]
    public required SomeSubmissionIdentificationRecord SubmissionIdentification { get; init; }
    
    /// <summary>
    /// Unique identification assigned by the matching application to the transaction.|This identification is to be used in any communication between the parties.
    /// </summary>
    [IsoId("_mYyq5NE8Ed-BzquC8wXy7w_-2146835402")]
    [Description(@"Unique identification assigned by the matching application to the transaction.|This identification is to be used in any communication between the parties.")]
    [DataMember(Name="TxId")]
    [XmlElement(ElementName="TxId")]
    [Required]
    public required SomeTransactionIdentificationRecord TransactionIdentification { get; init; }
    
    /// <summary>
    /// Reference to the transaction for the requesting financial institution.
    /// </summary>
    [IsoId("_mYyq5dE8Ed-BzquC8wXy7w_-2146835349")]
    [Description(@"Reference to the transaction for the requesting financial institution.")]
    [DataMember(Name="SubmitrTxRef")]
    [XmlElement(ElementName="SubmitrTxRef")]
    public SomeSubmitterTransactionReferenceRecord? SubmitterTransactionReference { get; init; }
    
    /// <summary>
    /// Specifies the commercial details of the underlying transaction.
    /// </summary>
    [IsoId("_mYyq5tE8Ed-BzquC8wXy7w_-2146835307")]
    [Description(@"Specifies the commercial details of the underlying transaction.")]
    [DataMember(Name="Baseln")]
    [XmlElement(ElementName="Baseln")]
    [Required]
    public required SomeBaselineRecord Baseline { get; init; }
    
    /// <summary>
    /// Person to be contacted in the organisation of the buyer.
    /// </summary>
    [IsoId("_mYyq59E8Ed-BzquC8wXy7w_-2146835047")]
    [Description(@"Person to be contacted in the organisation of the buyer.")]
    [DataMember(Name="BuyrCtctPrsn")]
    [XmlElement(ElementName="BuyrCtctPrsn")]
    public SomeBuyerContactPersonRecord? BuyerContactPerson { get; init; }
    
    /// <summary>
    /// Person to be contacted in the organisation of the seller.
    /// </summary>
    [IsoId("_mYyq6NE8Ed-BzquC8wXy7w_-2146834549")]
    [Description(@"Person to be contacted in the organisation of the seller.")]
    [DataMember(Name="SellrCtctPrsn")]
    [XmlElement(ElementName="SellrCtctPrsn")]
    public SomeSellerContactPersonRecord? SellerContactPerson { get; init; }
    
    /// <summary>
    /// Person to be contacted in the buyer's bank.
    /// </summary>
    [IsoId("_mYyq6dE8Ed-BzquC8wXy7w_-2146834627")]
    [Description(@"Person to be contacted in the buyer's bank.")]
    [DataMember(Name="BuyrBkCtctPrsn")]
    [XmlElement(ElementName="BuyrBkCtctPrsn")]
    [Required]
    public required SomeBuyerBankContactPersonRecord BuyerBankContactPerson { get; init; }
    
    /// <summary>
    /// Person to be contacted in the seller's bank.
    /// </summary>
    [IsoId("_mY700NE8Ed-BzquC8wXy7w_-2146834952")]
    [Description(@"Person to be contacted in the seller's bank.")]
    [DataMember(Name="SellrBkCtctPrsn")]
    [XmlElement(ElementName="SellrBkCtctPrsn")]
    [Required]
    public required SomeSellerBankContactPersonRecord SellerBankContactPerson { get; init; }
    
    /// <summary>
    /// Person to be contacted in another bank than the seller or buyer's bank.
    /// </summary>
    [IsoId("_mY700dE8Ed-BzquC8wXy7w_2007041364")]
    [Description(@"Person to be contacted in another bank than the seller or buyer's bank.")]
    [DataMember(Name="OthrBkCtctPrsn")]
    [XmlElement(ElementName="OthrBkCtctPrsn")]
    public SomeOtherBankContactPersonRecord? OtherBankContactPerson { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="BaselineReSubmissionV03Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public BaselineReSubmissionV03Document ToDocument()
    {
        return new BaselineReSubmissionV03Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="BaselineReSubmissionV03"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record BaselineReSubmissionV03Document : IOuterDocument<BaselineReSubmissionV03>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.012.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="BaselineReSubmissionV03"/> is required.
    /// </summary>
    public required BaselineReSubmissionV03 Message { get; init; }
}
