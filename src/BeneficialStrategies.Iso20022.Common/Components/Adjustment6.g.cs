﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Adjustment6.  ISO2002 ID# _tcBQkRrWEeOVR9VN6fAMUg.
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
/// Modification on the value of goods and / or services. For example: rebate, discount, surcharge.
/// </summary>
[IsoId("_tcBQkRrWEeOVR9VN6fAMUg")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Adjustment")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Adjustment6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Adjustment6 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Adjustment6( AdjustmentType1Choice_ reqType,AdjustmentDirection1Code reqDirection,System.Decimal reqAmount )
    {
        Type = reqType;
        Direction = reqDirection;
        Amount = reqAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the type of adjustment.
    /// </summary>
    [IsoId("_hYxEoBrXEeOVR9VN6fAMUg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Type")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AdjustmentType1Choice_ Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public AdjustmentType1Choice_ Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdjustmentType1Choice_ Type { get; init; } 
    #else
    public AdjustmentType1Choice_ Type { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the adjustment must be subtracted or added to the total amount.
    /// </summary>
    [IsoId("_tzt-5xrWEeOVR9VN6fAMUg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Direction")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AdjustmentDirection1Code Direction { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public AdjustmentDirection1Code Direction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdjustmentDirection1Code Direction { get; init; } 
    #else
    public AdjustmentDirection1Code Direction { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the monetary amount of the adjustment.
    /// </summary>
    [IsoId("_tzt-6RrWEeOVR9VN6fAMUg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoCurrencyAndAmount Amount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.Decimal Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal Amount { get; init; } 
    #else
    public System.Decimal Amount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
