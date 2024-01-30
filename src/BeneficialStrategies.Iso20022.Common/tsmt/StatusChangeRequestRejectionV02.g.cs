﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for StatusChangeRequestRejectionV02.  ISO2002 ID# _xILlyNE8Ed-BzquC8wXy7w_-544947479.
//
namespace BeneficialStrategies.Iso20022.tsmt;

/// <summary>
/// Scope
/// The StatusChangeRequestRejection message is sent by the party requested to accept or reject the request of a change in the status of a transaction to the matching application.
/// This message is used to inform about the rejection of a request to change the status of a transaction.
/// Usage
/// The StatusChangeRequestRejection message can be sent by the party requested to accept or reject a request to change the status of a transaction to inform that it rejects the request.
/// The message can be sent in response to a StatusChangeRequestNotification message.
/// The acceptance of a request to change the status of a transaction can be achieved by sending a StatusChangeRequestAcceptance message.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The StatusChangeRequestRejection message is sent by the party requested to accept or reject the request of a change in the status of a transaction to the matching application.|This message is used to inform about the rejection of a request to change the status of a transaction.|Usage|The StatusChangeRequestRejection message can be sent by the party requested to accept or reject a request to change the status of a transaction to inform that it rejects the request.|The message can be sent in response to a StatusChangeRequestNotification message.|The acceptance of a request to change the status of a transaction can be achieved by sending a StatusChangeRequestAcceptance message.")]
public partial record StatusChangeRequestRejectionV02 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "StsChngReqRjctn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Identifies the rejection message.
    /// </summary>
    [IsoId("_xIUvsNE8Ed-BzquC8wXy7w_-544947476")]
    [Description(@"Identifies the rejection message.")]
    [DataMember(Name="RjctnId")]
    [XmlElement(ElementName="RjctnId")]
    [Required]
    public required MessageIdentification1 RejectionIdentification { get; init; }
    
    /// <summary>
    /// Unique identification assigned by the matching application to the transaction.|This identification is to be used in any communication between the parties.
    /// </summary>
    [IsoId("_xIUvsdE8Ed-BzquC8wXy7w_-544947355")]
    [Description(@"Unique identification assigned by the matching application to the transaction.|This identification is to be used in any communication between the parties.")]
    [DataMember(Name="TxId")]
    [XmlElement(ElementName="TxId")]
    [Required]
    public required SimpleIdentificationInformation TransactionIdentification { get; init; }
    
    /// <summary>
    /// Reference to the transaction for the requesting financial institution.
    /// </summary>
    [IsoId("_xIUvstE8Ed-BzquC8wXy7w_-544947447")]
    [Description(@"Reference to the transaction for the requesting financial institution.")]
    [DataMember(Name="SubmitrTxRef")]
    [XmlElement(ElementName="SubmitrTxRef")]
    public SimpleIdentificationInformation? SubmitterTransactionReference { get; init; }
    
    /// <summary>
    /// Specifies the status rejected.
    /// </summary>
    [IsoId("_xIUvs9E8Ed-BzquC8wXy7w_-544947416")]
    [Description(@"Specifies the status rejected.")]
    [DataMember(Name="RjctdStsChng")]
    [XmlElement(ElementName="RjctdStsChng")]
    [Required]
    public required TransactionStatus3 RejectedStatusChange { get; init; }
    
    /// <summary>
    /// Reason why the user cannot accept the request.
    /// </summary>
    [IsoId("_xIUvtNE8Ed-BzquC8wXy7w_-544947386")]
    [Description(@"Reason why the user cannot accept the request.")]
    [DataMember(Name="RjctnRsn")]
    [XmlElement(ElementName="RjctnRsn")]
    [Required]
    public required Reason2 RejectionReason { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="StatusChangeRequestRejectionV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public StatusChangeRequestRejectionV02Document ToDocument()
    {
        return new StatusChangeRequestRejectionV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="StatusChangeRequestRejectionV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record StatusChangeRequestRejectionV02Document : IOuterDocument<StatusChangeRequestRejectionV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.029.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="StatusChangeRequestRejectionV02"/> is required.
    /// </summary>
    public required StatusChangeRequestRejectionV02 Message { get; init; }
}
