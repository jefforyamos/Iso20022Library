﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for FinancialInstrumentReportingReferenceDataDeltaReportV02.  ISO2002 ID# _AKTqESdoEei12pGEsJIAeQ.
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
/// The FinancialInstrumentReportingReferenceDataDeltaReport message is sent by the trading venues to the national competent authority to report on changes that have occurred in the base data between reference data file generation.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The FinancialInstrumentReportingReferenceDataDeltaReport message is sent by the trading venues to the national competent authority to report on changes that have occurred in the base data between reference data file generation.")]
public partial record FinancialInstrumentReportingReferenceDataDeltaReportV02 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FinInstrmRptgRefDataDltaRpt";
    
    #nullable enable
    /// <summary>
    /// Header information related to the global report.
    /// </summary>
    [IsoId("_AKTqEydoEei12pGEsJIAeQ")]
    [Description(@"Header information related to the global report.")]
    [DataMember(Name="RptHdr")]
    [XmlElement(ElementName="RptHdr")]
    [Required]
    public required SecuritiesMarketReportHeader1 ReportHeader { get; init; }
    
    /// <summary>
    /// Provides the details of the reference data that have been updated (since the last report).
    /// </summary>
    [IsoId("_AKURISdoEei12pGEsJIAeQ")]
    [Description(@"Provides the details of the reference data that have been updated (since the last report).")]
    [DataMember(Name="FinInstrm")]
    [XmlElement(ElementName="FinInstrm")]
    public ISecuritiesReferenceDeltaStatusReport3Choice? FinancialInstrument { get; init; }
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_AKURIydoEei12pGEsJIAeQ")]
    [Description(@"Additional information that can not be captured in the structured fields and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="FinancialInstrumentReportingReferenceDataDeltaReportV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public FinancialInstrumentReportingReferenceDataDeltaReportV02Document ToDocument()
    {
        return new FinancialInstrumentReportingReferenceDataDeltaReportV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="FinancialInstrumentReportingReferenceDataDeltaReportV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record FinancialInstrumentReportingReferenceDataDeltaReportV02Document : IOuterDocument<FinancialInstrumentReportingReferenceDataDeltaReportV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.036.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="FinancialInstrumentReportingReferenceDataDeltaReportV02"/> is required.
    /// </summary>
    public required FinancialInstrumentReportingReferenceDataDeltaReportV02 Message { get; init; }
}
