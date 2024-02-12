﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DetailedInstructionStatus1.  ISO2002 ID# _RWdaqtp-Ed-ak6NoX_4Aeg_1765622954.
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
/// Status applying to individual instructions of a MeetingInstruction.
/// </summary>
[IsoId("_RWdaqtp-Ed-ak6NoX_4Aeg_1765622954")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Detailed Instruction Status")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DetailedInstructionStatus1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DetailedInstructionStatus1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DetailedInstructionStatus1( System.String reqInstructionIdentification,InstructionStatus2Choice_ reqInstructionStatus )
    {
        InstructionIdentification = reqInstructionIdentification;
        InstructionStatus = reqInstructionStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the detailed instruction within an instruction message.
    /// </summary>
    [IsoId("_RWnLoNp-Ed-ak6NoX_4Aeg_-2110986462")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Instruction Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text InstructionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.String InstructionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String InstructionIdentification { get; init; } 
    #else
    public System.String InstructionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the safekeeping account.
    /// </summary>
    [IsoId("_RWnLodp-Ed-ak6NoX_4Aeg_1822881804")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Account Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? AccountIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AccountIdentification { get; init; } 
    #else
    public System.String? AccountIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the subaccount of the safekeeping account.
    /// </summary>
    [IsoId("_RWnLotp-Ed-ak6NoX_4Aeg_-2130380809")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Sub Account Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? SubAccountIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SubAccountIdentification { get; init; } 
    #else
    public System.String? SubAccountIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Status applying to individual instructions of a MeetingInstruction.
    /// </summary>
    [IsoId("_RWnLo9p-Ed-ak6NoX_4Aeg_1301124445")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Instruction Status")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InstructionStatus2Choice_ InstructionStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public InstructionStatus2Choice_ InstructionStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InstructionStatus2Choice_ InstructionStatus { get; init; } 
    #else
    public InstructionStatus2Choice_ InstructionStatus { get; set; } 
    #endif
    
    
    #nullable disable
    
}
