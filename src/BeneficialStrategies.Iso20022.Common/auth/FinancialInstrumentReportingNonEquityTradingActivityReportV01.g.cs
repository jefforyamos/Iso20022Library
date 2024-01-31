﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for FinancialInstrumentReportingNonEquityTradingActivityReportV01.  ISO2002 ID# _4LK8a0RNEee7JdgA9zPESA.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.auth;


/// <summary>
/// This record is an implementation of the auth.041.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The FinancialInstrumentReportingNonEquityTradingActivityReport message is sent by the trading venue to the national competent authority to report on non-equity specific trading activity aggregated quantitative data, used for the transparency calculations.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The FinancialInstrumentReportingNonEquityTradingActivityReport message is sent by the trading venue to the national competent authority to report on non-equity specific trading activity aggregated quantitative data, used for the transparency calculations.")]
public partial record FinancialInstrumentReportingNonEquityTradingActivityReportV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "auth.041.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FinInstrmRptgNonEqtyTradgActvtyRpt";
    
    #nullable enable
    /// <summary>
    /// Header information related to the global report.
    /// </summary>
    [IsoId("_4LK8bURNEee7JdgA9zPESA")]
    [Description(@"Header information related to the global report.")]
    [DataMember(Name="RptHdr")]
    [XmlElement(ElementName="RptHdr")]
    [Required]
    public required SecuritiesMarketReportHeader1 ReportHeader { get; init; }
    
    /// <summary>
    /// Details the transparency data reported by a trading venue.
    /// </summary>
    [IsoId("_4LK8b0RNEee7JdgA9zPESA")]
    [Description(@"Details the transparency data reported by a trading venue.")]
    [DataMember(Name="NonEqtyTrnsprncyData")]
    [XmlElement(ElementName="NonEqtyTrnsprncyData")]
    [Required]
    public required TransparencyDataReport15 NonEquityTransparencyData { get; init; }
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_4LK8cURNEee7JdgA9zPESA")]
    [Description(@"Additional information that can not be captured in the structured fields and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="FinancialInstrumentReportingNonEquityTradingActivityReportV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public FinancialInstrumentReportingNonEquityTradingActivityReportV01Document ToDocument()
    {
        return new FinancialInstrumentReportingNonEquityTradingActivityReportV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="FinancialInstrumentReportingNonEquityTradingActivityReportV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record FinancialInstrumentReportingNonEquityTradingActivityReportV01Document : IOuterDocument<FinancialInstrumentReportingNonEquityTradingActivityReportV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.041.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="FinancialInstrumentReportingNonEquityTradingActivityReportV01"/> is required.
    /// </summary>
    public required FinancialInstrumentReportingNonEquityTradingActivityReportV01 Message { get; init; }
}
