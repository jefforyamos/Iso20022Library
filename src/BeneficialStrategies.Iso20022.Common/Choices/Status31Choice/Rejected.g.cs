﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Rejected.  ISO2002 ID# _ym2jw5M6EemKz5EOjv82iQ.
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
namespace BeneficialStrategies.Iso20022.Choices.Status31Choice
{
    /// <summary>
    /// Status of the transfer cancellation is rejected.
    /// </summary>
    [IsoId("_ym2jw5M6EemKz5EOjv82iQ")]
    [DisplayName("Rejected")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Rejected : Status31Choice_
    #else
    public partial class Rejected : Status31Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Rejected instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Rejected( RejectedReason17Choice_ reqReason )
        {
            Reason = reqReason;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Reason for the rejected status.
        /// </summary>
        [IsoId("_oNxuYSYuEeW_ZNn8gbfY7Q")]
        [DisplayName("Reason")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Rsn")]
        #endif
        [IsoXmlTag("Rsn")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required RejectedReason17Choice_ Reason { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required RejectedReason17Choice_ Reason { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public RejectedReason17Choice_ Reason { get; init; } 
        #else
        public RejectedReason17Choice_ Reason { get; set; } 
        #endif
        
        /// <summary>
        /// Additional information about the rejected status reason.
        /// </summary>
        [IsoId("_oNxuaSYuEeW_ZNn8gbfY7Q")]
        [DisplayName("Additional Reason Information")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="AddtlRsnInf")]
        #endif
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax350Text? AdditionalReasonInformation { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? AdditionalReasonInformation { get; init; } 
        #else
        public System.String? AdditionalReasonInformation { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
