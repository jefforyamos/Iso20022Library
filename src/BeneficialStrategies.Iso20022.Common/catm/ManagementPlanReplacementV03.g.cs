﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for ManagementPlanReplacementV03.  ISO2002 ID# _sO3hwTWBEeODSIIQsYYKhw.
//
namespace BeneficialStrategies.Iso20022.catm;

/// <summary>
/// Terminal maintenance actions to be performed by a point of interaction (POI).
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Terminal maintenance actions to be performed by a point of interaction (POI).")]
public partial record ManagementPlanReplacementV03 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MgmtPlanRplcmnt";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="ManagementPlanReplacementV03Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public ManagementPlanReplacementV03Document ToDocument()
    {
        return new ManagementPlanReplacementV03Document { Message = this };
    }
}

/// <summary>
/// Terminal maintenance actions to be performed by a point of interaction (POI).
/// This is the outer document that contains <seealso cref="ManagementPlanReplacementV03"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record ManagementPlanReplacementV03Document : IOuterDocument<ManagementPlanReplacementV03>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:catm.002.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="ManagementPlanReplacementV03"/> is required.
    /// </summary>
    public required ManagementPlanReplacementV03 Message { get; init; }
}
