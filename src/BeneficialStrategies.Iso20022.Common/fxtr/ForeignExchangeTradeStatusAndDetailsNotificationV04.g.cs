﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for ForeignExchangeTradeStatusAndDetailsNotificationV04.  ISO2002 ID# _rIwsQZR5Eeak6e8_Fc5fQg.
//
namespace BeneficialStrategies.Iso20022.fxtr;

/// <summary>
/// Scope|
/// The ForeignExchangeTradeStatusAndDetails message is sent by a central system to the participant to provide notification of the status and details of a foreign exchange trade.|
/// Usage|
/// The notification is sent by a central settlement system to the two trading parties after it has received foreign exchange trade instructions from both.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope||The ForeignExchangeTradeStatusAndDetails message is sent by a central system to the participant to provide notification of the status and details of a foreign exchange trade.||Usage||The notification is sent by a central settlement system to the two trading parties after it has received foreign exchange trade instructions from both.")]
public partial record ForeignExchangeTradeStatusAndDetailsNotificationV04 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FXTradStsAndDtlsNtfctn";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Provides information on the status of a foreign exchange trade in the central system.
    /// </summary>
    [IsoId("_rIwsR5R5Eeak6e8_Fc5fQg")]
    [Description(@"Provides information on the status of a foreign exchange trade in the central system.")]
    [DataMember(Name="StsDtls")]
    [XmlElement(ElementName="StsDtls")]
    [Required]
    public required SomeStatusDetailsRecord StatusDetails { get; init; }
    
    /// <summary>
    /// General information related to the foreign exchange trade.
    /// </summary>
    [IsoId("_rIwsSZR5Eeak6e8_Fc5fQg")]
    [Description(@"General information related to the foreign exchange trade.")]
    [DataMember(Name="TradInf")]
    [XmlElement(ElementName="TradInf")]
    [Required]
    public required SomeTradeInformationRecord TradeInformation { get; init; }
    
    /// <summary>
    /// Party(ies) on the trading side of the foreign exchange trade.
    /// </summary>
    [IsoId("_rIwsS5R5Eeak6e8_Fc5fQg")]
    [Description(@"Party(ies) on the trading side of the foreign exchange trade.")]
    [DataMember(Name="TradgSdId")]
    [XmlElement(ElementName="TradgSdId")]
    [Required]
    public required SomeTradingSideIdentificationRecord TradingSideIdentification { get; init; }
    
    /// <summary>
    /// Party(ies) on the counterparty side of the foreign exchange trade.
    /// </summary>
    [IsoId("_rIwsTZR5Eeak6e8_Fc5fQg")]
    [Description(@"Party(ies) on the counterparty side of the foreign exchange trade.")]
    [DataMember(Name="CtrPtySdId")]
    [XmlElement(ElementName="CtrPtySdId")]
    [Required]
    public required SomeCounterpartySideIdentificationRecord CounterpartySideIdentification { get; init; }
    
    /// <summary>
    /// Amounts of the foreign exchange trade.
    /// </summary>
    [IsoId("_rIwsT5R5Eeak6e8_Fc5fQg")]
    [Description(@"Amounts of the foreign exchange trade.")]
    [DataMember(Name="TradAmts")]
    [XmlElement(ElementName="TradAmts")]
    [Required]
    public required SomeTradeAmountsRecord TradeAmounts { get; init; }
    
    /// <summary>
    /// Exchange rate as agreed by the traders.
    /// </summary>
    [IsoId("_rIwsUZR5Eeak6e8_Fc5fQg")]
    [Description(@"Exchange rate as agreed by the traders.")]
    [DataMember(Name="AgrdRate")]
    [XmlElement(ElementName="AgrdRate")]
    [Required]
    public required SomeAgreedRateRecord AgreedRate { get; init; }
    
    /// <summary>
    /// Provides the opening and fixing information for an NDF trade.
    /// </summary>
    [IsoId("_ncd-oKZqEea16Jw8SEVrDQ")]
    [Description(@"Provides the opening and fixing information for an NDF trade.")]
    [DataMember(Name="NDFConds")]
    [XmlElement(ElementName="NDFConds")]
    public SomeNonDeliverableForwardConditionsRecord? NonDeliverableForwardConditions { get; init; }
    
    /// <summary>
    /// Settlement instructions for the amounts received by the trading side.
    /// </summary>
    [IsoId("_rIwsU5R5Eeak6e8_Fc5fQg")]
    [Description(@"Settlement instructions for the amounts received by the trading side.")]
    [DataMember(Name="TradgSdSttlmInstrs")]
    [XmlElement(ElementName="TradgSdSttlmInstrs")]
    public SomeTradingSideSettlementInstructionsRecord? TradingSideSettlementInstructions { get; init; }
    
    /// <summary>
    /// Settlement instructions for the amounts received by the counterparty.
    /// </summary>
    [IsoId("_rIwsVZR5Eeak6e8_Fc5fQg")]
    [Description(@"Settlement instructions for the amounts received by the counterparty.")]
    [DataMember(Name="CtrPtySdSttlmInstrs")]
    [XmlElement(ElementName="CtrPtySdSttlmInstrs")]
    public SomeCounterpartySideSettlementInstructionsRecord? CounterpartySideSettlementInstructions { get; init; }
    
    /// <summary>
    /// Additional Information about the foreign exchange trade.
    /// </summary>
    [IsoId("_rIwsV5R5Eeak6e8_Fc5fQg")]
    [Description(@"Additional Information about the foreign exchange trade.")]
    [DataMember(Name="GnlInf")]
    [XmlElement(ElementName="GnlInf")]
    public SomeGeneralInformationRecord? GeneralInformation { get; init; }
    
    /// <summary>
    /// Details of the split trade.
    /// </summary>
    [IsoId("_rIwsWZR5Eeak6e8_Fc5fQg")]
    [Description(@"Details of the split trade.")]
    [DataMember(Name="SpltTradInf")]
    [XmlElement(ElementName="SpltTradInf")]
    public SomeSplitTradeInformationRecord? SplitTradeInformation { get; init; }
    
    /// <summary>
    /// Information that is to be provided to trade repositories in the context of the regulatory standards around over-the-counter (OTC) derivatives, central counterparties and trade repositories.
    /// </summary>
    [IsoId("_rIwsW5R5Eeak6e8_Fc5fQg")]
    [Description(@"Information that is to be provided to trade repositories in the context of the regulatory standards around over-the-counter (OTC) derivatives, central counterparties and trade repositories.")]
    [DataMember(Name="RgltryRptg")]
    [XmlElement(ElementName="RgltryRptg")]
    public SomeRegulatoryReportingRecord? RegulatoryReporting { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_rIwsXZR5Eeak6e8_Fc5fQg")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SomeSupplementaryDataRecord? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="ForeignExchangeTradeStatusAndDetailsNotificationV04Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public ForeignExchangeTradeStatusAndDetailsNotificationV04Document ToDocument()
    {
        return new ForeignExchangeTradeStatusAndDetailsNotificationV04Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="ForeignExchangeTradeStatusAndDetailsNotificationV04"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record ForeignExchangeTradeStatusAndDetailsNotificationV04Document : IOuterDocument<ForeignExchangeTradeStatusAndDetailsNotificationV04>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:fxtr.017.001.04";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="ForeignExchangeTradeStatusAndDetailsNotificationV04"/> is required.
    /// </summary>
    public required ForeignExchangeTradeStatusAndDetailsNotificationV04 Message { get; init; }
}
