﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for ForeignExchangeTradeInstructionCancellationV03.  ISO2002 ID# _zV7xsTJ5EeOd1OidA-8_VQ.
//
namespace BeneficialStrategies.Iso20022.fxtr;

/// <summary>
/// Scope|
/// The ForeignExchangeTradeInstructionCancellation message is sent by a participant to a central settlement system to notify the cancellation of the foreign exchange trade previously confirmed by the sender.|
/// Usage|
/// The ForeignExchangeTradeInstructionCancellation message is sent from a participant to a central settlement system to advise of the cancellation of a previously sent notification. The "Related Reference" must be used to link it to the previous notification.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope||The ForeignExchangeTradeInstructionCancellation message is sent by a participant to a central settlement system to notify the cancellation of the foreign exchange trade previously confirmed by the sender.||Usage||The ForeignExchangeTradeInstructionCancellation message is sent from a participant to a central settlement system to advise of the cancellation of a previously sent notification. The ""Related Reference"" must be used to link it to the previous notification.")]
public partial record ForeignExchangeTradeInstructionCancellationV03 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FXTradInstrCxl";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// General information related to the trade.
    /// </summary>
    [IsoId("_zV7xszJ5EeOd1OidA-8_VQ")]
    [Description(@"General information related to the trade.")]
    [DataMember(Name="TradInf")]
    [XmlElement(ElementName="TradInf")]
    [Required]
    public required TradeAgreement11 TradeInformation { get; init; }
    
    /// <summary>
    /// Party(ies) on the trading side of the trade.
    /// </summary>
    [IsoId("_zV7xtTJ5EeOd1OidA-8_VQ")]
    [Description(@"Party(ies) on the trading side of the trade.")]
    [DataMember(Name="TradgSdId")]
    [XmlElement(ElementName="TradgSdId")]
    [Required]
    public required TradePartyIdentification6 TradingSideIdentification { get; init; }
    
    /// <summary>
    /// Party(ies) on the counterparty side of the trade.
    /// </summary>
    [IsoId("_zV7xtzJ5EeOd1OidA-8_VQ")]
    [Description(@"Party(ies) on the counterparty side of the trade.")]
    [DataMember(Name="CtrPtySdId")]
    [XmlElement(ElementName="CtrPtySdId")]
    [Required]
    public required TradePartyIdentification6 CounterpartySideIdentification { get; init; }
    
    /// <summary>
    /// Exchange rate as agreed by the traders.
    /// </summary>
    [IsoId("_zV7xuTJ5EeOd1OidA-8_VQ")]
    [Description(@"Exchange rate as agreed by the traders.")]
    [DataMember(Name="AgrdRate")]
    [XmlElement(ElementName="AgrdRate")]
    public AgreedRate1? AgreedRate { get; init; }
    
    /// <summary>
    /// Settlement instructions for the amounts received by the trading side.
    /// </summary>
    [IsoId("_zV7xuzJ5EeOd1OidA-8_VQ")]
    [Description(@"Settlement instructions for the amounts received by the trading side.")]
    [DataMember(Name="TradgSdSttlmInstrs")]
    [XmlElement(ElementName="TradgSdSttlmInstrs")]
    public SettlementParties29? TradingSideSettlementInstructions { get; init; }
    
    /// <summary>
    /// Settlement instructions for the amounts received by the counterparty.
    /// </summary>
    [IsoId("_zV7xvTJ5EeOd1OidA-8_VQ")]
    [Description(@"Settlement instructions for the amounts received by the counterparty.")]
    [DataMember(Name="CtrPtySdSttlmInstrs")]
    [XmlElement(ElementName="CtrPtySdSttlmInstrs")]
    public SettlementParties29? CounterpartySideSettlementInstructions { get; init; }
    
    /// <summary>
    /// Specifies whether the trade is a block or an individual trade. It also contains supplementary information such as free format information, broker's identification, dealing branches and references.
    /// </summary>
    [IsoId("_zV7xvzJ5EeOd1OidA-8_VQ")]
    [Description(@"Specifies whether the trade is a block or an individual trade. It also contains supplementary information such as free format information, broker's identification, dealing branches and references.")]
    [DataMember(Name="OptnlGnlInf")]
    [XmlElement(ElementName="OptnlGnlInf")]
    public GeneralInformation4? OptionalGeneralInformation { get; init; }
    
    /// <summary>
    /// Amounts of the trade.
    /// </summary>
    [IsoId("_zV7xwTJ5EeOd1OidA-8_VQ")]
    [Description(@"Amounts of the trade.")]
    [DataMember(Name="TradAmts")]
    [XmlElement(ElementName="TradAmts")]
    [Required]
    public required AmountsAndValueDate1 TradeAmounts { get; init; }
    
    /// <summary>
    /// Information that is to be provided to trade repositories in the context of the regulatory standards around over-the-counter (OTC) derivatives, central counterparties and trade repositories.
    /// </summary>
    [IsoId("_zV7xwzJ5EeOd1OidA-8_VQ")]
    [Description(@"Information that is to be provided to trade repositories in the context of the regulatory standards around over-the-counter (OTC) derivatives, central counterparties and trade repositories.")]
    [DataMember(Name="RgltryRptg")]
    [XmlElement(ElementName="RgltryRptg")]
    public RegulatoryReporting4? RegulatoryReporting { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_zV7xxTJ5EeOd1OidA-8_VQ")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="ForeignExchangeTradeInstructionCancellationV03Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public ForeignExchangeTradeInstructionCancellationV03Document ToDocument()
    {
        return new ForeignExchangeTradeInstructionCancellationV03Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="ForeignExchangeTradeInstructionCancellationV03"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record ForeignExchangeTradeInstructionCancellationV03Document : IOuterDocument<ForeignExchangeTradeInstructionCancellationV03>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:fxtr.016.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="ForeignExchangeTradeInstructionCancellationV03"/> is required.
    /// </summary>
    public required ForeignExchangeTradeInstructionCancellationV03 Message { get; init; }
}
