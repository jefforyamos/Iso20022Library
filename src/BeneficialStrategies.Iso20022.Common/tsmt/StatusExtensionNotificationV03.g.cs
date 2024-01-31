﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for StatusExtensionNotificationV03.  ISO2002 ID# _x_BHItE8Ed-BzquC8wXy7w_-321664507.
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
/// The StatusExtensionNotification message is sent by the matching application to the parties involved in a request to extend the status of a transaction.
/// This message is used to inform about the acceptance of a request to extend the status of a transaction.
/// Usage
/// The StatusExtensionNotification message can be sent by the matching application
/// - to the submitter of a request to extend the status of a transaction to pass on information about the acceptance of the request that it has obtained through the receipt of an StatusExtensionAcceptance message.
/// - to the accepter of a request to extend the status of a transaction to inform about the actual status of the transaction in response to a StatusExtensionAcceptance message.
/// In order to pass on information about the rejection of a request to extend the status of a transaction the matching application sends a StatusExtensionRejectionNotification message.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The StatusExtensionNotification message is sent by the matching application to the parties involved in a request to extend the status of a transaction.|This message is used to inform about the acceptance of a request to extend the status of a transaction.|Usage|The StatusExtensionNotification message can be sent by the matching application|- to the submitter of a request to extend the status of a transaction to pass on information about the acceptance of the request that it has obtained through the receipt of an StatusExtensionAcceptance message.|- to the accepter of a request to extend the status of a transaction to inform about the actual status of the transaction in response to a StatusExtensionAcceptance message.|In order to pass on information about the rejection of a request to extend the status of a transaction the matching application sends a StatusExtensionRejectionNotification message.")]
public partial record StatusExtensionNotificationV03 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "StsXtnsnNtfctn";
    
    #nullable enable
    /// <summary>
    /// Identifies the notification message.
    /// </summary>
    [IsoId("_x_BHI9E8Ed-BzquC8wXy7w_-321664471")]
    [Description(@"Identifies the notification message.")]
    [DataMember(Name="NtfctnId")]
    [XmlElement(ElementName="NtfctnId")]
    [Required]
    public required MessageIdentification1 NotificationIdentification { get; init; }
    
    /// <summary>
    /// Unique identification assigned by the matching application to the transaction.|This identification is to be used in any communication between the parties.|.
    /// </summary>
    [IsoId("_x_BHJNE8Ed-BzquC8wXy7w_-321663919")]
    [Description(@"Unique identification assigned by the matching application to the transaction.|This identification is to be used in any communication between the parties.|.")]
    [DataMember(Name="TxId")]
    [XmlElement(ElementName="TxId")]
    [Required]
    public required SimpleIdentificationInformation TransactionIdentification { get; init; }
    
    /// <summary>
    /// Unique identification assigned by the matching application to the baseline when it is established.
    /// </summary>
    [IsoId("_x_BHJdE8Ed-BzquC8wXy7w_-321664394")]
    [Description(@"Unique identification assigned by the matching application to the baseline when it is established.")]
    [DataMember(Name="EstblishdBaselnId")]
    [XmlElement(ElementName="EstblishdBaselnId")]
    public DocumentIdentification3? EstablishedBaselineIdentification { get; init; }
    
    /// <summary>
    /// Reference to the transaction for each financial institution which is a party to the transaction.
    /// </summary>
    [IsoId("_x_BHJtE8Ed-BzquC8wXy7w_-321664004")]
    [Description(@"Reference to the transaction for each financial institution which is a party to the transaction.")]
    [DataMember(Name="UsrTxRef")]
    [XmlElement(ElementName="UsrTxRef")]
    public required IReadOnlyCollection<DocumentIdentification5> UserTransactionReference { get; init; } = []; // Min=0, Max=2
    
    /// <summary>
    /// Identifies the status that is being rolled over.
    /// </summary>
    [IsoId("_x_BHJ9E8Ed-BzquC8wXy7w_-321664316")]
    [Description(@"Identifies the status that is being rolled over.")]
    [DataMember(Name="XtndedSts")]
    [XmlElement(ElementName="XtndedSts")]
    [Required]
    public required TransactionStatus5 ExtendedStatus { get; init; }
    
    /// <summary>
    /// Information on the next processing step required.
    /// </summary>
    [IsoId("_x_BHKNE8Ed-BzquC8wXy7w_-321663576")]
    [Description(@"Information on the next processing step required.")]
    [DataMember(Name="ReqForActn")]
    [XmlElement(ElementName="ReqForActn")]
    public PendingActivity2? RequestForAction { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="StatusExtensionNotificationV03Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public StatusExtensionNotificationV03Document ToDocument()
    {
        return new StatusExtensionNotificationV03Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="StatusExtensionNotificationV03"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record StatusExtensionNotificationV03Document : IOuterDocument<StatusExtensionNotificationV03>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.032.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="StatusExtensionNotificationV03"/> is required.
    /// </summary>
    public required StatusExtensionNotificationV03 Message { get; init; }
}
