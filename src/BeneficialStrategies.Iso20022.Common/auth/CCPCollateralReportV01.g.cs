﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for CCPCollateralReportV01.  ISO2002 ID# _5aP-IeUTEem3X-64-NKdqg.
//
namespace BeneficialStrategies.Iso20022.auth;

/// <summary>
/// The CCPCollateralReport message is sent from the central counterparty to the national competent authority. It is used to inform the national competent authority about the collateral posted by clearing members at the central counterparty.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The CCPCollateralReport message is sent from the central counterparty to the national competent authority. It is used to inform the national competent authority about the collateral posted by clearing members at the central counterparty.")]
public partial record CCPCollateralReportV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CCPCollRpt";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Central counterparties record of the collateral posted by clearing members to meet the obligations of the associated margin account or accounts.
    /// </summary>
    [IsoId("_5aP-KeUTEem3X-64-NKdqg")]
    [Description(@"Central counterparties record of the collateral posted by clearing members to meet the obligations of the associated margin account or accounts.")]
    [DataMember(Name="CollAcctOwnr")]
    [XmlElement(ElementName="CollAcctOwnr")]
    [Required]
    public required CollateralAccount4 CollateralAccountOwner { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_5aP-K-UTEem3X-64-NKdqg")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="CCPCollateralReportV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public CCPCollateralReportV01Document ToDocument()
    {
        return new CCPCollateralReportV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="CCPCollateralReportV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record CCPCollateralReportV01Document : IOuterDocument<CCPCollateralReportV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.067.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="CCPCollateralReportV01"/> is required.
    /// </summary>
    public required CCPCollateralReportV01 Message { get; init; }
}
