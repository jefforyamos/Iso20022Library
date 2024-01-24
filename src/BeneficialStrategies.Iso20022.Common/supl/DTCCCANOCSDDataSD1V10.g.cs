﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for DTCCCANOCSDDataSD1V10.  ISO2002 ID# _LAGx8b5MEeexmbB7KsjCwA.
//
namespace BeneficialStrategies.Iso20022.supl;

/// <summary>
/// The DTCCCANOCSDDataSD1 message extends ISO corporate action notification (CANO) asset servicer data message (CSD type) with data elements that are not covered by the standard message, and additionally, with issuer/offeror/market values where DTC corresponding values are mapped to CANO. For example DTCC announced cash rate will be mapped to the CANO and issuer/offeror/ market declared cash rate will be extended in this message.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The DTCCCANOCSDDataSD1 message extends ISO corporate action notification (CANO) asset servicer data message (CSD type) with data elements that are not covered by the standard message, and additionally, with issuer/offeror/market values where DTC corresponding values are mapped to CANO. For example DTCC announced cash rate will be mapped to the CANO and issuer/offeror/ market declared cash rate will be extended in this message.")]
public partial record DTCCCANOCSDDataSD1V10 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DTCCCANOCSDDataSD1";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Information to be extended as supplementary data to notification general information.
    /// </summary>
    [IsoId("_LAGx875MEeexmbB7KsjCwA")]
    [Description(@"Information to be extended as supplementary data to notification general information.")]
    [DataMember(Name="NtfctnGnlInf")]
    [XmlElement(ElementName="NtfctnGnlInf")]
    public SomeNotificationGeneralInformationRecord? NotificationGeneralInformation { get; init; }
    
    /// <summary>
    /// Information to be extended as supplementary data to notification general information.
    /// </summary>
    [IsoId("_LAGx9b5MEeexmbB7KsjCwA")]
    [Description(@"Information to be extended as supplementary data to notification general information.")]
    [DataMember(Name="CorpActnGnlInf")]
    [XmlElement(ElementName="CorpActnGnlInf")]
    public SomeCorporateActionGeneralInformationRecord? CorporateActionGeneralInformation { get; init; }
    
    /// <summary>
    /// Information to be extended as supplementary data to underlying security details.
    /// </summary>
    [IsoId("_LAGx975MEeexmbB7KsjCwA")]
    [Description(@"Information to be extended as supplementary data to underlying security details.")]
    [DataMember(Name="UndrlygScty")]
    [XmlElement(ElementName="UndrlygScty")]
    public SomeUnderlyingSecurityRecord? UnderlyingSecurity { get; init; }
    
    /// <summary>
    /// Information to be extended as supplementary data to corporate action details.
    /// </summary>
    [IsoId("_LAGx-b5MEeexmbB7KsjCwA")]
    [Description(@"Information to be extended as supplementary data to corporate action details.")]
    [DataMember(Name="CorpActnDtls")]
    [XmlElement(ElementName="CorpActnDtls")]
    public SomeCorporateActionDetailsRecord? CorporateActionDetails { get; init; }
    
    /// <summary>
    /// Information to be extended as supplementary data to corporate action date details.
    /// </summary>
    [IsoId("_LAGx-75MEeexmbB7KsjCwA")]
    [Description(@"Information to be extended as supplementary data to corporate action date details.")]
    [DataMember(Name="CorpActnDtDtls")]
    [XmlElement(ElementName="CorpActnDtDtls")]
    public SomeCorporateActionDateDetailsRecord? CorporateActionDateDetails { get; init; }
    
    /// <summary>
    /// Information to be extended as corporate action price supplementary data.
    /// </summary>
    [IsoId("_LAGx_b5MEeexmbB7KsjCwA")]
    [Description(@"Information to be extended as corporate action price supplementary data.")]
    [DataMember(Name="CorpActnPricDtls")]
    [XmlElement(ElementName="CorpActnPricDtls")]
    public SomeCorporateActionPriceDetailsRecord? CorporateActionPriceDetails { get; init; }
    
    /// <summary>
    /// Information to be extended as supplementary data to corporate action period.
    /// </summary>
    [IsoId("_LAGx_75MEeexmbB7KsjCwA")]
    [Description(@"Information to be extended as supplementary data to corporate action period.")]
    [DataMember(Name="CorpActnPrdDtls")]
    [XmlElement(ElementName="CorpActnPrdDtls")]
    public SomeCorporateActionPeriodDetailsRecord? CorporateActionPeriodDetails { get; init; }
    
    /// <summary>
    /// Information to be extended as supplementary data to corporate action rate and amount.
    /// </summary>
    [IsoId("_LAGyAb5MEeexmbB7KsjCwA")]
    [Description(@"Information to be extended as supplementary data to corporate action rate and amount.")]
    [DataMember(Name="CorpActnRateAndAmtDtls")]
    [XmlElement(ElementName="CorpActnRateAndAmtDtls")]
    public SomeCorporateActionRateAndAmountDetailsRecord? CorporateActionRateAndAmountDetails { get; init; }
    
    /// <summary>
    /// Information to be extended as supplementary data to corporate action securities quantity.
    /// </summary>
    [IsoId("_LAGyA75MEeexmbB7KsjCwA")]
    [Description(@"Information to be extended as supplementary data to corporate action securities quantity.")]
    [DataMember(Name="CorpActnSctiesQty")]
    [XmlElement(ElementName="CorpActnSctiesQty")]
    public SomeCorporateActionSecuritiesQuantityRecord? CorporateActionSecuritiesQuantity { get; init; }
    
    /// <summary>
    /// Information to be extended as supplementary data to option details.
    /// </summary>
    [IsoId("_LAGyBb5MEeexmbB7KsjCwA")]
    [Description(@"Information to be extended as supplementary data to option details.")]
    [DataMember(Name="OptnDtls")]
    [XmlElement(ElementName="OptnDtls")]
    public SomeOptionDetailsRecord? OptionDetails { get; init; }
    
    /// <summary>
    /// Information to be extended as supplementary data to option date details.
    /// </summary>
    [IsoId("_LAGyB75MEeexmbB7KsjCwA")]
    [Description(@"Information to be extended as supplementary data to option date details.")]
    [DataMember(Name="OptnDtDtls")]
    [XmlElement(ElementName="OptnDtDtls")]
    public SomeOptionDateDetailsRecord? OptionDateDetails { get; init; }
    
    /// <summary>
    /// Information to be extended as supplementary data to securities movement details.
    /// </summary>
    [IsoId("_LAGyCb5MEeexmbB7KsjCwA")]
    [Description(@"Information to be extended as supplementary data to securities movement details.")]
    [DataMember(Name="SctiesMvmntDtls")]
    [XmlElement(ElementName="SctiesMvmntDtls")]
    public SomeSecuritiesMovementDetailsRecord? SecuritiesMovementDetails { get; init; }
    
    /// <summary>
    /// Information to be extended as supplementary data to securities movement security details.
    /// </summary>
    [IsoId("_LAGyC75MEeexmbB7KsjCwA")]
    [Description(@"Information to be extended as supplementary data to securities movement security details.")]
    [DataMember(Name="SctiesMvmntSctyDtls")]
    [XmlElement(ElementName="SctiesMvmntSctyDtls")]
    public SomeSecuritiesMovementSecurityDetailsRecord? SecuritiesMovementSecurityDetails { get; init; }
    
    /// <summary>
    /// Information to be extended as supplementary data to securities movement rate details.
    /// </summary>
    [IsoId("_LAGyDb5MEeexmbB7KsjCwA")]
    [Description(@"Information to be extended as supplementary data to securities movement rate details.")]
    [DataMember(Name="SctiesMvmntRateDtls")]
    [XmlElement(ElementName="SctiesMvmntRateDtls")]
    public SomeSecuritiesMovementRateDetailsRecord? SecuritiesMovementRateDetails { get; init; }
    
    /// <summary>
    /// Information to be extended as securities movement cash in lieu supplementary data.
    /// </summary>
    [IsoId("_LAGyD75MEeexmbB7KsjCwA")]
    [Description(@"Information to be extended as securities movement cash in lieu supplementary data.")]
    [DataMember(Name="SctiesMvmntCshInLieuDtls")]
    [XmlElement(ElementName="SctiesMvmntCshInLieuDtls")]
    public SomeSecuritiesMovementCashInLieuDetailsRecord? SecuritiesMovementCashInLieuDetails { get; init; }
    
    /// <summary>
    /// Information to be extended as supplementary data to securities movement fraction disposition.
    /// </summary>
    [IsoId("_LAGyEb5MEeexmbB7KsjCwA")]
    [Description(@"Information to be extended as supplementary data to securities movement fraction disposition.")]
    [DataMember(Name="SctiesMvmntFrctnDspstn")]
    [XmlElement(ElementName="SctiesMvmntFrctnDspstn")]
    public SomeSecuritiesMovementFractionDispositionRecord? SecuritiesMovementFractionDisposition { get; init; }
    
    /// <summary>
    /// Information to be extended as supplementary data to cash movement details.
    /// </summary>
    [IsoId("_LAGyE75MEeexmbB7KsjCwA")]
    [Description(@"Information to be extended as supplementary data to cash movement details.")]
    [DataMember(Name="CshMvmntDtls")]
    [XmlElement(ElementName="CshMvmntDtls")]
    public SomeCashMovementDetailsRecord? CashMovementDetails { get; init; }
    
    /// <summary>
    /// Information to be extended new agent block. Used when required ISO agent type does not exist and entire new component must be generated.
    /// </summary>
    [IsoId("_LAGyFb5MEeexmbB7KsjCwA")]
    [Description(@"Information to be extended new agent block. Used when required ISO agent type does not exist and entire new component must be generated.")]
    [DataMember(Name="NewAgt")]
    [XmlElement(ElementName="NewAgt")]
    public SomeNewAgentRecord? NewAgent { get; init; }
    
    /// <summary>
    /// Provides additional information to agent details (to message agent like "issuer agent", "reselling agent"). Used when required "ISO agent type" exists and only additional details need to be extended.
    /// </summary>
    [IsoId("_LAGyF75MEeexmbB7KsjCwA")]
    [Description(@"Provides additional information to agent details (to message agent like ""issuer agent"", ""reselling agent""). Used when required ""ISO agent type"" exists and only additional details need to be extended.")]
    [DataMember(Name="Agt")]
    [XmlElement(ElementName="Agt")]
    public SomeAgentRecord? Agent { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="DTCCCANOCSDDataSD1V10Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public DTCCCANOCSDDataSD1V10Document ToDocument()
    {
        return new DTCCCANOCSDDataSD1V10Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="DTCCCANOCSDDataSD1V10"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record DTCCCANOCSDDataSD1V10Document : IOuterDocument<DTCCCANOCSDDataSD1V10>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:supl.001.001.10";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="DTCCCANOCSDDataSD1V10"/> is required.
    /// </summary>
    public required DTCCCANOCSDDataSD1V10 Message { get; init; }
}
