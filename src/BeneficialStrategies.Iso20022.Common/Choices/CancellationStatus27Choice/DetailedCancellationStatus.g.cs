﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for DetailedCancellationStatus.  ISO2002 ID# _GQGGQMT2Eem9aZlimxVUIw.
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
namespace BeneficialStrategies.Iso20022.Choices.CancellationStatus27Choice
{
    /// <summary>
    /// Status of individual instruction cancellation request that were received within the instruction cancellation  message identified in InstructionType/InstructionCancellationIdentification. 
    /// </summary>
    [IsoId("_GQGGQMT2Eem9aZlimxVUIw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Detailed Cancellation Status")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record DetailedCancellationStatus : CancellationStatus27Choice_
    #else
    public partial class DetailedCancellationStatus : CancellationStatus27Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a DetailedCancellationStatus instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public DetailedCancellationStatus( System.String reqSingleInstructionCancellationIdentification,CancellationStatus26Choice_ reqInstructionCancellationStatus )
        {
            SingleInstructionCancellationIdentification = reqSingleInstructionCancellationIdentification;
            InstructionCancellationStatus = reqInstructionCancellationStatus;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Identification of the specific individual instruction cancellation request from the original meeting instruction cancellation request message identified in InstructionType/ InstructionCancellationIdentification, for which the status is provided.
        /// </summary>
        [IsoId("_Wrd3E8T3Eem9aZlimxVUIw")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Single Instruction Cancellation Identification")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax35Text SingleInstructionCancellationIdentification { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public System.String SingleInstructionCancellationIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String SingleInstructionCancellationIdentification { get; init; } 
        #else
        public System.String SingleInstructionCancellationIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Identification of the securities account.
        /// </summary>
        [IsoId("_Wrd3FMT3Eem9aZlimxVUIw")]
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
        /// Identification of the subaccount within the safekeeping account.
        /// </summary>
        [IsoId("_Wrd3EMT3Eem9aZlimxVUIw")]
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
        /// Status of an individual meeting instruction cancellation request.
        /// </summary>
        [IsoId("_Wrd3EcT3Eem9aZlimxVUIw")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Instruction Cancellation Status")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required CancellationStatus26Choice_ InstructionCancellationStatus { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public CancellationStatus26Choice_ InstructionCancellationStatus { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CancellationStatus26Choice_ InstructionCancellationStatus { get; init; } 
        #else
        public CancellationStatus26Choice_ InstructionCancellationStatus { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
