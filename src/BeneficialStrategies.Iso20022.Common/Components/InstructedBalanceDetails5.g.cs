﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for InstructedBalanceDetails5.  ISO2002 ID# _lHIu_Tq5EeWQ1Y7f8kds2A.
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
/// Provides information about total instructed balance.
/// </summary>
[IsoId("_lHIu_Tq5EeWQ1Y7f8kds2A")]
[DisplayName("Instructed Balance Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InstructedBalanceDetails5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a InstructedBalanceDetails5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public InstructedBalanceDetails5( BalanceFormat5Choice_ reqTotalInstructedBalance )
    {
        TotalInstructedBalance = reqTotalInstructedBalance;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides information about the total instructed balance.
    /// </summary>
    [IsoId("_lTehwTq5EeWQ1Y7f8kds2A")]
    [DisplayName("Total Instructed Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlInstdBal")]
    #endif
    [IsoXmlTag("TtlInstdBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BalanceFormat5Choice_ TotalInstructedBalance { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BalanceFormat5Choice_ TotalInstructedBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BalanceFormat5Choice_ TotalInstructedBalance { get; init; } 
    #else
    public BalanceFormat5Choice_ TotalInstructedBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Provide instructed balance breakdown information per option.
    /// </summary>
    [IsoId("_lTehwzq5EeWQ1Y7f8kds2A")]
    [DisplayName("Option Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnDtls")]
    #endif
    [IsoXmlTag("OptnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InstructedCorporateActionOption6? OptionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InstructedCorporateActionOption6? OptionDetails { get; init; } 
    #else
    public InstructedCorporateActionOption6? OptionDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
