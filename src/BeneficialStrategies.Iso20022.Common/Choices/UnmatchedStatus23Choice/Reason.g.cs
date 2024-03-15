﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Reason.  ISO2002 ID# _l9bK0xUIEeuZw7VHHgrHLg.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
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
namespace BeneficialStrategies.Iso20022.Choices.UnmatchedStatus23Choice
{
    /// <summary>
    /// Specifies the reason of the unmatched status.
    /// </summary>
    [IsoId("_l9bK0xUIEeuZw7VHHgrHLg")]
    [DisplayName("Reason")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Reason : UnmatchedStatus23Choice_
    #else
    public partial class Reason : UnmatchedStatus23Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Reason instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Reason( UnmatchedReason31Choice_ reqCode )
        {
            Code = reqCode;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Specifies the reason why the instruction has an unmatched status.
        /// </summary>
        [IsoId("_mfMbIRUIEeuZw7VHHgrHLg")]
        [DisplayName("Code")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Cd")]
        #endif
        [IsoXmlTag("Cd")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required UnmatchedReason31Choice_ Code { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required UnmatchedReason31Choice_ Code { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public UnmatchedReason31Choice_ Code { get; init; } 
        #else
        public UnmatchedReason31Choice_ Code { get; set; } 
        #endif
        
        /// <summary>
        /// Provides additional reason information that cannot be provided in a structured field.
        /// </summary>
        [IsoId("_mfMbJRUIEeuZw7VHHgrHLg")]
        [DisplayName("Additional Reason Information")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="AddtlRsnInf")]
        #endif
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.Max210Text)]
        [StringLength(maximumLength: 210 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax210Text? AdditionalReasonInformation { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? AdditionalReasonInformation { get; init; } 
        #else
        public System.String? AdditionalReasonInformation { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
