﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for InstructedBalance15.  ISO2002 ID# _pUExkx9QEeuFz_FaCzCLgQ.
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
[IsoId("_pUExkx9QEeuFz_FaCzCLgQ")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Instructed Balance")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InstructedBalance15
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a InstructedBalance15 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public InstructedBalance15( BalanceFormat7Choice_ reqTotalInstructedBalance )
    {
        TotalInstructedBalance = reqTotalInstructedBalance;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides information about the total instructed balance.
    /// </summary>
    [IsoId("_pUExlR9QEeuFz_FaCzCLgQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Total Instructed Balance")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BalanceFormat7Choice_ TotalInstructedBalance { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public BalanceFormat7Choice_ TotalInstructedBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BalanceFormat7Choice_ TotalInstructedBalance { get; init; } 
    #else
    public BalanceFormat7Choice_ TotalInstructedBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Daily total of all accepted instructions for given day.  Cover protect instructions will be included in this total balance.
    /// </summary>
    [IsoId("_pUExlx9QEeuFz_FaCzCLgQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Total Accepted Instruction Balance")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SignedQuantityFormat9? TotalAcceptedInstructionBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SignedQuantityFormat9? TotalAcceptedInstructionBalance { get; init; } 
    #else
    public SignedQuantityFormat9? TotalAcceptedInstructionBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Daily total of cancelled instructions for a given day.
    /// </summary>
    [IsoId("_pUExmR9QEeuFz_FaCzCLgQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Total Cancelled Instruction Balance")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SignedQuantityFormat9? TotalCancelledInstructionBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SignedQuantityFormat9? TotalCancelledInstructionBalance { get; init; } 
    #else
    public SignedQuantityFormat9? TotalCancelledInstructionBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Daily total of pending instructions in pending status.  It includes cancel pending instructions.
    /// </summary>
    [IsoId("_pUExmx9QEeuFz_FaCzCLgQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Total Pending Instruction Balance")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SignedQuantityFormat9? TotalPendingInstructionBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SignedQuantityFormat9? TotalPendingInstructionBalance { get; init; } 
    #else
    public SignedQuantityFormat9? TotalPendingInstructionBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Daily total of rejected instructions.
    /// </summary>
    [IsoId("_pUExnR9QEeuFz_FaCzCLgQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Total Rejected Instruction Balance")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SignedQuantityFormat9? TotalRejectedInstructionBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SignedQuantityFormat9? TotalRejectedInstructionBalance { get; init; } 
    #else
    public SignedQuantityFormat9? TotalRejectedInstructionBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Daily total of all protect instructions sent in a given day.
    /// </summary>
    [IsoId("_pUExnx9QEeuFz_FaCzCLgQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Total Protect Instruction Balance")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SignedQuantityFormat9? TotalProtectInstructionBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SignedQuantityFormat9? TotalProtectInstructionBalance { get; init; } 
    #else
    public SignedQuantityFormat9? TotalProtectInstructionBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Provide instructed balance breakdown information per option.
    /// </summary>
    [IsoId("_pUExoR9QEeuFz_FaCzCLgQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Option Details")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InstructedCorporateActionOption16? OptionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InstructedCorporateActionOption16? OptionDetails { get; init; } 
    #else
    public InstructedCorporateActionOption16? OptionDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
