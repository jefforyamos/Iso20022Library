﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Reason.  ISO2002 ID# _oftdyTzpEeWeNtT0s2RbkQ.
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
namespace BeneficialStrategies.Iso20022.Choices.ConsentStatus4Choice
{
    /// <summary>
    /// Reason provided for the status.
    /// </summary>
    [IsoId("_oftdyTzpEeWeNtT0s2RbkQ")]
    [DisplayName("Reason")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Reason : ConsentStatus4Choice_
    #else
    public partial class Reason : ConsentStatus4Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Reason instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Reason( ConsentOrRejectionReason4Choice_ reqCode )
        {
            Code = reqCode;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Reason provided for the status.
        /// </summary>
        [IsoId("_pASbQTzpEeWeNtT0s2RbkQ")]
        [DisplayName("Code")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Cd")]
        #endif
        [IsoXmlTag("Cd")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required ConsentOrRejectionReason4Choice_ Code { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required ConsentOrRejectionReason4Choice_ Code { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ConsentOrRejectionReason4Choice_ Code { get; init; } 
        #else
        public ConsentOrRejectionReason4Choice_ Code { get; set; } 
        #endif
        
        /// <summary>
        /// Provides additional reason information that cannot be provided in a structured field.
        /// </summary>
        [IsoId("_pASbQzzpEeWeNtT0s2RbkQ")]
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
