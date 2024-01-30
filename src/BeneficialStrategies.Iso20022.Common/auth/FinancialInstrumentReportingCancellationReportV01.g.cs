﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for FinancialInstrumentReportingCancellationReportV01.  ISO2002 ID# _u2C60GOfEeqrzPlWMq8k6Q.
//
namespace BeneficialStrategies.Iso20022.auth;

/// <summary>
/// This FinancialInstrumentReportingCancellationReport message is sent by the trading venue to the national competent authority to cancel reference data previously reported by mistake.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"This FinancialInstrumentReportingCancellationReport message is sent by the trading venue to the national competent authority to cancel reference data previously reported by mistake.")]
public partial record FinancialInstrumentReportingCancellationReportV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FinInstrmRptgCxlRpt";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Header information related to the global report.
    /// </summary>
    [IsoId("_SsqY0GOgEeqrzPlWMq8k6Q")]
    [Description(@"Header information related to the global report.")]
    [DataMember(Name="RptHdr")]
    [XmlElement(ElementName="RptHdr")]
    [Required]
    public required SecuritiesMarketReportHeader1 ReportHeader { get; init; }
    
    /// <summary>
    /// Details of the financial instrument previously reported by mistake by the trading venue.
    /// </summary>
    [IsoId("_iu4fQGOgEeqrzPlWMq8k6Q")]
    [Description(@"Details of the financial instrument previously reported by mistake by the trading venue.")]
    [DataMember(Name="CxlData")]
    [XmlElement(ElementName="CxlData")]
    [Required]
    public required SecuritiesReferenceDataReport7 CancellationData { get; init; }
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_vRvi4GOgEeqrzPlWMq8k6Q")]
    [Description(@"Additional information that can not be captured in the structured fields and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="FinancialInstrumentReportingCancellationReportV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public FinancialInstrumentReportingCancellationReportV01Document ToDocument()
    {
        return new FinancialInstrumentReportingCancellationReportV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="FinancialInstrumentReportingCancellationReportV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record FinancialInstrumentReportingCancellationReportV01Document : IOuterDocument<FinancialInstrumentReportingCancellationReportV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.102.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="FinancialInstrumentReportingCancellationReportV01"/> is required.
    /// </summary>
    public required FinancialInstrumentReportingCancellationReportV01 Message { get; init; }
}
