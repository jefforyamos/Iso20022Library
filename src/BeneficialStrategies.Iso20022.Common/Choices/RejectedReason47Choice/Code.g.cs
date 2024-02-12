﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _pf-Jgzi7Eeydid5dcNPKvg.
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
namespace BeneficialStrategies.Iso20022.Choices.RejectedReason47Choice
{
    /// <summary>
    /// Standard code to specify the reason why the instruction/cancellation request has a rejected status.
    /// </summary>
    [IsoId("_pf-Jgzi7Eeydid5dcNPKvg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Code")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Code : RejectedReason47Choice_
    #else
    public partial class Code : RejectedReason47Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Code instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Code( RejectionReason64Code reqValue )
        {
            Value = reqValue;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason why the instruction request has a rejected status.
        /// </summary>
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required RejectionReason64Code Value { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public RejectionReason64Code Value { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public RejectionReason64Code Value { get; init; } 
        #else
        public RejectionReason64Code Value { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
