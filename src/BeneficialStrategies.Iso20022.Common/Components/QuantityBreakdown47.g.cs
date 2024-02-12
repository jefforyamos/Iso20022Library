﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for QuantityBreakdown47.  ISO2002 ID# _IJefIbPwEeelzbgsFa3sqQ.
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
/// Details of breakdown of a quantity.
/// </summary>
[IsoId("_IJefIbPwEeelzbgsFa3sqQ")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Quantity Breakdown")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record QuantityBreakdown47
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification, for tax purposes, of a lot of identical securities that are bought at a certain date and at a certain price.
    /// </summary>
    [IsoId("_IZZKc7PwEeelzbgsFa3sqQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Lot Number")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification37? LotNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification37? LotNumber { get; init; } 
    #else
    public GenericIdentification37? LotNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of financial instruments that is part of the lot described.
    /// </summary>
    [IsoId("_IZZKe7PwEeelzbgsFa3sqQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Lot Quantity")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity1Choice_? LotQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity1Choice_? LotQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity1Choice_? LotQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the securities sub balance type indicator (example restriction type for a market infrastructure).
    /// </summary>
    [IsoId("_IZZKg7PwEeelzbgsFa3sqQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Securities Sub Balance Type")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification30? SecuritiesSubBalanceType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification30? SecuritiesSubBalanceType { get; init; } 
    #else
    public GenericIdentification30? SecuritiesSubBalanceType { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time at which the lot was purchased.
    /// </summary>
    [IsoId("_IZZKhbPwEeelzbgsFa3sqQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Lot Date Time")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTime2Choice_? LotDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTime2Choice_? LotDateTime { get; init; } 
    #else
    public DateAndDateTime2Choice_? LotDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Price at which the lot was purchased.
    /// </summary>
    [IsoId("_IZZKjbPwEeelzbgsFa3sqQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Lot Price")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Price7? LotPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Price7? LotPrice { get; init; } 
    #else
    public Price7? LotPrice { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the type of price and information about the price.
    /// </summary>
    [IsoId("_IZZKlbPwEeelzbgsFa3sqQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Type Of Price")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TypeOfPrice29Choice_? TypeOfPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TypeOfPrice29Choice_? TypeOfPrice { get; init; } 
    #else
    public TypeOfPrice29Choice_? TypeOfPrice { get; set; } 
    #endif
    
    
    #nullable disable
    
}
