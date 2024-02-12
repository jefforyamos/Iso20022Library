﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Reason.  ISO2002 ID# _y9mPAf7qEeCvPoRGOxRobQ.
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
namespace BeneficialStrategies.Iso20022.Choices.AcknowledgedAcceptedStatus7Choice
{
    /// <summary>
    /// Specifies the reason of the AcknowledgedAcceptedStatus.
    /// </summary>
    [IsoId("_y9mPAf7qEeCvPoRGOxRobQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Reason")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Reason : AcknowledgedAcceptedStatus7Choice_
    #else
    public partial class Reason : AcknowledgedAcceptedStatus7Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Reason instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Reason( AcknowledgementReason4Choice_ reqCode )
        {
            Code = reqCode;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Reason provided for the status.
        /// </summary>
        [IsoId("_UZOBAtp-Ed-ak6NoX_4Aeg_-1447506265")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Code")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required AcknowledgementReason4Choice_ Code { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public AcknowledgementReason4Choice_ Code { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public AcknowledgementReason4Choice_ Code { get; init; } 
        #else
        public AcknowledgementReason4Choice_ Code { get; set; } 
        #endif
        
        /// <summary>
        /// Provides additional reason information that cannot be provided in a structured field.
        /// </summary>
        [IsoId("_UZOBA9p-Ed-ak6NoX_4Aeg_1850388678")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Additional Reason Information")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [StringLength(maximumLength: 210 ,MinimumLength = 1)]
        #endif
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
