﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for CurrencyControlStatusAdviceV02.  ISO2002 ID# _bf9SA22PEei3KuUgpx7Xcw.
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


namespace BeneficialStrategies.Iso20022.auth;

/// <summary>
/// This record is an implementation of the auth.027.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The CurrencyControlStatusAdvice message is sent by either the reporting party (respectively the registration agent) or the registration agent (respectively the reporting party) to provide a status advice on a previously sent currency control message.
/// 
/// Usage: 
/// The message may be sent in response to requests on the registration of the currency control contract, supporting document or on the payment regulatory information notification.
/// </summary>
[Description(@"The CurrencyControlStatusAdvice message is sent by either the reporting party (respectively the registration agent) or the registration agent (respectively the reporting party) to provide a status advice on a previously sent currency control message.||Usage: |The message may be sent in response to requests on the registration of the currency control contract, supporting document or on the payment regulatory information notification.")]
[IsoId("_bf9SA22PEei3KuUgpx7Xcw")]
[DisplayName("Currency Control Status Advice V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CurrencyControlStatusAdviceV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "auth.027.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CcyCtrlStsAdvc";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.027.001.02";
    
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
    /// Constructs a CurrencyControlStatusAdviceV02 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CurrencyControlStatusAdviceV02( CurrencyControlHeader6 reqGroupHeader,CurrencyControlGroupStatus2 reqGroupStatus )
    {
        GroupHeader = reqGroupHeader;
        GroupStatus = reqGroupStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Characteristics shared by all individual items included in the message.
    /// </summary>
    [IsoId("_bf9SBW2PEei3KuUgpx7Xcw")]
    [DisplayName("Group Header")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GrpHdr")]
    #endif
    [IsoXmlTag("GrpHdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CurrencyControlHeader6 GroupHeader { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CurrencyControlHeader6 GroupHeader { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyControlHeader6 GroupHeader { get; init; } 
    #else
    public CurrencyControlHeader6 GroupHeader { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the group status for the global message.
    /// </summary>
    [IsoId("_bf9SB22PEei3KuUgpx7Xcw")]
    [DisplayName("Group Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GrpSts")]
    #endif
    [IsoXmlTag("GrpSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CurrencyControlGroupStatus2 GroupStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CurrencyControlGroupStatus2 GroupStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyControlGroupStatus2 GroupStatus { get; init; } 
    #else
    public CurrencyControlGroupStatus2 GroupStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the status of the package in the message, which may contain the individual records.
    /// </summary>
    [IsoId("_bf9SCW2PEei3KuUgpx7Xcw")]
    [DisplayName("Package Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PackgSts")]
    #endif
    [IsoXmlTag("PackgSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyControlPackageStatus2? PackageStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyControlPackageStatus2? PackageStatus { get; init; } 
    #else
    public CurrencyControlPackageStatus2? PackageStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_bf9SC22PEei3KuUgpx7Xcw")]
    [DisplayName("Supplementary Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SplmtryData")]
    #endif
    [IsoXmlTag("SplmtryData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SupplementaryData1? SupplementaryData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SupplementaryData1? SupplementaryData { get; init; } 
    #else
    public SupplementaryData1? SupplementaryData { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since CurrencyControlStatusAdviceV02Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to CurrencyControlStatusAdviceV02.

