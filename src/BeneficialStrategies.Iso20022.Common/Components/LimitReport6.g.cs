﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for LimitReport6.  ISO2002 ID# _RDVxR5lhEeeE1Ya-LgRsuQ.
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
/// Reports either on the risk management limit or on a business error.
/// </summary>
[IsoId("_RDVxR5lhEeeE1Ya-LgRsuQ")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Limit Report")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record LimitReport6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a LimitReport6 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public LimitReport6( LimitIdentification1 reqLimitIdentification,LimitOrError3Choice_ reqLimitOrError )
    {
        LimitIdentification = reqLimitIdentification;
        LimitOrError = reqLimitOrError;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the limit on which information is requested.
    /// </summary>
    [IsoId("_RRErQ5lhEeeE1Ya-LgRsuQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Limit Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required LimitIdentification1 LimitIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public LimitIdentification1 LimitIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LimitIdentification1 LimitIdentification { get; init; } 
    #else
    public LimitIdentification1 LimitIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Requested information on the limit or business error report when information has not been found.
    /// </summary>
    [IsoId("_RRErRZlhEeeE1Ya-LgRsuQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Limit Or Error")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required LimitOrError3Choice_ LimitOrError { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public LimitOrError3Choice_ LimitOrError { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LimitOrError3Choice_ LimitOrError { get; init; } 
    #else
    public LimitOrError3Choice_ LimitOrError { get; set; } 
    #endif
    
    
    #nullable disable
    
}
