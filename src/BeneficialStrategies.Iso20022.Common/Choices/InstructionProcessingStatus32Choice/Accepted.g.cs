﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Accepted.  ISO2002 ID# _hLopwLtUEeilsanBGAzy4A.
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
namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus32Choice
{
    /// <summary>
    /// Instruction is accepted.
    /// </summary>
    [IsoId("_hLopwLtUEeilsanBGAzy4A")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Accepted")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Accepted : InstructionProcessingStatus32Choice_
    #else
    public partial class Accepted : InstructionProcessingStatus32Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Accepted instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Accepted( NoReasonCode reqNoSpecifiedReason )
        {
            NoSpecifiedReason = reqNoSpecifiedReason;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Indicates that there is no reason available or to report.
        /// </summary>
        [IsoId("_UatOwNp-Ed-ak6NoX_4Aeg_137164408")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("No Specified Reason")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required NoReasonCode NoSpecifiedReason { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public NoReasonCode NoSpecifiedReason { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public NoReasonCode NoSpecifiedReason { get; init; } 
        #else
        public NoReasonCode NoSpecifiedReason { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
