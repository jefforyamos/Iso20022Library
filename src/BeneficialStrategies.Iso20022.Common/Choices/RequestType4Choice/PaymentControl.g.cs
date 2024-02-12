﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for PaymentControl.  ISO2002 ID# _i375oZIhEeect698_YsnIA.
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
namespace BeneficialStrategies.Iso20022.Choices.RequestType4Choice
{
    /// <summary>
    /// Request type is a control command on a set of transactions.
    /// </summary>
    [IsoId("_i375oZIhEeect698_YsnIA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Payment Control")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record PaymentControl : RequestType4Choice_
    #else
    public partial class PaymentControl : RequestType4Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a PaymentControl instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public PaymentControl( ExternalPaymentControlRequestType1Code reqValue )
        {
            Value = reqValue;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the external request type code for a payment control command in the format of character string with a maximum length of 4 characters.
        /// The list of valid codes is an external code set published separately.
        /// External code sets can be downloaded from www.iso20022.org.
        /// </summary>
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required ExternalPaymentControlRequestType1Code Value { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public ExternalPaymentControlRequestType1Code Value { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ExternalPaymentControlRequestType1Code Value { get; init; } 
        #else
        public ExternalPaymentControlRequestType1Code Value { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
