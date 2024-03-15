﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Tax32.  ISO2002 ID# _Vu_qkTh9EeaH-93K5JKmzw.
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
/// Tax related to an investment fund order.
/// </summary>
[IsoId("_Vu_qkTh9EeaH-93K5JKmzw")]
[DisplayName("Tax")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Tax32
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Tax32 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Tax32( TaxType3Choice_ reqType,System.String reqExemptionIndicator )
    {
        Type = reqType;
        ExemptionIndicator = reqExemptionIndicator;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of tax applied.
    /// </summary>
    [IsoId("_WHZjhzh9EeaH-93K5JKmzw")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TaxType3Choice_ Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TaxType3Choice_ Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TaxType3Choice_ Type { get; init; } 
    #else
    public TaxType3Choice_ Type { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money resulting from the calculation of the tax. This amount is provided for information only.
    /// </summary>
    [IsoId("_WHZjiTh9EeaH-93K5JKmzw")]
    [DisplayName("Informative Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InftvAmt")]
    #endif
    [IsoXmlTag("InftvAmt")]
    [IsoSimpleType(IsoSimpleType.ActiveCurrencyAndAmount)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveCurrencyAndAmount? InformativeAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? InformativeAmount { get; init; } 
    #else
    public System.Decimal? InformativeAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Rate used to calculate the tax. This rate is provided for information only.
    /// </summary>
    [IsoId("_WHZjizh9EeaH-93K5JKmzw")]
    [DisplayName("Informative Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InftvRate")]
    #endif
    [IsoXmlTag("InftvRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? InformativeRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? InformativeRate { get; init; } 
    #else
    public System.Decimal? InformativeRate { get; set; } 
    #endif
    
    /// <summary>
    /// Country where the tax is due.
    /// </summary>
    [IsoId("_WHZjjTh9EeaH-93K5JKmzw")]
    [DisplayName("Country")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ctry")]
    #endif
    [IsoXmlTag("Ctry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CountryCode? Country { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? Country { get; init; } 
    #else
    public string? Country { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether a tax exemption applies.
    /// </summary>
    [IsoId("_WHZjkTh9EeaH-93K5JKmzw")]
    [DisplayName("Exemption Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XmptnInd")]
    #endif
    [IsoXmlTag("XmptnInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator ExemptionIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ExemptionIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ExemptionIndicator { get; init; } 
    #else
    public System.String ExemptionIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Reason for the tax exemption.
    /// </summary>
    [IsoId("_WHZjkzh9EeaH-93K5JKmzw")]
    [DisplayName("Exemption Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XmptnRsn")]
    #endif
    [IsoXmlTag("XmptnRsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ExemptionReason1Choice_? ExemptionReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExemptionReason1Choice_? ExemptionReason { get; init; } 
    #else
    public ExemptionReason1Choice_? ExemptionReason { get; set; } 
    #endif
    
    /// <summary>
    /// Party that receives the tax. The recipient of, and the party entitled to, the tax may be two different parties.
    /// </summary>
    [IsoId("_sK5AMXTTEea79aegl3yVYg")]
    [DisplayName("Recipient Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcptId")]
    #endif
    [IsoXmlTag("RcptId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification113? RecipientIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification113? RecipientIdentification { get; init; } 
    #else
    public PartyIdentification113? RecipientIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Information used to calculate the tax.
    /// </summary>
    [IsoId("_Gp-WwTh-EeaH-93K5JKmzw")]
    [DisplayName("Tax Calculation Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxClctnDtls")]
    #endif
    [IsoXmlTag("TaxClctnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TaxCalculationInformation10? TaxCalculationDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TaxCalculationInformation10? TaxCalculationDetails { get; init; } 
    #else
    public TaxCalculationInformation10? TaxCalculationDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
