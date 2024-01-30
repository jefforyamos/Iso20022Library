﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for DTCCCANOMarketDataSD1V03.  ISO2002 ID# _1O5jxTL3EeKU9IrkkToqcw_570195189.
//
namespace BeneficialStrategies.Iso20022.supl;

/// <summary>
/// The DTCCCANOMarketDataSD1 message extends ISO corporate action notification (CANO) market data message (Market Data type) with data elements that are not covered by the standard message, and additionally, with DTC values where issuer/offeror/market corresponding values are mapped to CANO. For example issuer/offeror/market declared cash rate will be mapped to the CANO and DTC announced cash rate will be extended in this message.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The DTCCCANOMarketDataSD1 message extends ISO corporate action notification (CANO) market data message (Market Data type) with data elements that are not covered by the standard message, and additionally, with DTC values where issuer/offeror/market corresponding values are mapped to CANO. For example issuer/offeror/market declared cash rate will be mapped to the CANO and DTC announced cash rate will be extended in this message.")]
public partial record DTCCCANOMarketDataSD1V03 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DTCCCANOMktDataSD1";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Information to be extended as supplementary data to notification general information.
    /// </summary>
    [IsoId("_1PDUwDL3EeKU9IrkkToqcw_698754401")]
    [Description(@"Information to be extended as supplementary data to notification general information.")]
    [DataMember(Name="NtfctnGnlInf")]
    [XmlElement(ElementName="NtfctnGnlInf")]
    public CorporateActionNotificationSD3? NotificationGeneralInformation { get; init; }
    
    /// <summary>
    /// Information to be extended as supplementary data to general information.
    /// </summary>
    [IsoId("_1PDUwTL3EeKU9IrkkToqcw_-1409229371")]
    [Description(@"Information to be extended as supplementary data to general information.")]
    [DataMember(Name="CorpActnGnlInf")]
    [XmlElement(ElementName="CorpActnGnlInf")]
    public CorporateActionNotificationSD5? CorporateActionGeneralInformation { get; init; }
    
    /// <summary>
    /// Information to be extended as supplementary data to underlying security details.
    /// </summary>
    [IsoId("_1PDUwjL3EeKU9IrkkToqcw_8359932")]
    [Description(@"Information to be extended as supplementary data to underlying security details.")]
    [DataMember(Name="UndrlygScty")]
    [XmlElement(ElementName="UndrlygScty")]
    public FinancialInstrumentAttributesSD6? UnderlyingSecurity { get; init; }
    
    /// <summary>
    /// Information to be extended as supplementary data to corporate action details.
    /// </summary>
    [IsoId("_1PDUwzL3EeKU9IrkkToqcw_-959249820")]
    [Description(@"Information to be extended as supplementary data to corporate action details.")]
    [DataMember(Name="CorpActnDtls")]
    [XmlElement(ElementName="CorpActnDtls")]
    public CorporateActionSD1? CorporateActionDetails { get; init; }
    
    /// <summary>
    /// Information to be extended as supplementary data to corporate action date details.
    /// </summary>
    [IsoId("_1PDUxDL3EeKU9IrkkToqcw_458339483")]
    [Description(@"Information to be extended as supplementary data to corporate action date details.")]
    [DataMember(Name="CorpActnDtDtls")]
    [XmlElement(ElementName="CorpActnDtDtls")]
    public CorporateActionDateSD5? CorporateActionDateDetails { get; init; }
    
    /// <summary>
    /// Information to be extended as corporate action price supplementary data.
    /// </summary>
    [IsoId("_1PDUxTL3EeKU9IrkkToqcw_-1649644289")]
    [Description(@"Information to be extended as corporate action price supplementary data.")]
    [DataMember(Name="CorpActnPricDtls")]
    [XmlElement(ElementName="CorpActnPricDtls")]
    public CorporateActionPriceSD3? CorporateActionPriceDetails { get; init; }
    
    /// <summary>
    /// Information to be extended as supplementary data to corporate action period.
    /// </summary>
    [IsoId("_1PDUxjL3EeKU9IrkkToqcw_-232054986")]
    [Description(@"Information to be extended as supplementary data to corporate action period.")]
    [DataMember(Name="CorpActnPrdDtls")]
    [XmlElement(ElementName="CorpActnPrdDtls")]
    public CorporateActionPeriodSD2? CorporateActionPeriodDetails { get; init; }
    
    /// <summary>
    /// Information to be extended as supplementary data to corporate action securities quantity.
    /// </summary>
    [IsoId("_1PDUxzL3EeKU9IrkkToqcw_1954928538")]
    [Description(@"Information to be extended as supplementary data to corporate action securities quantity.")]
    [DataMember(Name="CorpActnSctiesQty")]
    [XmlElement(ElementName="CorpActnSctiesQty")]
    public CorporateActionQuantitySD1? CorporateActionSecuritiesQuantity { get; init; }
    
    /// <summary>
    /// Information to be extended as supplementary data to corporate action rate and amount.
    /// </summary>
    [IsoId("_1PMesDL3EeKU9IrkkToqcw_-2145539622")]
    [Description(@"Information to be extended as supplementary data to corporate action rate and amount.")]
    [DataMember(Name="CorpActnRateAndAmtDtls")]
    [XmlElement(ElementName="CorpActnRateAndAmtDtls")]
    public CorporateActionRateSD5? CorporateActionRateAndAmountDetails { get; init; }
    
    /// <summary>
    /// Information to be extended as supplementary data to option details.
    /// </summary>
    [IsoId("_1PMesTL3EeKU9IrkkToqcw_-727950319")]
    [Description(@"Information to be extended as supplementary data to option details.")]
    [DataMember(Name="OptnDtls")]
    [XmlElement(ElementName="OptnDtls")]
    public CorporateActionOptionSD1? OptionDetails { get; init; }
    
    /// <summary>
    /// Information to be extended as supplementary data to securities movement details.
    /// </summary>
    [IsoId("_1PMesjL3EeKU9IrkkToqcw_-1418344788")]
    [Description(@"Information to be extended as supplementary data to securities movement details.")]
    [DataMember(Name="SctiesMvmntDtls")]
    [XmlElement(ElementName="SctiesMvmntDtls")]
    public SecuritiesOptionSD2? SecuritiesMovementDetails { get; init; }
    
    /// <summary>
    /// Information to be extended as supplementary data to securities movement security details.
    /// </summary>
    [IsoId("_1PMeszL3EeKU9IrkkToqcw_-1577613287")]
    [Description(@"Information to be extended as supplementary data to securities movement security details.")]
    [DataMember(Name="SctiesMvmntSctyDtls")]
    [XmlElement(ElementName="SctiesMvmntSctyDtls")]
    public FinancialInstrumentAttributesSD3? SecuritiesMovementSecurityDetails { get; init; }
    
    /// <summary>
    /// Information to be extended as supplementary data to securities movement rate details.
    /// </summary>
    [IsoId("_1PMetDL3EeKU9IrkkToqcw_609370237")]
    [Description(@"Information to be extended as supplementary data to securities movement rate details.")]
    [DataMember(Name="SctiesMvmntRateDtls")]
    [XmlElement(ElementName="SctiesMvmntRateDtls")]
    public CorporateActionRateSD7? SecuritiesMovementRateDetails { get; init; }
    
    /// <summary>
    /// Information to be extended as supplementary data to securities movement cash in lieu.
    /// </summary>
    [IsoId("_1PMetTL3EeKU9IrkkToqcw_2026959540")]
    [Description(@"Information to be extended as supplementary data to securities movement cash in lieu.")]
    [DataMember(Name="SctiesMvmntCshInLieuDtls")]
    [XmlElement(ElementName="SctiesMvmntCshInLieuDtls")]
    public CorporateActionPriceSD2? SecuritiesMovementCashInLieuDetails { get; init; }
    
    /// <summary>
    /// Information to be extended as supplementary data to securities movement fraction disposition.
    /// </summary>
    [IsoId("_1PWPsDL3EeKU9IrkkToqcw_-81024232")]
    [Description(@"Information to be extended as supplementary data to securities movement fraction disposition.")]
    [DataMember(Name="SctiesMvmntFrctnDspstn")]
    [XmlElement(ElementName="SctiesMvmntFrctnDspstn")]
    public FractionDispositionTypeSD2? SecuritiesMovementFractionDisposition { get; init; }
    
    /// <summary>
    /// Information to be extended as supplementary data to cash movement details.
    /// </summary>
    [IsoId("_1PWPsTL3EeKU9IrkkToqcw_-1983233102")]
    [Description(@"Information to be extended as supplementary data to cash movement details.")]
    [DataMember(Name="CshMvmntDtls")]
    [XmlElement(ElementName="CshMvmntDtls")]
    public CashOptionSD2? CashMovementDetails { get; init; }
    
    /// <summary>
    /// Provides additional information to agent details (to message agent like "issuer agent", "reselling agent", etc). Used when required "ISO agent type" exists and only additional details need to be extended.
    /// </summary>
    [IsoId("_1PWPsjL3EeKU9IrkkToqcw_-565643799")]
    [Description(@"Provides additional information to agent details (to message agent like ""issuer agent"", ""reselling agent"", etc). Used when required ""ISO agent type"" exists and only additional details need to be extended.")]
    [DataMember(Name="Agt")]
    [XmlElement(ElementName="Agt")]
    public PartyIdentificationSD2? Agent { get; init; }
    
    /// <summary>
    /// Information to be extended new agent block. Used when required ISO Agent Type does not exist and entire new component must be generated.
    /// </summary>
    [IsoId("_1PWPszL3EeKU9IrkkToqcw_1621339725")]
    [Description(@"Information to be extended new agent block. Used when required ISO Agent Type does not exist and entire new component must be generated.")]
    [DataMember(Name="NewAgt")]
    [XmlElement(ElementName="NewAgt")]
    public PartyIdentificationSD1? NewAgent { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="DTCCCANOMarketDataSD1V03Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public DTCCCANOMarketDataSD1V03Document ToDocument()
    {
        return new DTCCCANOMarketDataSD1V03Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="DTCCCANOMarketDataSD1V03"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record DTCCCANOMarketDataSD1V03Document : IOuterDocument<DTCCCANOMarketDataSD1V03>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:supl.002.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="DTCCCANOMarketDataSD1V03"/> is required.
    /// </summary>
    public required DTCCCANOMarketDataSD1V03 Message { get; init; }
}
