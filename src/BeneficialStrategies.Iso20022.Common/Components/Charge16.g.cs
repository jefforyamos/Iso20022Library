﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Charge16.  ISO2002 ID# _RuTS79p-Ed-ak6NoX_4Aeg_758291100.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
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
/// Amount of money associated with a service.
/// </summary>
[IsoId("_RuTS79p-Ed-ak6NoX_4Aeg_758291100")]
[DisplayName("Charge")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Charge16
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Charge16 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Charge16( ChargeType10Code reqType,System.String reqExtendedType,System.Decimal reqAmount,System.Decimal reqRate )
    {
        Type = reqType;
        ExtendedType = reqExtendedType;
        Amount = reqAmount;
        Rate = reqRate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of service for which a charge is asked or paid.
    /// </summary>
    [IsoId("_RudD4Np-Ed-ak6NoX_4Aeg_758291507")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ChargeType10Code Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ChargeType10Code Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ChargeType10Code Type { get; init; } 
    #else
    public ChargeType10Code Type { get; set; } 
    #endif
    
    /// <summary>
    /// Type of service for which a charge is asked or paid.
    /// </summary>
    [IsoId("_RudD4dp-Ed-ak6NoX_4Aeg_758291542")]
    [DisplayName("Extended Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtndedTp")]
    #endif
    [IsoXmlTag("XtndedTp")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoExtended350Code ExtendedType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ExtendedType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ExtendedType { get; init; } 
    #else
    public System.String ExtendedType { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money asked or paid for the charge.
    /// </summary>
    [IsoId("_RudD4tp-Ed-ak6NoX_4Aeg_758291567")]
    [DisplayName("Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Amt")]
    #endif
    [IsoXmlTag("Amt")]
    [IsoSimpleType(IsoSimpleType.ActiveCurrencyAnd13DecimalAmount)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoActiveCurrencyAnd13DecimalAmount Amount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.Decimal Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal Amount { get; init; } 
    #else
    public System.Decimal Amount { get; set; } 
    #endif
    
    /// <summary>
    /// Rate used to calculate the amount of the charge or fee.
    /// </summary>
    [IsoId("_RudD49p-Ed-ak6NoX_4Aeg_758291584")]
    [DisplayName("Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rate")]
    #endif
    [IsoXmlTag("Rate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoPercentageRate Rate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.Decimal Rate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal Rate { get; init; } 
    #else
    public System.Decimal Rate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
