﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for NotSpecifiedRate.  ISO2002 ID# _7_6myUEKEeWVgfuHGaKtRQ.
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
namespace BeneficialStrategies.Iso20022.Choices.SolicitationFeeRateFormat7Choice
{
    /// <summary>
    /// Value of the rate not specified.
    /// </summary>
    [IsoId("_7_6myUEKEeWVgfuHGaKtRQ")]
    [DisplayName("Not Specified Rate")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record NotSpecifiedRate : SolicitationFeeRateFormat7Choice_
    #else
    public partial class NotSpecifiedRate : SolicitationFeeRateFormat7Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a NotSpecifiedRate instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public NotSpecifiedRate( RateValueType7Code reqValue )
        {
            Value = reqValue;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the value of a rate.
        /// </summary>
        #if DECLARE_DATACONTRACT
        [DataMember(Name="NotSpcfdRate")]
        #endif
        [IsoXmlTag("NotSpcfdRate")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required RateValueType7Code Value { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required RateValueType7Code Value { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public RateValueType7Code Value { get; init; } 
        #else
        public RateValueType7Code Value { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
