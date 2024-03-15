﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Reason.  ISO2002 ID# _3jTWyTqOEeWyoP0PbocV1Q.
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
namespace BeneficialStrategies.Iso20022.Choices.FailingStatus10Choice
{
    /// <summary>
    /// Specifies the reason of the failing status.
    /// </summary>
    [IsoId("_3jTWyTqOEeWyoP0PbocV1Q")]
    [DisplayName("Reason")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Reason : FailingStatus10Choice_
    #else
    public partial class Reason : FailingStatus10Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Reason instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Reason( FailingReason8Choice_ reqCode )
        {
            Code = reqCode;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Specifies the reason why the instruction has a failing status.
        /// </summary>
        [IsoId("_4D4UQTqOEeWyoP0PbocV1Q")]
        [DisplayName("Code")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Cd")]
        #endif
        [IsoXmlTag("Cd")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required FailingReason8Choice_ Code { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required FailingReason8Choice_ Code { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public FailingReason8Choice_ Code { get; init; } 
        #else
        public FailingReason8Choice_ Code { get; set; } 
        #endif
        
        /// <summary>
        /// Provides additional reason information that cannot be provided in a structured field.
        /// </summary>
        [IsoId("_4D4USTqOEeWyoP0PbocV1Q")]
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
