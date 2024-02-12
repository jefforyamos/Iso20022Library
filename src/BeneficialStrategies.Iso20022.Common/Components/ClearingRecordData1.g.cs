﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ClearingRecordData1.  ISO2002 ID# _U9pdIFBDEeedyPuM0kK2EQ.
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
/// Information used with financial types of messages when third-party clearing is involved.
/// </summary>
[IsoId("_U9pdIFBDEeedyPuM0kK2EQ")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Clearing Record Data")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ClearingRecordData1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ClearingRecordData1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ClearingRecordData1( ClearingMethod2Code reqClearingMethod )
    {
        ClearingMethod = reqClearingMethod;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Originator of the batch.
    /// </summary>
    [IsoId("_picW4FBDEeedyPuM0kK2EQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Originator")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Originator1? Originator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Originator1? Originator { get; init; } 
    #else
    public Originator1? Originator { get; set; } 
    #endif
    
    /// <summary>
    /// Institution, final destination of the batch.
    /// </summary>
    [IsoId("_7T93wFBDEeedyPuM0kK2EQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Destination")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Destination1? Destination { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Destination1? Destination { get; init; } 
    #else
    public Destination1? Destination { get; set; } 
    #endif
    
    /// <summary>
    /// Type of clearing of the transaction.
    /// </summary>
    [IsoId("_DUCssFBEEeedyPuM0kK2EQ")]
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
    [IsoId("_b1KSEFBEEeedyPuM0kK2EQ")]
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
    [IsoId("_hN3cIFBEEeedyPuM0kK2EQ")]
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
    [IsoId("_mnnIAFBEEeedyPuM0kK2EQ")]
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
    /// Net amount of clearing.
    /// </summary>
    [IsoId("_wBtD4FBEEeedyPuM0kK2EQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Clearing Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Amount14? ClearingAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Amount14? ClearingAmount { get; init; } 
    #else
    public Amount14? ClearingAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Interchange reimbursement fee.
    /// </summary>
    [IsoId("_15f9sFBEEeedyPuM0kK2EQ")]
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
    /// Fee pertaining to the agent.
    /// </summary>
    [IsoId("_8vflIFBEEeedyPuM0kK2EQ")]
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
    
    /// <summary>
    /// Other amounts involved in clearing.
    /// </summary>
    [IsoId("_PdT84FBKEeedyPuM0kK2EQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Other Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OtherAmount2? OtherAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OtherAmount2? OtherAmount { get; init; } 
    #else
    public OtherAmount2? OtherAmount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
