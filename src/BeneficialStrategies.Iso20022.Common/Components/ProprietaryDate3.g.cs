﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ProprietaryDate3.  ISO2002 ID# _rtZ5466OEeexrtTFgmVD3Q.
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
/// Set of elements used to identify a proprietary date.
/// </summary>
[IsoId("_rtZ5466OEeexrtTFgmVD3Q")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Proprietary Date")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ProprietaryDate3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ProprietaryDate3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ProprietaryDate3( System.String reqType,DateAndDateTime2Choice_ reqDate )
    {
        Type = reqType;
        Date = reqDate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the type of date.
    /// </summary>
    [IsoId("_r2LbU66OEeexrtTFgmVD3Q")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Type")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.String Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Type { get; init; } 
    #else
    public System.String Type { get; set; } 
    #endif
    
    /// <summary>
    /// Date in ISO format.
    /// </summary>
    [IsoId("_r2LbVa6OEeexrtTFgmVD3Q")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Date")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DateAndDateTime2Choice_ Date { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public DateAndDateTime2Choice_ Date { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTime2Choice_ Date { get; init; } 
    #else
    public DateAndDateTime2Choice_ Date { get; set; } 
    #endif
    
    
    #nullable disable
    
}
