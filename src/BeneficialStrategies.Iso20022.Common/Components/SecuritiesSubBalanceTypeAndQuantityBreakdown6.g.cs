﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SecuritiesSubBalanceTypeAndQuantityBreakdown6.  ISO2002 ID# _cadPUTi8Eeydid5dcNPKvg.
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
/// Quantity breakdown information for a specific securities balance.
/// </summary>
[IsoId("_cadPUTi8Eeydid5dcNPKvg")]
[DisplayName("Securities Sub Balance Type And Quantity Breakdown")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecuritiesSubBalanceTypeAndQuantityBreakdown6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SecuritiesSubBalanceTypeAndQuantityBreakdown6 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SecuritiesSubBalanceTypeAndQuantityBreakdown6( SecuritiesBalanceType8Choice_ reqType )
    {
        Type = reqType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the securities sub balance type indicator (example restriction type for a market infrastructure).
    /// </summary>
    [IsoId("_cadPUzi8Eeydid5dcNPKvg")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecuritiesBalanceType8Choice_ Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecuritiesBalanceType8Choice_ Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesBalanceType8Choice_ Type { get; init; } 
    #else
    public SecuritiesBalanceType8Choice_ Type { get; set; } 
    #endif
    
    /// <summary>
    /// Breakdown of a quantity into lots such as tax lots, instrument series.
    /// </summary>
    [IsoId("_cadPVTi8Eeydid5dcNPKvg")]
    [DisplayName("Quantity Breakdown")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="QtyBrkdwn")]
    #endif
    [IsoXmlTag("QtyBrkdwn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public QuantityBreakdown65? QuantityBreakdown { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QuantityBreakdown65? QuantityBreakdown { get; init; } 
    #else
    public QuantityBreakdown65? QuantityBreakdown { get; set; } 
    #endif
    
    
    #nullable disable
    
}
