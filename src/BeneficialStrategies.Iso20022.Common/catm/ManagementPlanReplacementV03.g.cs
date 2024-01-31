﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for ManagementPlanReplacementV03.  ISO2002 ID# _sO3hwTWBEeODSIIQsYYKhw.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.catm;


/// <summary>
/// This record is an implementation of the catm.002.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Terminal maintenance actions to be performed by a point of interaction (POI).
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Terminal maintenance actions to be performed by a point of interaction (POI).")]
public partial record ManagementPlanReplacementV03 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "catm.002.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MgmtPlanRplcmnt";
    
    #nullable enable
    /// <summary>
    /// Set of characteristics related to the transfer of the management plan.
    /// </summary>
    [IsoId("_sO3hwzWBEeODSIIQsYYKhw")]
    [Description(@"Set of characteristics related to the transfer of the management plan.")]
    [DataMember(Name="Hdr")]
    [XmlElement(ElementName="Hdr")]
    [Required]
    public required Header4 Header { get; init; }
    
    /// <summary>
    /// Sequence of terminal maintenance actions to be performed by a point of interaction (POI).
    /// </summary>
    [IsoId("_sO3hxTWBEeODSIIQsYYKhw")]
    [Description(@"Sequence of terminal maintenance actions to be performed by a point of interaction (POI).")]
    [DataMember(Name="MgmtPlan")]
    [XmlElement(ElementName="MgmtPlan")]
    [Required]
    public required ManagementPlan3 ManagementPlan { get; init; }
    
    /// <summary>
    /// Trailer of the message containing a MAC or a digital signature.
    /// </summary>
    [IsoId("_sO3hxzWBEeODSIIQsYYKhw")]
    [Description(@"Trailer of the message containing a MAC or a digital signature.")]
    [DataMember(Name="SctyTrlr")]
    [XmlElement(ElementName="SctyTrlr")]
    [Required]
    public required ContentInformationType9 SecurityTrailer { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="ManagementPlanReplacementV03Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public ManagementPlanReplacementV03Document ToDocument()
    {
        return new ManagementPlanReplacementV03Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="ManagementPlanReplacementV03"/>.
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
