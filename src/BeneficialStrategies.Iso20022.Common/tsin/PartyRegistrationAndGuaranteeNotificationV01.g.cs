﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for PartyRegistrationAndGuaranteeNotificationV01.  ISO2002 ID# _OTgzNDg0-AOSNFX-8224506.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.tsin;


/// <summary>
/// This record is an implementation of the tsin.011.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The PartyRegistrationAndGuaranteeNotification message is sent by a factoring client or a financial service to a trade partner and, optionally, to an interested party in order to notify the status of a requested financial service agreement. The trade partner is given information to explain the consequences of a financial service agreement, for instance, the trade partner must pay the financial institution and must use the electronic address to inform it and pay it using the bank account given.
/// The message may reference related messages and may include referenced data.
/// The message can carry digital signatures if required by context.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The PartyRegistrationAndGuaranteeNotification message is sent by a factoring client or a financial service to a trade partner and, optionally, to an interested party in order to notify the status of a requested financial service agreement. The trade partner is given information to explain the consequences of a financial service agreement, for instance, the trade partner must pay the financial institution and must use the electronic address to inform it and pay it using the bank account given.|The message may reference related messages and may include referenced data.|The message can carry digital signatures if required by context.")]
public partial record PartyRegistrationAndGuaranteeNotificationV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsin.011.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "PtyRegnAndGrntNtfctn";
    
    #nullable enable
    /// <summary>
    /// Set of characteristics that unambiguously identify the notification, common parameters, documents and identifications.
    /// </summary>
    [IsoId("_OTgzNDg1-AOSNFX-8224506")]
    [Description(@"Set of characteristics that unambiguously identify the notification, common parameters, documents and identifications.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required BusinessLetter1 Header { get; init; }
    
    /// <summary>
    /// List of otifications.
    /// </summary>
    [IsoId("_OTgzNDg2-AOSNFX-8224506")]
    [Description(@"List of otifications.")]
    [DataMember(Name="NtfctnList")]
    [XmlElement(ElementName="NtfctnList")]
    [Required]
    public required FinancingAgreementList1 NotificationList { get; init; }
    
    /// <summary>
    /// Number of notification lists as control value.
    /// </summary>
    [IsoId("_OTgzNDg3-AOSNFX-8224506")]
    [Description(@"Number of notification lists as control value.")]
    [DataMember(Name="NtfctnCnt")]
    [XmlElement(ElementName="NtfctnCnt")]
    public IsoMax15NumericText? NotificationCount { get; init; }
    
    /// <summary>
    /// Total number of individual items in all lists.
    /// </summary>
    [IsoId("_OTgzNDg4-AOSNFX-8224506")]
    [Description(@"Total number of individual items in all lists.")]
    [DataMember(Name="ItmCnt")]
    [XmlElement(ElementName="ItmCnt")]
    public IsoMax15NumericText? ItemCount { get; init; }
    
    /// <summary>
    /// Total of all individual amounts included in all lists, irrespective of currencies or direction.
    /// </summary>
    [IsoId("_OTgzNDg5-AOSNFX-8224506")]
    [Description(@"Total of all individual amounts included in all lists, irrespective of currencies or direction.")]
    [DataMember(Name="CtrlSum")]
    [XmlElement(ElementName="CtrlSum")]
    public IsoDecimalNumber? ControlSum { get; init; }
    
    /// <summary>
    /// Referenced or related business message.
    /// </summary>
    [IsoId("_OTgzNDkw-AOSNFX-8224506")]
    [Description(@"Referenced or related business message.")]
    [DataMember(Name="AttchdMsg")]
    [XmlElement(ElementName="AttchdMsg")]
    public EncapsulatedBusinessMessage1? AttachedMessage { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="PartyRegistrationAndGuaranteeNotificationV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public PartyRegistrationAndGuaranteeNotificationV01Document ToDocument()
    {
        return new PartyRegistrationAndGuaranteeNotificationV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="PartyRegistrationAndGuaranteeNotificationV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record PartyRegistrationAndGuaranteeNotificationV01Document : IOuterDocument<PartyRegistrationAndGuaranteeNotificationV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsin.011.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="PartyRegistrationAndGuaranteeNotificationV01"/> is required.
    /// </summary>
    public required PartyRegistrationAndGuaranteeNotificationV01 Message { get; init; }
}
