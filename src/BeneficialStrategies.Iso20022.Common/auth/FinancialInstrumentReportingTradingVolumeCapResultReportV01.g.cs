﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for FinancialInstrumentReportingTradingVolumeCapResultReportV01.  ISO2002 ID# _ye5zAJuCEeaPcol5ibnfBQ.
//
namespace BeneficialStrategies.Iso20022.auth;

/// <summary>
/// The FinancialInstrumentReportingTradingVolumeCapResultReport provides volume of trading and percentage of trading under waivers for equity instruments over a period. This message is generated by the supervisory authority for public distribution.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The FinancialInstrumentReportingTradingVolumeCapResultReport provides volume of trading and percentage of trading under waivers for equity instruments over a period. This message is generated by the supervisory authority for public distribution.")]
public partial record FinancialInstrumentReportingTradingVolumeCapResultReportV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FinInstrmRptgTradgVolCapRsltRpt";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Header information related to the global report.
    /// </summary>
    [IsoId("_N3DP4JuDEeaPcol5ibnfBQ")]
    [Description(@"Header information related to the global report.")]
    [DataMember(Name="RptHdr")]
    [XmlElement(ElementName="RptHdr")]
    [Required]
    public required SomeReportHeaderRecord ReportHeader { get; init; }
    
    /// <summary>
    /// Provides details on the volume of trades and percentage of trading under waivers of financial instruments.
    /// </summary>
    [IsoId("_Q9wMAJuMEeaPcol5ibnfBQ")]
    [Description(@"Provides details on the volume of trades and percentage of trading under waivers of financial instruments.")]
    [DataMember(Name="VolCapRslt")]
    [XmlElement(ElementName="VolCapRslt")]
    [Required]
    public required SomeVolumeCapResultRecord VolumeCapResult { get; init; }
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_TcspwJuDEeaPcol5ibnfBQ")]
    [Description(@"Additional information that can not be captured in the structured fields and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SomeSupplementaryDataRecord? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="FinancialInstrumentReportingTradingVolumeCapResultReportV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public FinancialInstrumentReportingTradingVolumeCapResultReportV01Document ToDocument()
    {
        return new FinancialInstrumentReportingTradingVolumeCapResultReportV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="FinancialInstrumentReportingTradingVolumeCapResultReportV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record FinancialInstrumentReportingTradingVolumeCapResultReportV01Document : IOuterDocument<FinancialInstrumentReportingTradingVolumeCapResultReportV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.053.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="FinancialInstrumentReportingTradingVolumeCapResultReportV01"/> is required.
    /// </summary>
    public required FinancialInstrumentReportingTradingVolumeCapResultReportV01 Message { get; init; }
}