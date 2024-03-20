﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TaxCalculationInformation11.  ISO2002 ID# _oFnOEYjOEeeiYZ2e3mpBRA.
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
/// Information used to calculate a tax.
/// </summary>
[IsoId("_oFnOEYjOEeeiYZ2e3mpBRA")]
[DisplayName("Tax Calculation Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TaxCalculationInformation11
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TaxCalculationInformation11 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TaxCalculationInformation11( ActiveCurrencyAndAmount reqTaxableAmount )
    {
        TaxableAmount = reqTaxableAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Basis used to determine the capital gain or loss.
    /// </summary>
    [IsoId("_oUxrc4jOEeeiYZ2e3mpBRA")]
    [DisplayName("Basis")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Bsis")]
    #endif
    [IsoXmlTag("Bsis")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TaxBasis1Choice_? Basis { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TaxBasis1Choice_? Basis { get; init; } 
    #else
    public TaxBasis1Choice_? Basis { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money on which the tax is charged.
    /// </summary>
    [IsoId("_oUxrdYjOEeeiYZ2e3mpBRA")]
    [DisplayName("Taxable Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxblAmt")]
    #endif
    [IsoXmlTag("TaxblAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount TaxableAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount TaxableAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount TaxableAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount TaxableAmount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
