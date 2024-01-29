﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for FinancialInstrumentReportingEquityTradingActivityResultV01.  ISO2002 ID# _4LK8RURNEee7JdgA9zPESA.
//
namespace BeneficialStrategies.Iso20022.auth;

/// <summary>
/// The FinancialInstrumentReportingEquityTradingActivityResult message is sent by a national competent authority to report on computed results data of equity specific trading activity.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The FinancialInstrumentReportingEquityTradingActivityResult message is sent by a national competent authority to report on computed results data of equity specific trading activity.")]
public partial record FinancialInstrumentReportingEquityTradingActivityResultV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FinInstrmRptgEqtyTradgActvtyRslt";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Header to provide details on when and from whom the message originates.
    /// </summary>
    [IsoId("_4LK8R0RNEee7JdgA9zPESA")]
    [Description(@"Header to provide details on when and from whom the message originates.")]
    [DataMember(Name="RptHdr")]
    [XmlElement(ElementName="RptHdr")]
    [Required]
    public required SomeReportHeaderRecord ReportHeader { get; init; }
    
    /// <summary>
    /// Details the transparency data reported by a trading venue.
    /// </summary>
    [IsoId("_4LK8SURNEee7JdgA9zPESA")]
    [Description(@"Details the transparency data reported by a trading venue.")]
    [DataMember(Name="EqtyTrnsprncyData")]
    [XmlElement(ElementName="EqtyTrnsprncyData")]
    [Required]
    public required SomeEquityTransparencyDataRecord EquityTransparencyData { get; init; }
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_4LK8S0RNEee7JdgA9zPESA")]
    [Description(@"Additional information that can not be captured in the structured fields and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SomeSupplementaryDataRecord? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="FinancialInstrumentReportingEquityTradingActivityResultV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public FinancialInstrumentReportingEquityTradingActivityResultV01Document ToDocument()
    {
        return new FinancialInstrumentReportingEquityTradingActivityResultV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="FinancialInstrumentReportingEquityTradingActivityResultV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record FinancialInstrumentReportingEquityTradingActivityResultV01Document : IOuterDocument<FinancialInstrumentReportingEquityTradingActivityResultV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.044.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="FinancialInstrumentReportingEquityTradingActivityResultV01"/> is required.
    /// </summary>
    public required FinancialInstrumentReportingEquityTradingActivityResultV01 Message { get; init; }
}