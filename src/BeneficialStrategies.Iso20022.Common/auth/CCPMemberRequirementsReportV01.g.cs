﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for CCPMemberRequirementsReportV01.  ISO2002 ID# _daMXQeUUEem3X-64-NKdqg.
//
namespace BeneficialStrategies.Iso20022.auth;

/// <summary>
/// The CCPMemberRequirementsReport message is sent from the central counterparty to the national competent authority. It is used to inform the national competent authority about the collateral requirements that a central counterparty obligates a clearing member post at the central counterparty.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The CCPMemberRequirementsReport message is sent from the central counterparty to the national competent authority. It is used to inform the national competent authority about the collateral requirements that a central counterparty obligates a clearing member post at the central counterparty.")]
public partial record CCPMemberRequirementsReportV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CCPMmbRqrmntsRpt";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Obligations of a clearing member with respect to a central counterparty that are calculated based on intraday positions.
    /// </summary>
    [IsoId("_daMXSeUUEem3X-64-NKdqg")]
    [Description(@"Obligations of a clearing member with respect to a central counterparty that are calculated based on intraday positions.")]
    [DataMember(Name="IntraDayRqrmntAmt")]
    [XmlElement(ElementName="IntraDayRqrmntAmt")]
    [Required]
    public required IntraDayRequirement1 IntraDayRequirementAmount { get; init; }
    
    /// <summary>
    /// Describes an instance of an intraday margin call being made against a margin account.
    /// </summary>
    [IsoId("_daMXS-UUEem3X-64-NKdqg")]
    [Description(@"Describes an instance of an intraday margin call being made against a margin account.")]
    [DataMember(Name="IntraDayMrgnCall")]
    [XmlElement(ElementName="IntraDayMrgnCall")]
    public IntraDayMarginCall1? IntraDayMarginCall { get; init; }
    
    /// <summary>
    /// Obligations of a clearing member with respect to a central counterparty that are calculated based on end of day positions.
    /// </summary>
    [IsoId("_daMXTeUUEem3X-64-NKdqg")]
    [Description(@"Obligations of a clearing member with respect to a central counterparty that are calculated based on end of day positions.")]
    [DataMember(Name="EndOfDayRqrmnt")]
    [XmlElement(ElementName="EndOfDayRqrmnt")]
    [Required]
    public required EndOfDayRequirement2 EndOfDayRequirement { get; init; }
    
    /// <summary>
    /// Requirement for a clearing member to post collateral at a central counterparty with respect to a default fund.
    /// </summary>
    [IsoId("_daMXT-UUEem3X-64-NKdqg")]
    [Description(@"Requirement for a clearing member to post collateral at a central counterparty with respect to a default fund.")]
    [DataMember(Name="DfltFndRqrmnt")]
    [XmlElement(ElementName="DfltFndRqrmnt")]
    [Required]
    public required DefaultFundRequirement1 DefaultFundRequirement { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_daMXUeUUEem3X-64-NKdqg")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="CCPMemberRequirementsReportV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public CCPMemberRequirementsReportV01Document ToDocument()
    {
        return new CCPMemberRequirementsReportV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="CCPMemberRequirementsReportV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record CCPMemberRequirementsReportV01Document : IOuterDocument<CCPMemberRequirementsReportV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.055.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="CCPMemberRequirementsReportV01"/> is required.
    /// </summary>
    public required CCPMemberRequirementsReportV01 Message { get; init; }
}
