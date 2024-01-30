﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for CCPPortfolioStressTestingDefinitionReportV01.  ISO2002 ID# _kjFskeUUEem3X-64-NKdqg.
//
namespace BeneficialStrategies.Iso20022.auth;

/// <summary>
/// The CCPPortfolioStressTestingDefinitionReport message is sent from the central counterparty to the national competent authority. It is used to inform the national competent authority about how the central counterparty defines stress scenarios used to stress clearing member portfolios.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The CCPPortfolioStressTestingDefinitionReport message is sent from the central counterparty to the national competent authority. It is used to inform the national competent authority about how the central counterparty defines stress scenarios used to stress clearing member portfolios.")]
public partial record CCPPortfolioStressTestingDefinitionReportV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CCPPrtflStrssTstgDefRpt";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Contains high level data on a stress scenario being applied to portfolios in order to calculate stress losses.
    /// </summary>
    [IsoId("_kjFsmeUUEem3X-64-NKdqg")]
    [Description(@"Contains high level data on a stress scenario being applied to portfolios in order to calculate stress losses.")]
    [DataMember(Name="ScnroDef")]
    [XmlElement(ElementName="ScnroDef")]
    [Required]
    public required ScenarioDefinition1 ScenarioDefinition { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_kjFsm-UUEem3X-64-NKdqg")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="CCPPortfolioStressTestingDefinitionReportV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public CCPPortfolioStressTestingDefinitionReportV01Document ToDocument()
    {
        return new CCPPortfolioStressTestingDefinitionReportV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="CCPPortfolioStressTestingDefinitionReportV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record CCPPortfolioStressTestingDefinitionReportV01Document : IOuterDocument<CCPPortfolioStressTestingDefinitionReportV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.057.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="CCPPortfolioStressTestingDefinitionReportV01"/> is required.
    /// </summary>
    public required CCPPortfolioStressTestingDefinitionReportV01 Message { get; init; }
}
