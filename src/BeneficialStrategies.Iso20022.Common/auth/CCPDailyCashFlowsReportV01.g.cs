﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for CCPDailyCashFlowsReportV01.  ISO2002 ID# _-yhDUeUTEem3X-64-NKdqg.
//
namespace BeneficialStrategies.Iso20022.auth;

/// <summary>
/// The CCPDailyCashFlowsReport message is sent from the central counterparty to the national competent authority. It is used to inform the national competent authority of the operational performance and exposures that occurred in a central counterparty payment system.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The CCPDailyCashFlowsReport message is sent from the central counterparty to the national competent authority. It is used to inform the national competent authority of the operational performance and exposures that occurred in a central counterparty payment system.|")]
public partial record CCPDailyCashFlowsReportV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CCPDalyCshFlowsRpt";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Deposit taking institution with which a central counterparty has accounts used to concentrate cash funds before or after investment.
    /// </summary>
    [IsoId("_-yhDWeUTEem3X-64-NKdqg")]
    [Description(@"Deposit taking institution with which a central counterparty has accounts used to concentrate cash funds before or after investment.")]
    [DataMember(Name="CncntrtnAgt")]
    [XmlElement(ElementName="CncntrtnAgt")]
    [Required]
    public required SomeConcentrationAgentRecord ConcentrationAgent { get; init; }
    
    /// <summary>
    /// Agent used by a central counterparty to allow for the convenient settlement of obligations between a central counterparty and a clearing member, typically in commercial bank money.
    /// </summary>
    [IsoId("_-yhDW-UTEem3X-64-NKdqg")]
    [Description(@"Agent used by a central counterparty to allow for the convenient settlement of obligations between a central counterparty and a clearing member, typically in commercial bank money.")]
    [DataMember(Name="SttlmAgt")]
    [XmlElement(ElementName="SttlmAgt")]
    [Required]
    public required SomeSettlementAgentRecord SettlementAgent { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_-yhDXeUTEem3X-64-NKdqg")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SomeSupplementaryDataRecord? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="CCPDailyCashFlowsReportV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public CCPDailyCashFlowsReportV01Document ToDocument()
    {
        return new CCPDailyCashFlowsReportV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="CCPDailyCashFlowsReportV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record CCPDailyCashFlowsReportV01Document : IOuterDocument<CCPDailyCashFlowsReportV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.060.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="CCPDailyCashFlowsReportV01"/> is required.
    /// </summary>
    public required CCPDailyCashFlowsReportV01 Message { get; init; }
}
