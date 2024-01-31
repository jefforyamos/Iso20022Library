﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for InitialBaselineSubmissionV03.  ISO2002 ID# _p4KUyNE8Ed-BzquC8wXy7w_-1224818269.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

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
public partial record InitialBaselineSubmissionV03 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "InitlBaselnSubmissn";
    
    #nullable enable
    /// <summary>
    /// Identifies the submitted information.
    /// </summary>
    [IsoId("_p4TesNE8Ed-BzquC8wXy7w_-1224818173")]
    [Description(@"Identifies the submitted information.")]
    [DataMember(Name="SubmissnId")]
    [XmlElement(ElementName="SubmissnId")]
    [Required]
    public required MessageIdentification1 SubmissionIdentification { get; init; }
    
    /// <summary>
    /// Reference to the transaction for the requesting financial institution.
    /// </summary>
    [IsoId("_p4TesdE8Ed-BzquC8wXy7w_-1224818208")]
    [Description(@"Reference to the transaction for the requesting financial institution.")]
    [DataMember(Name="SubmitrTxRef")]
    [XmlElement(ElementName="SubmitrTxRef")]
    [Required]
    public required SimpleIdentificationInformation SubmitterTransactionReference { get; init; }
    
    /// <summary>
    /// Specifies the instruction requested by the submitter by means of a code.
    /// </summary>
    [IsoId("_p4TestE8Ed-BzquC8wXy7w_-1224818250")]
    [Description(@"Specifies the instruction requested by the submitter by means of a code.")]
    [DataMember(Name="Instr")]
    [XmlElement(ElementName="Instr")]
    [Required]
    public required InstructionType1 Instruction { get; init; }
    
    /// <summary>
    /// Specifies the commercial details of the underlying transaction.
    /// </summary>
    [IsoId("_p4Tes9E8Ed-BzquC8wXy7w_-1224817338")]
    [Description(@"Specifies the commercial details of the underlying transaction.")]
    [DataMember(Name="Baseln")]
    [XmlElement(ElementName="Baseln")]
    [Required]
    public required Baseline3 Baseline { get; init; }
    
    /// <summary>
    /// Person to be contacted in the organisation of the buyer.
    /// </summary>
    [IsoId("_p4TetNE8Ed-BzquC8wXy7w_-1224817819")]
    [Description(@"Person to be contacted in the organisation of the buyer.")]
    [DataMember(Name="BuyrCtctPrsn")]
    [XmlElement(ElementName="BuyrCtctPrsn")]
    public ContactIdentification1? BuyerContactPerson { get; init; }
    
    /// <summary>
    /// Person to be contacted in the organisation of the seller.
    /// </summary>
    [IsoId("_p4TetdE8Ed-BzquC8wXy7w_-1224817896")]
    [Description(@"Person to be contacted in the organisation of the seller.")]
    [DataMember(Name="SellrCtctPrsn")]
    [XmlElement(ElementName="SellrCtctPrsn")]
    public ContactIdentification1? SellerContactPerson { get; init; }
    
    /// <summary>
    /// Person to be contacted in the buyer's bank.
    /// </summary>
    [IsoId("_p4TettE8Ed-BzquC8wXy7w_-1224817416")]
    [Description(@"Person to be contacted in the buyer's bank.")]
    [DataMember(Name="BuyrBkCtctPrsn")]
    [XmlElement(ElementName="BuyrBkCtctPrsn")]
    [Required]
    public required ContactIdentification1 BuyerBankContactPerson { get; init; }
    
    /// <summary>
    /// Person to be contacted in the seller's bank.
    /// </summary>
    [IsoId("_p4Tet9E8Ed-BzquC8wXy7w_-1224817493")]
    [Description(@"Person to be contacted in the seller's bank.")]
    [DataMember(Name="SellrBkCtctPrsn")]
    [XmlElement(ElementName="SellrBkCtctPrsn")]
    [Required]
    public required ContactIdentification1 SellerBankContactPerson { get; init; }
    
    /// <summary>
    /// Person to be contacted in another bank than seller or buyer's bank.
    /// </summary>
    [IsoId("_p4dPsNE8Ed-BzquC8wXy7w_1151862285")]
    [Description(@"Person to be contacted in another bank than seller or buyer's bank.")]
    [DataMember(Name="OthrBkCtctPrsn")]
    [XmlElement(ElementName="OthrBkCtctPrsn")]
    public ContactIdentification3? OtherBankContactPerson { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="InitialBaselineSubmissionV03Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public InitialBaselineSubmissionV03Document ToDocument()
    {
        return new InitialBaselineSubmissionV03Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="InitialBaselineSubmissionV03"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record InitialBaselineSubmissionV03Document : IOuterDocument<InitialBaselineSubmissionV03>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.019.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="InitialBaselineSubmissionV03"/> is required.
    /// </summary>
    public required InitialBaselineSubmissionV03 Message { get; init; }
}
