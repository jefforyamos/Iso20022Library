﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SecuritiesSubBalanceTypeAndQuantityBreakdown3.  ISO2002 ID# _p3f1sTnsEeWfSKvvZlhRKg.
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
[IsoId("_p3f1sTnsEeWfSKvvZlhRKg")]
[DisplayName("Securities Sub Balance Type And Quantity Breakdown")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecuritiesSubBalanceTypeAndQuantityBreakdown3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SecuritiesSubBalanceTypeAndQuantityBreakdown3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SecuritiesSubBalanceTypeAndQuantityBreakdown3( SecuritiesBalanceType6Choice_ reqType )
    {
        Type = reqType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the securities sub balance type indicator (example restriction type for a market infrastructure).
    /// </summary>
    [IsoId("_qYOkMTnsEeWfSKvvZlhRKg")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecuritiesBalanceType6Choice_ Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecuritiesBalanceType6Choice_ Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesBalanceType6Choice_ Type { get; init; } 
    #else
    public SecuritiesBalanceType6Choice_ Type { get; set; } 
    #endif
    
    /// <summary>
    /// Breakdown of a quantity into lots such as tax lots, instrument series.
    /// </summary>
    [IsoId("_qYOkMznsEeWfSKvvZlhRKg")]
    [DisplayName("Quantity Breakdown")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="QtyBrkdwn")]
    #endif
    [IsoXmlTag("QtyBrkdwn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public QuantityBreakdown32? QuantityBreakdown { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QuantityBreakdown32? QuantityBreakdown { get; init; } 
    #else
    public QuantityBreakdown32? QuantityBreakdown { get; set; } 
    #endif
    
    
    #nullable disable
    
}
