﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for NotSpecifiedPrice.  ISO2002 ID# _ASFIo-wOEd-sn-FiNtktcA.
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
namespace BeneficialStrategies.Iso20022.Choices.PriceFormat23Choice
{
    /// <summary>
    /// Value of the price not specified.
    /// </summary>
    [IsoId("_ASFIo-wOEd-sn-FiNtktcA")]
    [DisplayName("Not Specified Price")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record NotSpecifiedPrice : PriceFormat23Choice_
    #else
    public partial class NotSpecifiedPrice : PriceFormat23Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a NotSpecifiedPrice instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public NotSpecifiedPrice( PriceValueType10Code reqValue )
        {
            Value = reqValue;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the value of a price.
        /// </summary>
        #if DECLARE_DATACONTRACT
        [DataMember(Name="NotSpcfdPric")]
        #endif
        [IsoXmlTag("NotSpcfdPric")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required PriceValueType10Code Value { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required PriceValueType10Code Value { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PriceValueType10Code Value { get; init; } 
        #else
        public PriceValueType10Code Value { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
