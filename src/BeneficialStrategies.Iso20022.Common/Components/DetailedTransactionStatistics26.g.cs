﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DetailedTransactionStatistics26.  ISO2002 ID# _rsDixVowEe23K4GXSpBSeg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about outstanding derivatives, outstanding derivatives with no margin and outstanding derivatives with outdated margin.
/// </summary>
[IsoId("_rsDixVowEe23K4GXSpBSeg")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Detailed Transaction Statistics")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DetailedTransactionStatistics26
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DetailedTransactionStatistics26 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DetailedTransactionStatistics26( System.UInt64 reqNumberOfOutstandingDerivatives,System.UInt64 reqNumberOfOutstandingDerivativesWithNoMarginInformation,System.UInt64 reqNumberOfOutstandingDerivativesWithOutdatedMarginInformation )
    {
        NumberOfOutstandingDerivatives = reqNumberOfOutstandingDerivatives;
        NumberOfOutstandingDerivativesWithNoMarginInformation = reqNumberOfOutstandingDerivativesWithNoMarginInformation;
        NumberOfOutstandingDerivativesWithOutdatedMarginInformation = reqNumberOfOutstandingDerivativesWithOutdatedMarginInformation;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Number of outstanding derivatives. 
    /// </summary>
    [IsoId("_rtPOgVowEe23K4GXSpBSeg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Number Of Outstanding Derivatives")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoNumber NumberOfOutstandingDerivatives { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.UInt64 NumberOfOutstandingDerivatives { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 NumberOfOutstandingDerivatives { get; init; } 
    #else
    public System.UInt64 NumberOfOutstandingDerivatives { get; set; } 
    #endif
    
    /// <summary>
    /// Number of outstanding derivatives with no margin information.
    /// </summary>
    [IsoId("_rtPOg1owEe23K4GXSpBSeg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Number Of Outstanding Derivatives With No Margin Information")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoNumber NumberOfOutstandingDerivativesWithNoMarginInformation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.UInt64 NumberOfOutstandingDerivativesWithNoMarginInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 NumberOfOutstandingDerivativesWithNoMarginInformation { get; init; } 
    #else
    public System.UInt64 NumberOfOutstandingDerivativesWithNoMarginInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Number of outstanding derivatives with outdated margin information.
    /// </summary>
    [IsoId("_rtPOhVowEe23K4GXSpBSeg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Number Of Outstanding Derivatives With Outdated Margin Information")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoNumber NumberOfOutstandingDerivativesWithOutdatedMarginInformation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.UInt64 NumberOfOutstandingDerivativesWithOutdatedMarginInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 NumberOfOutstandingDerivativesWithOutdatedMarginInformation { get; init; } 
    #else
    public System.UInt64 NumberOfOutstandingDerivativesWithOutdatedMarginInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Details of the outstanding derivatives for which no margin information has been reported, or the margin information that was reported is dated more than fourteen calendar days earlier than the day.
    /// </summary>
    [IsoId("_rtPOh1owEe23K4GXSpBSeg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Warnings")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    public MissingMarginData2? Warnings { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _rtPOh1owEe23K4GXSpBSeg
    
    
    #nullable disable
    
}
