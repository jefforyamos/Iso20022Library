﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for UnitOfMeasureCode.  ISO2002 ID# _RJ9MUBraEeOVR9VN6fAMUg.
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
namespace BeneficialStrategies.Iso20022.Choices.UnitOfMeasure3Choice
{
    /// <summary>
    /// Quantity of a product on a line specified by a number. For example, 100 (kgs), 50 (pieces).
    /// </summary>
    [IsoId("_RJ9MUBraEeOVR9VN6fAMUg")]
    [DisplayName("Unit Of Measure Code")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record UnitOfMeasureCode : UnitOfMeasure3Choice_
    #else
    public partial class UnitOfMeasureCode : UnitOfMeasure3Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a UnitOfMeasureCode instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public UnitOfMeasureCode( UnitOfMeasure4Code reqValue )
        {
            Value = reqValue;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Identifies the unit of measure by means of a code. The code is taken from UN/ECE Recommendation 20.
        /// </summary>
        #if DECLARE_DATACONTRACT
        [DataMember(Name="UnitOfMeasrCd")]
        #endif
        [IsoXmlTag("UnitOfMeasrCd")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required UnitOfMeasure4Code Value { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required UnitOfMeasure4Code Value { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public UnitOfMeasure4Code Value { get; init; } 
        #else
        public UnitOfMeasure4Code Value { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
