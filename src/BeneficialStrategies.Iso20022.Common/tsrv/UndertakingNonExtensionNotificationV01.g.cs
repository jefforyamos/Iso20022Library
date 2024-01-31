﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for UndertakingNonExtensionNotificationV01.  ISO2002 ID# _9i_O8nltEeG7BsjMvd1mEw_-188871383.
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
/// The UndertakingNonExtensionNotification message is sent by the party that issued the undertaking to the beneficiary, either directly or via one or more advising parties, to notify it of the non-extension of the referenced undertaking beyond the current expiry date.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The UndertakingNonExtensionNotification message is sent by the party that issued the undertaking to the beneficiary, either directly or via one or more advising parties, to notify it of the non-extension of the referenced undertaking beyond the current expiry date.")]
public partial record UndertakingNonExtensionNotificationV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "UdrtkgNonXtnsnNtfctn";
    
    #nullable enable
    /// <summary>
    /// Details of the non-extension notification.
    /// </summary>
    [IsoId("_9i_O83ltEeG7BsjMvd1mEw_1181398282")]
    [Description(@"Details of the non-extension notification.")]
    [DataMember(Name="UdrtkgNonXtnsnNtfctnDtls")]
    [XmlElement(ElementName="UdrtkgNonXtnsnNtfctnDtls")]
    [Required]
    public required UndertakingNonExtensionStatusAdvice1 UndertakingNonExtensionNotificationDetails { get; init; }
    
    /// <summary>
    /// Digital signature of the notification.
    /// </summary>
    [IsoId("_9i_O9HltEeG7BsjMvd1mEw_-676227762")]
    [Description(@"Digital signature of the notification.")]
    [DataMember(Name="DgtlSgntr")]
    [XmlElement(ElementName="DgtlSgntr")]
    public PartyAndSignature2? DigitalSignature { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="UndertakingNonExtensionNotificationV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public UndertakingNonExtensionNotificationV01Document ToDocument()
    {
        return new UndertakingNonExtensionNotificationV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="UndertakingNonExtensionNotificationV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record UndertakingNonExtensionNotificationV01Document : IOuterDocument<UndertakingNonExtensionNotificationV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsrv.011.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="UndertakingNonExtensionNotificationV01"/> is required.
    /// </summary>
    public required UndertakingNonExtensionNotificationV01 Message { get; init; }
}
