﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for FinancialInstrumentReportingNonEquityTradingActivityResultV02.  ISO2002 ID# _BgiEQSe3Eei12pGEsJIAeQ.
//
namespace BeneficialStrategies.Iso20022.auth;

/// <summary>
/// The FinancialInstrumentReportingNonEquityTradingActivityResult message is sent by the trading venue to the national competent authority to report on computed results data of non-equity specific trading activity.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The FinancialInstrumentReportingNonEquityTradingActivityResult message is sent by the trading venue to the national competent authority to report on computed results data of non-equity specific trading activity.")]
public partial record FinancialInstrumentReportingNonEquityTradingActivityResultV02 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FinInstrmRptgNonEqtyTradgActvtyRslt";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Header information related to the global report.
    /// </summary>
    [IsoId("_BgiEQye3Eei12pGEsJIAeQ")]
    [Description(@"Header information related to the global report.")]
    [DataMember(Name="RptHdr")]
    [XmlElement(ElementName="RptHdr")]
    [Required]
    public required SomeReportHeaderRecord ReportHeader { get; init; }
    
    /// <summary>
    /// Details the transparency data reported by a trading venue.
    /// </summary>
    [IsoId("_BgiERSe3Eei12pGEsJIAeQ")]
    [Description(@"Details the transparency data reported by a trading venue.")]
    [DataMember(Name="NonEqtyTrnsprncyData")]
    [XmlElement(ElementName="NonEqtyTrnsprncyData")]
    [Required]
    public required SomeNonEquityTransparencyDataRecord NonEquityTransparencyData { get; init; }
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_BgiERye3Eei12pGEsJIAeQ")]
    [Description(@"Additional information that can not be captured in the structured fields and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SomeSupplementaryDataRecord? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="FinancialInstrumentReportingNonEquityTradingActivityResultV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public FinancialInstrumentReportingNonEquityTradingActivityResultV02Document ToDocument()
    {
        return new FinancialInstrumentReportingNonEquityTradingActivityResultV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="FinancialInstrumentReportingNonEquityTradingActivityResultV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record FinancialInstrumentReportingNonEquityTradingActivityResultV02Document : IOuterDocument<FinancialInstrumentReportingNonEquityTradingActivityResultV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.045.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="FinancialInstrumentReportingNonEquityTradingActivityResultV02"/> is required.
    /// </summary>
    public required FinancialInstrumentReportingNonEquityTradingActivityResultV02 Message { get; init; }
}
