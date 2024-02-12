﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ClearingBatchData1.  ISO2002 ID# _MCJ34FA6EeedyPuM0kK2EQ.
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
/// Clearing data at batch level. Allows clearing in different currencies.
/// </summary>
[IsoId("_MCJ34FA6EeedyPuM0kK2EQ")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Clearing Batch Data")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ClearingBatchData1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ClearingBatchData1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ClearingBatchData1( ClearingMethod2Code reqClearingMethod )
    {
        ClearingMethod = reqClearingMethod;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of clearing method used.
    /// </summary>
    [IsoId("_aETkAFA6EeedyPuM0kK2EQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Clearing Method")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ClearingMethod2Code ClearingMethod { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public ClearingMethod2Code ClearingMethod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ClearingMethod2Code ClearingMethod { get; init; } 
    #else
    public ClearingMethod2Code ClearingMethod { get; set; } 
    #endif
    
    /// <summary>
    /// Other type of clearing method.
    /// </summary>
    [IsoId("_6cTJkFA7EeedyPuM0kK2EQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Other Clearing Method")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OtherClearingMethod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OtherClearingMethod { get; init; } 
    #else
    public System.String? OtherClearingMethod { get; set; } 
    #endif
    
    /// <summary>
    /// Level of priority of clearing.
    /// </summary>
    [IsoId("__8ATgFA7EeedyPuM0kK2EQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Clearing Priority")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ClearingPriority { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ClearingPriority { get; init; } 
    #else
    public System.String? ClearingPriority { get; set; } 
    #endif
    
    /// <summary>
    /// Date of clearing.
    /// </summary>
    [IsoId("_Fof8QFA8EeedyPuM0kK2EQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Clearing Date")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? ClearingDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? ClearingDate { get; init; } 
    #else
    public System.DateOnly? ClearingDate { get; set; } 
    #endif
    
    /// <summary>
    /// Clearing totals of the batch file.
    /// </summary>
    [IsoId("_KmAioFA9EeedyPuM0kK2EQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Clearing Totals")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ClearingTotals1? ClearingTotals { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ClearingTotals1? ClearingTotals { get; init; } 
    #else
    public ClearingTotals1? ClearingTotals { get; set; } 
    #endif
    
    /// <summary>
    /// Interchange fee.
    /// </summary>
    [IsoId("_S7N6EFA9EeedyPuM0kK2EQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Interchange Fee")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Amount14? InterchangeFee { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Amount14? InterchangeFee { get; init; } 
    #else
    public Amount14? InterchangeFee { get; set; } 
    #endif
    
    /// <summary>
    /// Fee of the agent.
    /// </summary>
    [IsoId("_XEn_cFA9EeedyPuM0kK2EQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Agent Fee")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Amount14? AgentFee { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Amount14? AgentFee { get; init; } 
    #else
    public Amount14? AgentFee { get; set; } 
    #endif
    
    
    #nullable disable
    
}
