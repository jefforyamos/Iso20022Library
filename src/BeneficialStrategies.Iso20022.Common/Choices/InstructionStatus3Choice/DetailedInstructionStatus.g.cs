﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for DetailedInstructionStatus.  ISO2002 ID# _RCpGxNp-Ed-ak6NoX_4Aeg_-1175269447.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
using System.ComponentModel.DataAnnotations;
#endif
namespace BeneficialStrategies.Iso20022.Choices.InstructionStatus3Choice
{
    /// <summary>
    /// Status applying to individual instructions of a MeetingInstruction.
    /// </summary>
    [IsoId("_RCpGxNp-Ed-ak6NoX_4Aeg_-1175269447")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Detailed Instruction Status")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record DetailedInstructionStatus : InstructionStatus3Choice_
    #else
    public partial class DetailedInstructionStatus : InstructionStatus3Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a DetailedInstructionStatus instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public DetailedInstructionStatus( System.String reqInstructionIdentification,InstructionStatus4Choice_ reqInstructionStatus )
        {
            InstructionIdentification = reqInstructionIdentification;
            InstructionStatus = reqInstructionStatus;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Identifies the detailed instruction within an instruction message.
        /// </summary>
        [IsoId("_RCy3xNp-Ed-ak6NoX_4Aeg_1948673741")]
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
        [IsoId("_RCy3xdp-Ed-ak6NoX_4Aeg_1948673433")]
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
        [IsoId("_RCy3xtp-Ed-ak6NoX_4Aeg_1948673493")]
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
        [IsoId("_RCy3x9p-Ed-ak6NoX_4Aeg_-949932186")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Instruction Status")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required InstructionStatus4Choice_ InstructionStatus { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public InstructionStatus4Choice_ InstructionStatus { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public InstructionStatus4Choice_ InstructionStatus { get; init; } 
        #else
        public InstructionStatus4Choice_ InstructionStatus { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
