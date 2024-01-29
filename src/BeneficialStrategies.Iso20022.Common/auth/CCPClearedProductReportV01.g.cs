﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for CCPClearedProductReportV01.  ISO2002 ID# _sNWfAeUTEem3X-64-NKdqg.
//
namespace BeneficialStrategies.Iso20022.auth;

/// <summary>
/// The CCPClearedProductReport message is sent from the central counterparty to the national competent authority. It is used to inform the national competent authority about the financial instruments cleared by the central counterparty.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The CCPClearedProductReport message is sent from the central counterparty to the national competent authority. It is used to inform the national competent authority about the financial instruments cleared by the central counterparty.")]
public partial record CCPClearedProductReportV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CCPClrdPdctRpt";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Financial instrument cleared by a central counterparty.
    /// </summary>
    [IsoId("_sNWfCeUTEem3X-64-NKdqg")]
    [Description(@"Financial instrument cleared by a central counterparty.")]
    [DataMember(Name="ClrdPdct")]
    [XmlElement(ElementName="ClrdPdct")]
    [Required]
    public required SomeClearedProductRecord ClearedProduct { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_sNWfC-UTEem3X-64-NKdqg")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SomeSupplementaryDataRecord? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="CCPClearedProductReportV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public CCPClearedProductReportV01Document ToDocument()
    {
        return new CCPClearedProductReportV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="CCPClearedProductReportV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record CCPClearedProductReportV01Document : IOuterDocument<CCPClearedProductReportV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.069.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="CCPClearedProductReportV01"/> is required.
    /// </summary>
    public required CCPClearedProductReportV01 Message { get; init; }
}