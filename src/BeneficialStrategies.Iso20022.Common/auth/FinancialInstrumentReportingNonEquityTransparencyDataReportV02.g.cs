﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for FinancialInstrumentReportingNonEquityTransparencyDataReportV02.  ISO2002 ID# _MCQRcCcFEeiPcf9yet9QmA.
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
/// The FinancialInstrumentReportingNonEquityTransparencyDataReport message is sent by the trading venue to the national competent authority to submit non equity specific details as part of classifying and applying necessary transparency non equity computations.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The FinancialInstrumentReportingNonEquityTransparencyDataReport message is sent by the trading venue to the national competent authority to submit non equity specific details as part of classifying and applying necessary transparency non equity computations.")]
public partial record FinancialInstrumentReportingNonEquityTransparencyDataReportV02 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FinInstrmRptgNonEqtyTrnsprncyDataRpt";
    
    #nullable enable
    /// <summary>
    /// Header information related to the global report.
    /// </summary>
    [IsoId("_MCjzcScFEeiPcf9yet9QmA")]
    [Description(@"Header information related to the global report.")]
    [DataMember(Name="RptHdr")]
    [XmlElement(ElementName="RptHdr")]
    [Required]
    public required SecuritiesMarketReportHeader1 ReportHeader { get; init; }
    
    /// <summary>
    /// Details the non-equity transparency qualitative data reported by a trading venue.
    /// </summary>
    [IsoId("_MC2uYScFEeiPcf9yet9QmA")]
    [Description(@"Details the non-equity transparency qualitative data reported by a trading venue.")]
    [DataMember(Name="NonEqtyTrnsprncyData")]
    [XmlElement(ElementName="NonEqtyTrnsprncyData")]
    [Required]
    public required TransparencyDataReport16 NonEquityTransparencyData { get; init; }
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_MC2uYycFEeiPcf9yet9QmA")]
    [Description(@"Additional information that can not be captured in the structured fields and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="FinancialInstrumentReportingNonEquityTransparencyDataReportV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public FinancialInstrumentReportingNonEquityTransparencyDataReportV02Document ToDocument()
    {
        return new FinancialInstrumentReportingNonEquityTransparencyDataReportV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="FinancialInstrumentReportingNonEquityTransparencyDataReportV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record FinancialInstrumentReportingNonEquityTransparencyDataReportV02Document : IOuterDocument<FinancialInstrumentReportingNonEquityTransparencyDataReportV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.033.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="FinancialInstrumentReportingNonEquityTransparencyDataReportV02"/> is required.
    /// </summary>
    public required FinancialInstrumentReportingNonEquityTransparencyDataReportV02 Message { get; init; }
}
