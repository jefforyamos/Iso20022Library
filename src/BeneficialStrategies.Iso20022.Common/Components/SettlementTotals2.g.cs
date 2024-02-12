﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SettlementTotals2.  ISO2002 ID# _ciULEZMnEeuleeHpFMMhmQ.
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
/// Settlement totals or the report.
/// </summary>
[IsoId("_ciULEZMnEeuleeHpFMMhmQ")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Settlement Totals")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SettlementTotals2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Settlement totals for the acquirer.
    /// </summary>
    [IsoId("_cpvBsZMnEeuleeHpFMMhmQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Acquirer Totals")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementCategoryTotal2? AcquirerTotals { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementCategoryTotal2? AcquirerTotals { get; init; } 
    #else
    public SettlementCategoryTotal2? AcquirerTotals { get; set; } 
    #endif
    
    /// <summary>
    /// Settlement totals for the issuer.
    /// </summary>
    [IsoId("_cpvBs5MnEeuleeHpFMMhmQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Issuer Totals")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementCategoryTotal2? IssuerTotals { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementCategoryTotal2? IssuerTotals { get; init; } 
    #else
    public SettlementCategoryTotal2? IssuerTotals { get; set; } 
    #endif
    
    /// <summary>
    /// Other settlement totals.
    /// </summary>
    [IsoId("_cpvBtZMnEeuleeHpFMMhmQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Other Totals")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementCategoryTotal2? OtherTotals { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementCategoryTotal2? OtherTotals { get; init; } 
    #else
    public SettlementCategoryTotal2? OtherTotals { get; set; } 
    #endif
    
    /// <summary>
    /// Total amount settled.
    /// </summary>
    [IsoId("_cpvBt5MnEeuleeHpFMMhmQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Total Settlement Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementCategoryTotal2? TotalSettlementAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementCategoryTotal2? TotalSettlementAmount { get; init; } 
    #else
    public SettlementCategoryTotal2? TotalSettlementAmount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
