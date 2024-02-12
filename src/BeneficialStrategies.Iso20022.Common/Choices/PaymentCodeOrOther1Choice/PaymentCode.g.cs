﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for PaymentCode.  ISO2002 ID# _uoAOcNP8EeK0PPbKncCqzA.
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
namespace BeneficialStrategies.Iso20022.Choices.PaymentCodeOrOther1Choice
{
    /// <summary>
    /// Specifies the payment period in coded form and a number of days.
    /// </summary>
    [IsoId("_uoAOcNP8EeK0PPbKncCqzA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Payment Code")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record PaymentCode : PaymentCodeOrOther1Choice_
    #else
    public partial class PaymentCode : PaymentCodeOrOther1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a PaymentCode instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public PaymentCode( PaymentTime3Code reqCode )
        {
            Code = reqCode;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Code for the payment.
        /// </summary>
        [IsoId("_FlyjYdP-EeK0PPbKncCqzA")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Code")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required PaymentTime3Code Code { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public PaymentTime3Code Code { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PaymentTime3Code Code { get; init; } 
        #else
        public PaymentTime3Code Code { get; set; } 
        #endif
        
        /// <summary>
        /// Number of days after which the payment must be effected.
        /// </summary>
        [IsoId("_FlyjY9P-EeK0PPbKncCqzA")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Number Of Days")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoNumber? NumberOfDays { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.UInt64? NumberOfDays { get; init; } 
        #else
        public System.UInt64? NumberOfDays { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
