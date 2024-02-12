﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AddendumData4.  ISO2002 ID# _D4FAcR1UEey8XKHwKquEQw.
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
/// Addendum data structure is applicable to certain merchant verticals that require industry-specific data within transaction messages. 
/// </summary>
[IsoId("_D4FAcR1UEey8XKHwKquEQw")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Addendum Data")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AddendumData4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Fleet data pertaining to the payment transaction.
    /// </summary>
    [IsoId("_D-S9MR1UEey8XKHwKquEQw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Fleet")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FleetData5? Fleet { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FleetData5? Fleet { get; init; } 
    #else
    public FleetData5? Fleet { get; set; } 
    #endif
    
    /// <summary>
    /// Data exclusively related to a card issuer financial loan of the payment transaction, or instalment.
    /// </summary>
    [IsoId("_sI2vkSX6Eeym0KcvJF9aDQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Instalment")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Instalment4? Instalment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Instalment4? Instalment { get; init; } 
    #else
    public Instalment4? Instalment { get; set; } 
    #endif
    
    /// <summary>
    /// Contains additional data for the addendum.
    /// </summary>
    [IsoId("_D-S9Mx1UEey8XKHwKquEQw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Additional Data")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalData1? AdditionalData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalData1? AdditionalData { get; init; } 
    #else
    public AdditionalData1? AdditionalData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
