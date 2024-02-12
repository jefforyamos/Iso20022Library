﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ATMPINManagementResponse2.  ISO2002 ID# __IPYsa4aEeW_TaP-ygI0SQ.
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
/// Information related to the response of an ATM PIN Management from an ATM manager.
/// </summary>
[IsoId("__IPYsa4aEeW_TaP-ygI0SQ")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("ATMPIN Management Response")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ATMPINManagementResponse2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ATMPINManagementResponse2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ATMPINManagementResponse2( ATMEnvironment12 reqEnvironment,ATMContext17 reqContext,ATMTransaction22 reqTransaction )
    {
        Environment = reqEnvironment;
        Context = reqContext;
        Transaction = reqTransaction;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Environment of the PIN management transaction.
    /// </summary>
    [IsoId("__S-CAa4aEeW_TaP-ygI0SQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Environment")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ATMEnvironment12 Environment { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public ATMEnvironment12 Environment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMEnvironment12 Environment { get; init; } 
    #else
    public ATMEnvironment12 Environment { get; set; } 
    #endif
    
    /// <summary>
    /// Context in which the transaction is performed.
    /// </summary>
    [IsoId("__S-CA64aEeW_TaP-ygI0SQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Context")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ATMContext17 Context { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public ATMContext17 Context { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMContext17 Context { get; init; } 
    #else
    public ATMContext17 Context { get; set; } 
    #endif
    
    /// <summary>
    /// Response to the PIN management transaction.
    /// </summary>
    [IsoId("__S-CBa4aEeW_TaP-ygI0SQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Transaction")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ATMTransaction22 Transaction { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public ATMTransaction22 Transaction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMTransaction22 Transaction { get; init; } 
    #else
    public ATMTransaction22 Transaction { get; set; } 
    #endif
    
    
    #nullable disable
    
}
