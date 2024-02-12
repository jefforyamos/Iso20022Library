﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _pQ9Sy_DBEemsS_0xy2XRug.
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
namespace BeneficialStrategies.Iso20022.Choices.CreditorEnrolmentCancellationReason1Choice
{
    /// <summary>
    /// Reason, as published in an external reason code list.
    /// </summary>
    [IsoId("_pQ9Sy_DBEemsS_0xy2XRug")]
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
    public partial record Code : CreditorEnrolmentCancellationReason1Choice_
    #else
    public partial class Code : CreditorEnrolmentCancellationReason1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Code instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Code( ExternalCreditorEnrolmentCancellationReason1Code reqValue )
        {
            Value = reqValue;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the creditor enrolment cancellation reason code, as published in an external creditor enrolment cancellation reason code set.
        /// External code sets can be downloaded from www.iso20022.org.
        /// </summary>
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required ExternalCreditorEnrolmentCancellationReason1Code Value { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public ExternalCreditorEnrolmentCancellationReason1Code Value { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ExternalCreditorEnrolmentCancellationReason1Code Value { get; init; } 
        #else
        public ExternalCreditorEnrolmentCancellationReason1Code Value { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
