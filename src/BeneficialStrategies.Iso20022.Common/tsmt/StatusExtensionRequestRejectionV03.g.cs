﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for StatusExtensionRequestRejectionV03.  ISO2002 ID# _zwHRWNE8Ed-BzquC8wXy7w_1399062507.
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
/// The StatusExtensionRequestRejection message is sent by the party requested to accept or reject a request to extend the status of a transaction to the matching application.
/// This message is used to inform about the rejection of a request to extend the status of a transaction.
/// Usage
/// The StatusExtensionRequestRejection message can be sent by the party requested to accept or reject the request to extend the status of a transaction to inform that it rejects the request.
/// The message can be sent in response to a StatusExtensionRequestNotification message.
/// The acceptance of a request to extend the status of a transaction can be achieved by sending a StatusExtensionRequestAcceptance message.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The StatusExtensionRequestRejection message is sent by the party requested to accept or reject a request to extend the status of a transaction to the matching application.|This message is used to inform about the rejection of a request to extend the status of a transaction.|Usage|The StatusExtensionRequestRejection message can be sent by the party requested to accept or reject the request to extend the status of a transaction to inform that it rejects the request.|The message can be sent in response to a StatusExtensionRequestNotification message.|The acceptance of a request to extend the status of a transaction can be achieved by sending a StatusExtensionRequestAcceptance message.")]
public partial record StatusExtensionRequestRejectionV03 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "StsXtnsnReqRjctn";
    
    #nullable enable
    /// <summary>
    /// Identifies the rejection message.
    /// </summary>
    [IsoId("_zwHRWdE8Ed-BzquC8wXy7w_1399062518")]
    [Description(@"Identifies the rejection message.")]
    [DataMember(Name="RjctnId")]
    [XmlElement(ElementName="RjctnId")]
    [Required]
    public required MessageIdentification1 RejectionIdentification { get; init; }
    
    /// <summary>
    /// Unique identification assigned by the matching application to the transaction.|This identification is to be used in any communication between the parties.|.
    /// </summary>
    [IsoId("_zwHRWtE8Ed-BzquC8wXy7w_1399062539")]
    [Description(@"Unique identification assigned by the matching application to the transaction.|This identification is to be used in any communication between the parties.|.")]
    [DataMember(Name="TxId")]
    [XmlElement(ElementName="TxId")]
    [Required]
    public required SimpleIdentificationInformation TransactionIdentification { get; init; }
    
    /// <summary>
    /// Reference to the transaction for the requesting financial institution.
    /// </summary>
    [IsoId("_zwHRW9E8Ed-BzquC8wXy7w_1399062847")]
    [Description(@"Reference to the transaction for the requesting financial institution.")]
    [DataMember(Name="SubmitrTxRef")]
    [XmlElement(ElementName="SubmitrTxRef")]
    public SimpleIdentificationInformation? SubmitterTransactionReference { get; init; }
    
    /// <summary>
    /// Identifies the status that the submitter does not want to be extended.
    /// </summary>
    [IsoId("_zwHRXNE8Ed-BzquC8wXy7w_1399062786")]
    [Description(@"Identifies the status that the submitter does not want to be extended.")]
    [DataMember(Name="StsNotToBeXtnded")]
    [XmlElement(ElementName="StsNotToBeXtnded")]
    [Required]
    public required TransactionStatus4 StatusNotToBeExtended { get; init; }
    
    /// <summary>
    /// Reason why the user cannot accept the request.
    /// </summary>
    [IsoId("_zwHRXdE8Ed-BzquC8wXy7w_1399062817")]
    [Description(@"Reason why the user cannot accept the request.")]
    [DataMember(Name="RjctnRsn")]
    [XmlElement(ElementName="RjctnRsn")]
    [Required]
    public required Reason2 RejectionReason { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="StatusExtensionRequestRejectionV03Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public StatusExtensionRequestRejectionV03Document ToDocument()
    {
        return new StatusExtensionRequestRejectionV03Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="StatusExtensionRequestRejectionV03"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record StatusExtensionRequestRejectionV03Document : IOuterDocument<StatusExtensionRequestRejectionV03>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.033.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="StatusExtensionRequestRejectionV03"/> is required.
    /// </summary>
    public required StatusExtensionRequestRejectionV03 Message { get; init; }
}
