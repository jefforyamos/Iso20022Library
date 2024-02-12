﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CRSStatus4.  ISO2002 ID# _uRVacUNeEeamLdeYEZm56w.
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
/// Common Reporting Standard (CRS) status information.
/// </summary>
[IsoId("_uRVacUNeEeamLdeYEZm56w")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("CRS Status")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CRSStatus4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CRSStatus4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CRSStatus4( CRSStatus3Choice_ reqType )
    {
        Type = reqType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Common Reporting Standard (CRS) status.
    /// </summary>
    [IsoId("_uqe6QUNeEeamLdeYEZm56w")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Type")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CRSStatus3Choice_ Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public CRSStatus3Choice_ Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CRSStatus3Choice_ Type { get; init; } 
    #else
    public CRSStatus3Choice_ Type { get; set; } 
    #endif
    
    /// <summary>
    /// Source of the Common Reporting Standard (CRS) status.
    /// </summary>
    [IsoId("_uqe6Q0NeEeamLdeYEZm56w")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Source")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CRSSource1Choice_? Source { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CRSSource1Choice_? Source { get; init; } 
    #else
    public CRSSource1Choice_? Source { get; set; } 
    #endif
    
    /// <summary>
    /// Reporting country for the CRS status when there is an exception at the country level.
    /// </summary>
    [IsoId("_xl3u8Hi0EeaRm5xIK6nGuQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Exceptional Reporting Country")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CountryCode? ExceptionalReportingCountry { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? ExceptionalReportingCountry { get; init; } 
    #else
    public string? ExceptionalReportingCountry { get; set; } 
    #endif
    
    
    #nullable disable
    
}
