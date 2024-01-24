﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for ManagementPlanReplacementV08.  ISO2002 ID# _BegL8Q02EeqUVL7sB4m7NA.
//
namespace BeneficialStrategies.Iso20022.catm;

/// <summary>
/// The ManagementPlanReplacement message is sent by a terminal manager to a POI to set maintenance actions to be performed.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The ManagementPlanReplacement message is sent by a terminal manager to a POI to set maintenance actions to be performed.")]
public partial record ManagementPlanReplacementV08 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MgmtPlanRplcmnt";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Set of characteristics related to the transfer of the management plan.
    /// </summary>
    [IsoId("_BegL9Q02EeqUVL7sB4m7NA")]
    [Description(@"Set of characteristics related to the transfer of the management plan.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required SomeHeaderRecord Header { get; init; }
    
    /// <summary>
    /// Sequence of terminal maintenance actions to be performed by a point of interaction (POI).
    /// </summary>
    [IsoId("_BegL9w02EeqUVL7sB4m7NA")]
    [Description(@"Sequence of terminal maintenance actions to be performed by a point of interaction (POI).")]
    [DataMember(Name="MgmtPlan")]
    [XmlElement(ElementName="MgmtPlan")]
    [Required]
    public required SomeManagementPlanRecord ManagementPlan { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC or a digital signature.
    /// </summary>
    [IsoId("_BegL-Q02EeqUVL7sB4m7NA")]
    [Description(@"Trailer of the message containing a MAC or a digital signature.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    public SomeSecurityTrailerRecord? SecurityTrailer { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="ManagementPlanReplacementV08Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public ManagementPlanReplacementV08Document ToDocument()
    {
        return new ManagementPlanReplacementV08Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="ManagementPlanReplacementV08"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record ManagementPlanReplacementV08Document : IOuterDocument<ManagementPlanReplacementV08>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:catm.002.001.08";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="ManagementPlanReplacementV08"/> is required.
    /// </summary>
    public required ManagementPlanReplacementV08 Message { get; init; }
}
