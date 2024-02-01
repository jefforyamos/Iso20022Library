﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for BuyInNotificationV03.  ISO2002 ID# _1K820S0lEeSRe9rElPHBfg.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.secl;


/// <summary>
/// This record is an implementation of the secl.007.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The BuyInNotification message is sent by the central counterparty (CCP) to a clearing member to notify the start of the buy in process.
/// 
/// The message definition is intended for use with the ISO 20022 Business Application Header.
/// 
/// Usage
/// The buy in process is a process by which the CCP buys in stocks to cover failed transactions; the clearing member is notified that this process has started. Depending on each CCP internal rules, this message can also be sent, as a warning, by the central counterparty to the clearing member some days before the buy in process starts.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The BuyInNotification message is sent by the central counterparty (CCP) to a clearing member to notify the start of the buy in process.||The message definition is intended for use with the ISO 20022 Business Application Header.||Usage|The buy in process is a process by which the CCP buys in stocks to cover failed transactions; the clearing member is notified that this process has started. Depending on each CCP internal rules, this message can also be sent, as a warning, by the central counterparty to the clearing member some days before the buy in process starts.")]
public partial record BuyInNotificationV03 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "secl.007.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "BuyInNtfctn";
    
    #nullable enable
    /// <summary>
    /// Unambiguous identification of the transaction as known by the instructing party.
    /// </summary>
    [IsoId("_1K821S0lEeSRe9rElPHBfg")]
    [Description(@"Unambiguous identification of the transaction as known by the instructing party.")]
    [DataMember(Name="TxId")]
    [XmlElement(ElementName="TxId")]
    public IsoMax35Text? TransactionIdentification { get; init; }
    
    /// <summary>
    /// Provides the identification of the clearing member (individual clearing member or general clearing member).
    /// </summary>
    [IsoId("_1K821y0lEeSRe9rElPHBfg")]
    [Description(@"Provides the identification of the clearing member (individual clearing member or general clearing member).")]
    [DataMember(Name="ClrMmb")]
    [XmlElement(ElementName="ClrMmb")]
    [Required]
    public required PartyIdentification35Choice_ ClearingMember { get; init; }
    
    /// <summary>
    /// Indicates if the message is a notification or a warning and gives the option to specify the buy in date.
    /// </summary>
    [IsoId("_1K822S0lEeSRe9rElPHBfg")]
    [Description(@"Indicates if the message is a notification or a warning and gives the option to specify the buy in date.")]
    [DataMember(Name="NtfctnDtls")]
    [XmlElement(ElementName="NtfctnDtls")]
    public BuyIn4? NotificationDetails { get; init; }
    
    /// <summary>
    /// Provides details about the original settlement obligation that did not settle and for which the buy in process will be launched.
    /// </summary>
    [IsoId("_1K822y0lEeSRe9rElPHBfg")]
    [Description(@"Provides details about the original settlement obligation that did not settle and for which the buy in process will be launched.")]
    [DataMember(Name="OrgnlSttlmOblgtn")]
    [XmlElement(ElementName="OrgnlSttlmOblgtn")]
    [Required]
    public required SettlementObligation7 OriginalSettlementObligation { get; init; }
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_1K823S0lEeSRe9rElPHBfg")]
    [Description(@"Additional information that can not be captured in the structured fields and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="BuyInNotificationV03Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public BuyInNotificationV03Document ToDocument()
    {
        return new BuyInNotificationV03Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="BuyInNotificationV03"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record BuyInNotificationV03Document : IOuterDocument<BuyInNotificationV03>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:secl.007.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="BuyInNotificationV03"/> is required.
    /// </summary>
    public required BuyInNotificationV03 Message { get; init; }
}
