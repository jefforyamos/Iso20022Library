﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for DebitAuthorisationResponseV04.  ISO2002 ID# _nNCymaqDEeeMmtkfa8-zPg.
//
namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// Scope
/// The Debit Authorisation Response message is sent by an account owner to its account servicing institution. This message is used to approve or reject a debit authorisation request.
/// Usage
/// The Debit Authorisation Response message is used to reply to a Debit Authorisation Request message.
/// The Debit Authorisation Response message covers one and only one payment instruction at a time. If an account owner needs to reply to several Debit Authorisation Request messages, then multiple Debit Authorisation Response messages must be sent.
/// The Debit Authorisation Response message indicates whether the account owner agrees with the request by means of a code. It also allows further details to be given about the debit authorisation, such as acceptable amount and value date for the debit.
/// The Debit Authorisation Response message must be used exclusively between the account owner and the account servicing institution. It must not be used in place of a Resolution Of Investigation message between subsequent agents.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The Debit Authorisation Response message is sent by an account owner to its account servicing institution. This message is used to approve or reject a debit authorisation request.|Usage|The Debit Authorisation Response message is used to reply to a Debit Authorisation Request message.|The Debit Authorisation Response message covers one and only one payment instruction at a time. If an account owner needs to reply to several Debit Authorisation Request messages, then multiple Debit Authorisation Response messages must be sent.|The Debit Authorisation Response message indicates whether the account owner agrees with the request by means of a code. It also allows further details to be given about the debit authorisation, such as acceptable amount and value date for the debit.|The Debit Authorisation Response message must be used exclusively between the account owner and the account servicing institution. It must not be used in place of a Resolution Of Investigation message between subsequent agents.")]
public partial record DebitAuthorisationResponseV04 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DbtAuthstnRspn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Identifies the assignment of an investigation case from an assigner to an assignee.|Usage: The Assigner must be the sender of this confirmation and the Assignee must be the receiver.
    /// </summary>
    [IsoId("_nNCym6qDEeeMmtkfa8-zPg")]
    [Description(@"Identifies the assignment of an investigation case from an assigner to an assignee.|Usage: The Assigner must be the sender of this confirmation and the Assignee must be the receiver.")]
    [DataMember(Name="Assgnmt")]
    [XmlElement(ElementName="Assgnmt")]
    [Required]
    public required SomeAssignmentRecord Assignment { get; init; }
    
    /// <summary>
    /// Identifies the investigation case.
    /// </summary>
    [IsoId("_nNCynaqDEeeMmtkfa8-zPg")]
    [Description(@"Identifies the investigation case.")]
    [DataMember(Name="Case")]
    [XmlElement(ElementName="Case")]
    public SomeCaseRecord? Case { get; init; }
    
    /// <summary>
    /// Indicates if the debit authorisation is granted or not.
    /// </summary>
    [IsoId("_nNCyn6qDEeeMmtkfa8-zPg")]
    [Description(@"Indicates if the debit authorisation is granted or not.")]
    [DataMember(Name="Conf")]
    [XmlElement(ElementName="Conf")]
    [Required]
    public required SomeConfirmationRecord Confirmation { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_nNCyoaqDEeeMmtkfa8-zPg")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SomeSupplementaryDataRecord? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="DebitAuthorisationResponseV04Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public DebitAuthorisationResponseV04Document ToDocument()
    {
        return new DebitAuthorisationResponseV04Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="DebitAuthorisationResponseV04"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record DebitAuthorisationResponseV04Document : IOuterDocument<DebitAuthorisationResponseV04>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.036.001.04";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="DebitAuthorisationResponseV04"/> is required.
    /// </summary>
    public required DebitAuthorisationResponseV04 Message { get; init; }
}
