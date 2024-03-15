﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for ManagementPlanReplacementV06.  ISO2002 ID# _CzZYcbC8EeamYaqfhG1ZuA.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif


namespace BeneficialStrategies.Iso20022.catm;

/// <summary>
/// This record is an implementation of the catm.002.001.06 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Terminal maintenance actions to be performed by a point of interaction (POI).
/// </summary>
[Description(@"Terminal maintenance actions to be performed by a point of interaction (POI).")]
[IsoId("_CzZYcbC8EeamYaqfhG1ZuA")]
[DisplayName("Management Plan Replacement V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ManagementPlanReplacementV06 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "catm.002.001.06";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MgmtPlanRplcmnt";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:catm.002.001.06";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ManagementPlanReplacementV06 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ManagementPlanReplacementV06( Header27 reqHeader,ManagementPlan6 reqManagementPlan )
    {
        Header = reqHeader;
        ManagementPlan = reqManagementPlan;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Set of characteristics related to the transfer of the management plan.
    /// </summary>
    [IsoId("_CzZYdbC8EeamYaqfhG1ZuA")]
    [DisplayName("Header")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Hdr")]
    #endif
    [IsoXmlTag("Hdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Header27 Header { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Header27 Header { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Header27 Header { get; init; } 
    #else
    public Header27 Header { get; set; } 
    #endif
    
    /// <summary>
    /// Sequence of terminal maintenance actions to be performed by a point of interaction (POI).
    /// </summary>
    [IsoId("_CzZYd7C8EeamYaqfhG1ZuA")]
    [DisplayName("Management Plan")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MgmtPlan")]
    #endif
    [IsoXmlTag("MgmtPlan")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ManagementPlan6 ManagementPlan { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ManagementPlan6 ManagementPlan { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ManagementPlan6 ManagementPlan { get; init; } 
    #else
    public ManagementPlan6 ManagementPlan { get; set; } 
    #endif
    
    /// <summary>
    /// Trailer of the message containing a MAC or a digital signature.
    /// </summary>
    [IsoId("_CzZYebC8EeamYaqfhG1ZuA")]
    [DisplayName("Security Trailer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctyTrlr")]
    #endif
    [IsoXmlTag("SctyTrlr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContentInformationType12? SecurityTrailer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContentInformationType12? SecurityTrailer { get; init; } 
    #else
    public ContentInformationType12? SecurityTrailer { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since ManagementPlanReplacementV06Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ManagementPlanReplacementV06.

