﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for DemandWithdrawalNotificationV01.  ISO2002 ID# _9hWQMnltEeG7BsjMvd1mEw_1943951405.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.tsrv;


/// <summary>
/// This record is an implementation of the tsrv.017.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The DemandWithdrawalNotification message is sent by the beneficiary to the party that issued the undertaking, either directly or via a presenting or nominated party, to inform the issuer or nominated party that it has elected to withdraw its demand under the demand guarantee or standby letter of credit.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The DemandWithdrawalNotification message is sent by the beneficiary to the party that issued the undertaking, either directly or via a presenting or nominated party, to inform the issuer or nominated party that it has elected to withdraw its demand under the demand guarantee or standby letter of credit.")]
public partial record DemandWithdrawalNotificationV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsrv.017.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DmndWdrwlNtfctn";
    
    #nullable enable
    /// <summary>
    /// Details of the demand withdrawal notification.
    /// </summary>
    [IsoId("_9hWQM3ltEeG7BsjMvd1mEw_234628498")]
    [Description(@"Details of the demand withdrawal notification.")]
    [DataMember(Name="DmndWdrwlNtfctnDtls")]
    [XmlElement(ElementName="DmndWdrwlNtfctnDtls")]
    [Required]
    public required UndertakingDemandWithdrawal1 DemandWithdrawalNotificationDetails { get; init; }
    
    /// <summary>
    /// Digital signature of the notification.
    /// </summary>
    [IsoId("_9hWQNHltEeG7BsjMvd1mEw_-1538509071")]
    [Description(@"Digital signature of the notification.")]
    [DataMember(Name="DgtlSgntr")]
    [XmlElement(ElementName="DgtlSgntr")]
    public PartyAndSignature2? DigitalSignature { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="DemandWithdrawalNotificationV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public DemandWithdrawalNotificationV01Document ToDocument()
    {
        return new DemandWithdrawalNotificationV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="DemandWithdrawalNotificationV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record DemandWithdrawalNotificationV01Document : IOuterDocument<DemandWithdrawalNotificationV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsrv.017.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="DemandWithdrawalNotificationV01"/> is required.
    /// </summary>
    public required DemandWithdrawalNotificationV01 Message { get; init; }
}
