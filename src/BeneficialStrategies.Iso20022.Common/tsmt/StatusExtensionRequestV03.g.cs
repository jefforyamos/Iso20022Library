﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for StatusExtensionRequestV03.  ISO2002 ID# _0MRo6NE8Ed-BzquC8wXy7w_2103710287.
//
namespace BeneficialStrategies.Iso20022.tsmt;

/// <summary>
/// Scope
/// The StatusExtensionRequest message is sent by either party involved in a transaction to the matching application.
/// This message is used to request the extension of the status of a transaction.
/// Usage
/// The StatusExtensionRequest message can be sent by either party involved in a transaction to the matching application to request the extension of the status of a transaction.
/// The matching application will pass on the request by sending a StatusExtensionRequestNotification message to the counterparty which can accept or reject the status extension request by sending a StatusExtensionAcceptance or StatusExtensionRejection message.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The StatusExtensionRequest message is sent by either party involved in a transaction to the matching application.|This message is used to request the extension of the status of a transaction.|Usage|The StatusExtensionRequest message can be sent by either party involved in a transaction to the matching application to request the extension of the status of a transaction.|The matching application will pass on the request by sending a StatusExtensionRequestNotification message to the counterparty which can accept or reject the status extension request by sending a StatusExtensionAcceptance or StatusExtensionRejection message.")]
public partial record StatusExtensionRequestV03 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "StsXtnsnReq";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Identifies the request message.
    /// </summary>
    [IsoId("_0MRo6dE8Ed-BzquC8wXy7w_2103710297")]
    [Description(@"Identifies the request message.")]
    [DataMember(Name="ReqId")]
    [XmlElement(ElementName="ReqId")]
    [Required]
    public required SomeRequestIdentificationRecord RequestIdentification { get; init; }
    
    /// <summary>
    /// Unique identification assigned by the matching application to the transaction.|This identification is to be used in any communication between the parties.|.
    /// </summary>
    [IsoId("_0MRo6tE8Ed-BzquC8wXy7w_2103710318")]
    [Description(@"Unique identification assigned by the matching application to the transaction.|This identification is to be used in any communication between the parties.|.")]
    [DataMember(Name="TxId")]
    [XmlElement(ElementName="TxId")]
    [Required]
    public required SomeTransactionIdentificationRecord TransactionIdentification { get; init; }
    
    /// <summary>
    /// Reference to the transaction for the requesting financial institution.
    /// </summary>
    [IsoId("_0MRo69E8Ed-BzquC8wXy7w_2103710380")]
    [Description(@"Reference to the transaction for the requesting financial institution.")]
    [DataMember(Name="SubmitrTxRef")]
    [XmlElement(ElementName="SubmitrTxRef")]
    public SomeSubmitterTransactionReferenceRecord? SubmitterTransactionReference { get; init; }
    
    /// <summary>
    /// Identifies the status of the transaction by means of a code.
    /// </summary>
    [IsoId("_0MRo7NE8Ed-BzquC8wXy7w_2103710350")]
    [Description(@"Identifies the status of the transaction by means of a code.")]
    [DataMember(Name="StsToBeXtnded")]
    [XmlElement(ElementName="StsToBeXtnded")]
    [Required]
    public required SomeStatusToBeExtendedRecord StatusToBeExtended { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="StatusExtensionRequestV03Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public StatusExtensionRequestV03Document ToDocument()
    {
        return new StatusExtensionRequestV03Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="StatusExtensionRequestV03"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record StatusExtensionRequestV03Document : IOuterDocument<StatusExtensionRequestV03>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.035.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="StatusExtensionRequestV03"/> is required.
    /// </summary>
    public required StatusExtensionRequestV03 Message { get; init; }
}