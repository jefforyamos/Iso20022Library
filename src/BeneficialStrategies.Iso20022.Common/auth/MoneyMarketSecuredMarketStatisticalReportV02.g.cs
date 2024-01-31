﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for MoneyMarketSecuredMarketStatisticalReportV02.  ISO2002 ID# _DufHwcEPEea7jLfvGi1PDw.
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
/// The MoneyMarketSecuredMarketStatisticalReport message is sent by the reporting agents to the relevant competent authority, to report all relevant secured money market transactions.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The MoneyMarketSecuredMarketStatisticalReport message is sent by the reporting agents to the relevant competent authority, to report all relevant secured money market transactions.")]
public partial record MoneyMarketSecuredMarketStatisticalReportV02 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MnyMktScrdMktSttstclRpt";
    
    #nullable enable
    /// <summary>
    /// Provides the elements specific to the report.
    /// </summary>
    [IsoId("_DufHw8EPEea7jLfvGi1PDw")]
    [Description(@"Provides the elements specific to the report.")]
    [DataMember(Name="RptHdr")]
    [XmlElement(ElementName="RptHdr")]
    [Required]
    public required MoneyMarketReportHeader1 ReportHeader { get; init; }
    
    /// <summary>
    /// Provides the reason why no activity is reported or the required list of transactions for the secured market segment.
    /// </summary>
    [IsoId("_DufHxcEPEea7jLfvGi1PDw")]
    [Description(@"Provides the reason why no activity is reported or the required list of transactions for the secured market segment.")]
    [DataMember(Name="ScrdMktRpt")]
    [XmlElement(ElementName="ScrdMktRpt")]
    [Required]
    public required ISecuredMarketReport4Choice SecuredMarketReport { get; init; }
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_DufHx8EPEea7jLfvGi1PDw")]
    [Description(@"Additional information that can not be captured in the structured fields and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="MoneyMarketSecuredMarketStatisticalReportV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public MoneyMarketSecuredMarketStatisticalReportV02Document ToDocument()
    {
        return new MoneyMarketSecuredMarketStatisticalReportV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="MoneyMarketSecuredMarketStatisticalReportV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record MoneyMarketSecuredMarketStatisticalReportV02Document : IOuterDocument<MoneyMarketSecuredMarketStatisticalReportV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.012.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="MoneyMarketSecuredMarketStatisticalReportV02"/> is required.
    /// </summary>
    public required MoneyMarketSecuredMarketStatisticalReportV02 Message { get; init; }
}
