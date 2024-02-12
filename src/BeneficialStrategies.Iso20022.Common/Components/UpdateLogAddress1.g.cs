﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for UpdateLogAddress1.  ISO2002 ID# _NQ5xgGjSEeiRg5NzP0jkQg.
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
/// Specifies the old and new values for an address.
/// </summary>
[IsoId("_NQ5xgGjSEeiRg5NzP0jkQg")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Update Log Address")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record UpdateLogAddress1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a UpdateLogAddress1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public UpdateLogAddress1( PostalAddress25 reqOld,PostalAddress25 reqNew )
    {
        Old = reqOld;
        New = reqNew;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Old value before change
    /// </summary>
    [IsoId("_U5BZcGjSEeiRg5NzP0jkQg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Old")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PostalAddress25 Old { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public PostalAddress25 Old { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PostalAddress25 Old { get; init; } 
    #else
    public PostalAddress25 Old { get; set; } 
    #endif
    
    /// <summary>
    /// New value after change
    /// </summary>
    [IsoId("_SjDnoGjSEeiRg5NzP0jkQg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("New")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PostalAddress25 New { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public PostalAddress25 New { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PostalAddress25 New { get; init; } 
    #else
    public PostalAddress25 New { get; set; } 
    #endif
    
    
    #nullable disable
    
}
