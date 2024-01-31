﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for IntentToPayNotificationV02.  ISO2002 ID# _YyxioRVaEeOCqpkCrPgk4g.
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
/// The IntentToPayNotification message is sent by a party to the matching application in order to provide details about a future payment.
/// This message contains details about an intention to pay a certain amount, on a certain date, in relation to one or several transactions known to the matching application.
/// Usage
/// The IntentToPayNotification message can be sent by a party to the transaction at any time as long as the transaction is established and not yet closed.
/// The message is unsolicited, that is, it is not sent in response to another message.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The IntentToPayNotification message is sent by a party to the matching application in order to provide details about a future payment.|This message contains details about an intention to pay a certain amount, on a certain date, in relation to one or several transactions known to the matching application.|Usage|The IntentToPayNotification message can be sent by a party to the transaction at any time as long as the transaction is established and not yet closed.|The message is unsolicited, that is, it is not sent in response to another message.")]
public partial record IntentToPayNotificationV02 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "InttToPayNtfctn";
    
    #nullable enable
    /// <summary>
    /// Identifies the notification message.
    /// </summary>
    [IsoId("_YyxioxVaEeOCqpkCrPgk4g")]
    [Description(@"Identifies the notification message.")]
    [DataMember(Name="NtfctnId")]
    [XmlElement(ElementName="NtfctnId")]
    [Required]
    public required MessageIdentification1 NotificationIdentification { get; init; }
    
    /// <summary>
    /// Unique identification assigned by the matching application to the transaction.|This identification is to be used in any communication between the parties.
    /// </summary>
    [IsoId("_YyxipRVaEeOCqpkCrPgk4g")]
    [Description(@"Unique identification assigned by the matching application to the transaction.|This identification is to be used in any communication between the parties.")]
    [DataMember(Name="TxId")]
    [XmlElement(ElementName="TxId")]
    [Required]
    public required SimpleIdentificationInformation TransactionIdentification { get; init; }
    
    /// <summary>
    /// Reference to the transaction for the requesting financial institution.
    /// </summary>
    [IsoId("_YyxipxVaEeOCqpkCrPgk4g")]
    [Description(@"Reference to the transaction for the requesting financial institution.")]
    [DataMember(Name="SubmitrTxRef")]
    [XmlElement(ElementName="SubmitrTxRef")]
    public SimpleIdentificationInformation? SubmitterTransactionReference { get; init; }
    
    /// <summary>
    /// The financial institution of the buyer, uniquely identified by its BIC. |.
    /// </summary>
    [IsoId("_YyxiqRVaEeOCqpkCrPgk4g")]
    [Description(@"The financial institution of the buyer, uniquely identified by its BIC. |.")]
    [DataMember(Name="BuyrBk")]
    [XmlElement(ElementName="BuyrBk")]
    [Required]
    public required BICIdentification1 BuyerBank { get; init; }
    
    /// <summary>
    /// The financial institution of the seller, uniquely identified by its BIC. |.
    /// </summary>
    [IsoId("_YyxiqxVaEeOCqpkCrPgk4g")]
    [Description(@"The financial institution of the seller, uniquely identified by its BIC. |.")]
    [DataMember(Name="SellrBk")]
    [XmlElement(ElementName="SellrBk")]
    [Required]
    public required BICIdentification1 SellerBank { get; init; }
    
    /// <summary>
    /// Provides the details of the intention to pay.
    /// </summary>
    [IsoId("_YyxirRVaEeOCqpkCrPgk4g")]
    [Description(@"Provides the details of the intention to pay.")]
    [DataMember(Name="InttToPay")]
    [XmlElement(ElementName="InttToPay")]
    [Required]
    public required IntentToPay2 IntentToPay { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="IntentToPayNotificationV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public IntentToPayNotificationV02Document ToDocument()
    {
        return new IntentToPayNotificationV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="IntentToPayNotificationV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record IntentToPayNotificationV02Document : IOuterDocument<IntentToPayNotificationV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.044.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="IntentToPayNotificationV02"/> is required.
    /// </summary>
    public required IntentToPayNotificationV02 Message { get; init; }
}
