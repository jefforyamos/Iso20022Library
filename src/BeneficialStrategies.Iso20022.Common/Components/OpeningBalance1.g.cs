﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for OpeningBalance1.  ISO2002 ID# _R9Wbitp-Ed-ak6NoX_4Aeg_991113889.
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
/// Opening balance for the statement period (first opening balance) or of this page (intermediary opening balance).
/// </summary>
[IsoId("_R9Wbitp-Ed-ak6NoX_4Aeg_991113889")]
[DisplayName("Opening Balance")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record OpeningBalance1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a OpeningBalance1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public OpeningBalance1( ShortLong1Code reqShortLongIndicator,OpeningBalance1Choice_ reqOpeningBalance )
    {
        ShortLongIndicator = reqShortLongIndicator;
        OpeningBalance = reqOpeningBalance;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Indication that the position is short or long.
    /// </summary>
    [IsoId("_R9gMgNp-Ed-ak6NoX_4Aeg_-2142989493")]
    [DisplayName("Short Long Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ShrtLngInd")]
    #endif
    [IsoXmlTag("ShrtLngInd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ShortLong1Code ShortLongIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ShortLong1Code ShortLongIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ShortLong1Code ShortLongIndicator { get; init; } 
    #else
    public ShortLong1Code ShortLongIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Opening balance for the statement period (first opening balance) or of this page (intermediary opening balance).
    /// </summary>
    [IsoId("_R9gMgdp-Ed-ak6NoX_4Aeg_-2058025502")]
    [DisplayName("Opening Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OpngBal")]
    #endif
    [IsoXmlTag("OpngBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required OpeningBalance1Choice_ OpeningBalance { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required OpeningBalance1Choice_ OpeningBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OpeningBalance1Choice_ OpeningBalance { get; init; } 
    #else
    public OpeningBalance1Choice_ OpeningBalance { get; set; } 
    #endif
    
    
    #nullable disable
    
}
