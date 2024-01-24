﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for FinancialInstrumentReportingNonEquityTradingActivityResultV03.  ISO2002 ID# _6jUM0aaTEeqZmriXpMtonA.
//
namespace BeneficialStrategies.Iso20022.auth;

/// <summary>
/// The FinancialInstrumentReportingNonEquityTradingActivityResult message is sent by the trading venue to the national competent authority to report on computed results data of non-equity specific trading activity.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The FinancialInstrumentReportingNonEquityTradingActivityResult message is sent by the trading venue to the national competent authority to report on computed results data of non-equity specific trading activity.")]
public partial record FinancialInstrumentReportingNonEquityTradingActivityResultV03 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FinInstrmRptgNonEqtyTradgActvtyRslt";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="FinancialInstrumentReportingNonEquityTradingActivityResultV03Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public FinancialInstrumentReportingNonEquityTradingActivityResultV03Document ToDocument()
    {
        return new FinancialInstrumentReportingNonEquityTradingActivityResultV03Document { Message = this };
    }
}

/// <summary>
/// The FinancialInstrumentReportingNonEquityTradingActivityResult message is sent by the trading venue to the national competent authority to report on computed results data of non-equity specific trading activity.
/// This is the outer document that contains <seealso cref="FinancialInstrumentReportingNonEquityTradingActivityResultV03"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record FinancialInstrumentReportingNonEquityTradingActivityResultV03Document : IOuterDocument<FinancialInstrumentReportingNonEquityTradingActivityResultV03>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.045.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="FinancialInstrumentReportingNonEquityTradingActivityResultV03"/> is required.
    /// </summary>
    public required FinancialInstrumentReportingNonEquityTradingActivityResultV03 Message { get; init; }
}
