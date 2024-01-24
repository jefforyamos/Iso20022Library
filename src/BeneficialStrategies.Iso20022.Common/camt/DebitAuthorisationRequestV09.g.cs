﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for DebitAuthorisationRequestV09.  ISO2002 ID# _IBiyldcBEeq_l4BJLVUF2Q.
//
namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// Scope
/// The DebitAuthorisationRequest message is sent by an account servicing institution to an account owner. This message is used to request authorisation to debit an account.
/// Usage
/// The DebitAuthorisationRequest message must be answered with a DebitAuthorisationResponse message.
/// The DebitAuthorisationRequest message can be used to request debit authorisation in a:
/// - request to modify payment case (in the case of a lower final amount or change of creditor);
/// - request to cancel payment case (full amount);
/// - unable to apply case (the creditor whose account has been credited is not the intended beneficiary);
/// - claim non receipt case (the creditor whose account has been credited is not the intended beneficiary).
/// The DebitAuthorisationRequest message covers one and only one payment instruction at a time. If an account servicing institution needs to request debit authorisation for several instructions, then multiple DebitAuthorisationRequest messages must be sent.
/// The DebitAuthorisationRequest must be used exclusively between the account servicing institution and the account owner. It must not be used in place of a RequestToModifyPayment or CustomerPaymentCancellationRequest or FIToFIPaymentCancellationRequest message between subsequent agents.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The DebitAuthorisationRequest message is sent by an account servicing institution to an account owner. This message is used to request authorisation to debit an account.|Usage|The DebitAuthorisationRequest message must be answered with a DebitAuthorisationResponse message.|The DebitAuthorisationRequest message can be used to request debit authorisation in a:|- request to modify payment case (in the case of a lower final amount or change of creditor);|- request to cancel payment case (full amount);|- unable to apply case (the creditor whose account has been credited is not the intended beneficiary);|- claim non receipt case (the creditor whose account has been credited is not the intended beneficiary).|The DebitAuthorisationRequest message covers one and only one payment instruction at a time. If an account servicing institution needs to request debit authorisation for several instructions, then multiple DebitAuthorisationRequest messages must be sent.|The DebitAuthorisationRequest must be used exclusively between the account servicing institution and the account owner. It must not be used in place of a RequestToModifyPayment or CustomerPaymentCancellationRequest or FIToFIPaymentCancellationRequest message between subsequent agents.")]
public partial record DebitAuthorisationRequestV09 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DbtAuthstnReq";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Identifies the assignment of an investigation case from an assigner to an assignee.
    /// Usage: The assigner must be the sender of this confirmation and the assignee must be the receiver.
    /// </summary>
    [IsoId("_IBiyndcBEeq_l4BJLVUF2Q")]
    [Description(@"Identifies the assignment of an investigation case from an assigner to an assignee.|Usage: The assigner must be the sender of this confirmation and the assignee must be the receiver.")]
    [DataMember(Name="Assgnmt")]
    [XmlElement(ElementName="Assgnmt")]
    [Required]
    public required SomeAssignmentRecord Assignment { get; init; }
    
    /// <summary>
    /// Identifies the investigation case.
    /// </summary>
    [IsoId("_IBiyn9cBEeq_l4BJLVUF2Q")]
    [Description(@"Identifies the investigation case.")]
    [DataMember(Name="Case")]
    [XmlElement(ElementName="Case")]
    public SomeCaseRecord? Case { get; init; }
    
    /// <summary>
    /// Identifies the underlying payment instruction.
    /// </summary>
    [IsoId("_IBiyodcBEeq_l4BJLVUF2Q")]
    [Description(@"Identifies the underlying payment instruction.")]
    [DataMember(Name="Undrlyg")]
    [XmlElement(ElementName="Undrlyg")]
    [Required]
    public required SomeUnderlyingRecord Underlying { get; init; }
    
    /// <summary>
    /// Detailed information about the request.
    /// </summary>
    [IsoId("_IBiyo9cBEeq_l4BJLVUF2Q")]
    [Description(@"Detailed information about the request.")]
    [DataMember(Name="Dtl")]
    [XmlElement(ElementName="Dtl")]
    [Required]
    public required SomeDetailRecord Detail { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_IBiypdcBEeq_l4BJLVUF2Q")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SomeSupplementaryDataRecord? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="DebitAuthorisationRequestV09Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public DebitAuthorisationRequestV09Document ToDocument()
    {
        return new DebitAuthorisationRequestV09Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="DebitAuthorisationRequestV09"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record DebitAuthorisationRequestV09Document : IOuterDocument<DebitAuthorisationRequestV09>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.037.001.09";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="DebitAuthorisationRequestV09"/> is required.
    /// </summary>
    public required DebitAuthorisationRequestV09 Message { get; init; }
}
