﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SecurityReuseData1.  ISO2002 ID# __pEK0IxmEeap1-whlAlpOw.
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
/// Provides the details of the security pledged as collateral.
/// </summary>
[IsoId("__pEK0IxmEeap1-whlAlpOw")]
[DisplayName("Security Reuse Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecurityReuseData1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SecurityReuseData1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SecurityReuseData1( System.String reqISIN,ReuseValue1Choice_ reqReuseValue )
    {
        ISIN = reqISIN;
        ReuseValue = reqReuseValue;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifier of the security used as collateral.
    /// </summary>
    [IsoId("_IiLgkIxnEeap1-whlAlpOw")]
    [DisplayName("ISIN")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ISIN")]
    #endif
    [IsoXmlTag("ISIN")]
    [IsoSimpleType(IsoSimpleType.ISINOct2015Identifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISINOct2015Identifier ISIN { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ISIN { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ISIN { get; init; } 
    #else
    public System.String ISIN { get; set; } 
    #endif
    
    /// <summary>
    /// Indication whether reused value is actual or estimated.
    /// </summary>
    [IsoId("_JXFIQIxnEeap1-whlAlpOw")]
    [DisplayName("Reuse Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReuseVal")]
    #endif
    [IsoXmlTag("ReuseVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ReuseValue1Choice_ ReuseValue { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ReuseValue1Choice_ ReuseValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReuseValue1Choice_ ReuseValue { get; init; } 
    #else
    public ReuseValue1Choice_ ReuseValue { get; set; } 
    #endif
    
    
    #nullable disable
    
}
