﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ReasonDetails.  ISO2002 ID# _Bptp5UHqEea8I67lh6qdSQ.
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
namespace BeneficialStrategies.Iso20022.Choices.InRepairStatusReason4Choice
{
    /// <summary>
    /// Reason for the in repair status, expressed as a code.
    /// </summary>
    [IsoId("_Bptp5UHqEea8I67lh6qdSQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Reason Details")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record ReasonDetails : InRepairStatusReason4Choice_
    #else
    public partial class ReasonDetails : InRepairStatusReason4Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a ReasonDetails instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public ReasonDetails( InRepairStatusReason5Choice_ reqReason )
        {
            Reason = reqReason;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Reason for the in repair status expressed as a code.
        /// </summary>
        [IsoId("_Hxv_IUHqEea8I67lh6qdSQ")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Reason")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required InRepairStatusReason5Choice_ Reason { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public InRepairStatusReason5Choice_ Reason { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public InRepairStatusReason5Choice_ Reason { get; init; } 
        #else
        public InRepairStatusReason5Choice_ Reason { get; set; } 
        #endif
        
        /// <summary>
        /// Additional information about the in repair reason.
        /// </summary>
        [IsoId("_Hxv_I0HqEea8I67lh6qdSQ")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Additional Information")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [StringLength(maximumLength: 350 ,MinimumLength = 1)]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax350Text? AdditionalInformation { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? AdditionalInformation { get; init; } 
        #else
        public System.String? AdditionalInformation { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
