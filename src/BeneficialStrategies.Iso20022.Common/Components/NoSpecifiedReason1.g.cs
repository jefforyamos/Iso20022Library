﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for NoSpecifiedReason1.  ISO2002 ID# _UakE19p-Ed-ak6NoX_4Aeg_-1550563657.
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
/// No specified reason available for the status.
/// </summary>
[IsoId("_UakE19p-Ed-ak6NoX_4Aeg_-1550563657")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("No Specified Reason")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record NoSpecifiedReason1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a NoSpecifiedReason1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public NoSpecifiedReason1( NoReasonCode reqNoSpecifiedReason )
    {
        NoSpecifiedReason = reqNoSpecifiedReason;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates that there is no reason available or to report.
    /// </summary>
    [IsoId("_UatOwNp-Ed-ak6NoX_4Aeg_137164408")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("No Specified Reason")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required NoReasonCode NoSpecifiedReason { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public NoReasonCode NoSpecifiedReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NoReasonCode NoSpecifiedReason { get; init; } 
    #else
    public NoReasonCode NoSpecifiedReason { get; set; } 
    #endif
    
    
    #nullable disable
    
}
