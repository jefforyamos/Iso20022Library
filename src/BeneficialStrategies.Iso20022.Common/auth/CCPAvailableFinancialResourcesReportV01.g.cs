﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for CCPAvailableFinancialResourcesReportV01.  ISO2002 ID# _omGWYeUREem3X-64-NKdqg.
//
namespace BeneficialStrategies.Iso20022.auth;

/// <summary>
/// The CCPAvailableFinancialResourcesReport message is sent from the central counterparty to the national competent authority. It is used to inform the national competent authority of the aggregate quantum of resources available in each default waterfall to absorb losses resulting from the failure of one or more clearing member(s).
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The CCPAvailableFinancialResourcesReport message is sent from the central counterparty to the national competent authority. It is used to inform the national competent authority of the aggregate quantum of resources available in each default waterfall to absorb losses resulting from the failure of one or more clearing member(s).")]
public partial record CCPAvailableFinancialResourcesReportV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CCPAvlblFinRsrcsRpt";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Construct used by a central counterparty to define the size of the aggregate quantum of resources available from a clearing member.
    /// </summary>
    [IsoId("_omGWaeUREem3X-64-NKdqg")]
    [Description(@"Construct used by a central counterparty to define the size of the aggregate quantum of resources available from a clearing member.")]
    [DataMember(Name="AvlblFinRsrcsAmt")]
    [XmlElement(ElementName="AvlblFinRsrcsAmt")]
    [Required]
    public required SomeAvailableFinancialResourcesAmountRecord AvailableFinancialResourcesAmount { get; init; }
    
    /// <summary>
    /// Breakdown of other CCP prefunded resources required as part of the default waterfall.
    /// </summary>
    [IsoId("_omGWa-UREem3X-64-NKdqg")]
    [Description(@"Breakdown of other CCP prefunded resources required as part of the default waterfall.")]
    [DataMember(Name="OthrPrfnddRsrcs")]
    [XmlElement(ElementName="OthrPrfnddRsrcs")]
    public SomeOtherPrefundedResourcesRecord? OtherPrefundedResources { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_omGWbeUREem3X-64-NKdqg")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SomeSupplementaryDataRecord? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="CCPAvailableFinancialResourcesReportV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public CCPAvailableFinancialResourcesReportV01Document ToDocument()
    {
        return new CCPAvailableFinancialResourcesReportV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="CCPAvailableFinancialResourcesReportV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record CCPAvailableFinancialResourcesReportV01Document : IOuterDocument<CCPAvailableFinancialResourcesReportV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.064.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="CCPAvailableFinancialResourcesReportV01"/> is required.
    /// </summary>
    public required CCPAvailableFinancialResourcesReportV01 Message { get; init; }
}