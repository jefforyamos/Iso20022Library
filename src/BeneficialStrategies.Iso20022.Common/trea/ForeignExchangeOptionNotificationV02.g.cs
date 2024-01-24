﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for ForeignExchangeOptionNotificationV02.  ISO2002 ID# _QCIK6NE8Ed-BzquC8wXy7w_-2045814163.
//
namespace BeneficialStrategies.Iso20022.trea;

/// <summary>
/// Scope
/// The ForeignExchangeOptionNotification message is sent by a central system to a participant to provide details of a foreign exchange option trade.
/// Usage
/// The notification is sent by the central settlement system to the two trading parties after it has received Create, Amend or Cancel messages from both. The message may also contain information on the settlement of the trade and/or premium.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The ForeignExchangeOptionNotification message is sent by a central system to a participant to provide details of a foreign exchange option trade.|Usage|The notification is sent by the central settlement system to the two trading parties after it has received Create, Amend or Cancel messages from both. The message may also contain information on the settlement of the trade and/or premium.")]
public partial record ForeignExchangeOptionNotificationV02 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FXOptnNtfctnV02";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Specifies the trading side of the currency option trade which is reported.
    /// </summary>
    [IsoId("_QCIK6dE8Ed-BzquC8wXy7w_-28711885")]
    [Description(@"Specifies the trading side of the currency option trade which is reported.")]
    [DataMember(Name="TradgSdId")]
    [XmlElement(ElementName="TradgSdId")]
    [Required]
    public required SomeTradingSideIdentificationRecord TradingSideIdentification { get; init; }
    
    /// <summary>
    /// Specifies the counterparty of the non deliverable trade which is reported.
    /// </summary>
    [IsoId("_QCIK6tE8Ed-BzquC8wXy7w_-1363683318")]
    [Description(@"Specifies the counterparty of the non deliverable trade which is reported.")]
    [DataMember(Name="CtrPtySdId")]
    [XmlElement(ElementName="CtrPtySdId")]
    [Required]
    public required SomeCounterpartySideIdentificationRecord CounterpartySideIdentification { get; init; }
    
    /// <summary>
    /// Provides information on the conditions of the option.
    /// </summary>
    [IsoId("_QCIK69E8Ed-BzquC8wXy7w_1138794159")]
    [Description(@"Provides information on the conditions of the option.")]
    [DataMember(Name="OptnData")]
    [XmlElement(ElementName="OptnData")]
    [Required]
    public required SomeOptionDataRecord OptionData { get; init; }
    
    /// <summary>
    /// Provides information on the status of a trade in a settlement system.
    /// </summary>
    [IsoId("_QCR74NE8Ed-BzquC8wXy7w_1207820711")]
    [Description(@"Provides information on the status of a trade in a settlement system.")]
    [DataMember(Name="TradSts")]
    [XmlElement(ElementName="TradSts")]
    [Required]
    public required SomeTradeStatusRecord TradeStatus { get; init; }
    
    /// <summary>
    /// Provides information on the settlement of a trade.
    /// </summary>
    [IsoId("_QCR74dE8Ed-BzquC8wXy7w_949234653")]
    [Description(@"Provides information on the settlement of a trade.")]
    [DataMember(Name="SttlmData")]
    [XmlElement(ElementName="SttlmData")]
    public SomeSettlementDataRecord? SettlementData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="ForeignExchangeOptionNotificationV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public ForeignExchangeOptionNotificationV02Document ToDocument()
    {
        return new ForeignExchangeOptionNotificationV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="ForeignExchangeOptionNotificationV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record ForeignExchangeOptionNotificationV02Document : IOuterDocument<ForeignExchangeOptionNotificationV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:trea.012.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="ForeignExchangeOptionNotificationV02"/> is required.
    /// </summary>
    public required ForeignExchangeOptionNotificationV02 Message { get; init; }
}
