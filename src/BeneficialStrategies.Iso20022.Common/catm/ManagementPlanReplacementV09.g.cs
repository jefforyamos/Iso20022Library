﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for ManagementPlanReplacementV09.  ISO2002 ID# _vWfH8Si8Eeurkfo6MpvKDA.
//
namespace BeneficialStrategies.Iso20022.catm;

/// <summary>
/// The ManagementPlanReplacement message is sent by a terminal manager to a POI to set maintenance actions to be performed.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The ManagementPlanReplacement message is sent by a terminal manager to a POI to set maintenance actions to be performed.")]
public partial record ManagementPlanReplacementV09 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MgmtPlanRplcmnt";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="ManagementPlanReplacementV09Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public ManagementPlanReplacementV09Document ToDocument()
    {
        return new ManagementPlanReplacementV09Document { Message = this };
    }
}

/// <summary>
/// The ManagementPlanReplacement message is sent by a terminal manager to a POI to set maintenance actions to be performed.
/// This is the outer document that contains <seealso cref="ManagementPlanReplacementV09"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record ManagementPlanReplacementV09Document : IOuterDocument<ManagementPlanReplacementV09>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:catm.002.001.09";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="ManagementPlanReplacementV09"/> is required.
    /// </summary>
    public required ManagementPlanReplacementV09 Message { get; init; }
}
