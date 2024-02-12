﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ErrorHandling3.  ISO2002 ID# _RY_xSdp-Ed-ak6NoX_4Aeg_-917396675.
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
/// Specifies the error resulting from the processing of a request.
/// </summary>
[IsoId("_RY_xSdp-Ed-ak6NoX_4Aeg_-917396675")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Error Handling")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ErrorHandling3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ErrorHandling3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ErrorHandling3( ErrorHandling1Choice_ reqError )
    {
        Error = reqError;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specification of the error, in coded or proprietary form.
    /// </summary>
    [IsoId("_RY_xStp-Ed-ak6NoX_4Aeg_-487033921")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Error")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ErrorHandling1Choice_ Error { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public ErrorHandling1Choice_ Error { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ErrorHandling1Choice_ Error { get; init; } 
    #else
    public ErrorHandling1Choice_ Error { get; set; } 
    #endif
    
    /// <summary>
    /// Specification of the error, in free format.
    /// </summary>
    [IsoId("_RZI7MNp-Ed-ak6NoX_4Aeg_-917396614")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Description")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? Description { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Description { get; init; } 
    #else
    public System.String? Description { get; set; } 
    #endif
    
    
    #nullable disable
    
}
