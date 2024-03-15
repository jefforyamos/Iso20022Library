﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ToDateTime.  ISO2002 ID# _T57c8Np-Ed-ak6NoX_4Aeg_1215657174.
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
namespace BeneficialStrategies.Iso20022.Choices.DateTimePeriodChoice
{
    /// <summary>
    /// Date and time at which the range ends.
    /// </summary>
    [IsoId("_T57c8Np-Ed-ak6NoX_4Aeg_1215657174")]
    [DisplayName("To Date Time")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record ToDateTime : DateTimePeriodChoice_
    #else
    public partial class ToDateTime : DateTimePeriodChoice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a ToDateTime instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public ToDateTime( System.DateTime reqValue )
        {
            Value = reqValue;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// A particular point in the progression of time defined by a mandatory date and a mandatory time component, expressed in either UTC time format (YYYY-MM-DDThh:mm:ss.sssZ), local time with UTC offset format (YYYY-MM-DDThh:mm:ss.sss+/-hh:mm), or local time format (YYYY-MM-DDThh:mm:ss.sss). These representations are defined in &quot;XML Schema Part 2: Datatypes Second Edition - W3C Recommendation 28 October 2004&quot; which is aligned with ISO 8601.|Note on the time format:|1) beginning / end of calendar day|00:00:00 = the beginning of a calendar day|24:00:00 = the end of a calendar day|2) fractions of second in time format|Decimal fractions of seconds may be included. In this case, the involved parties shall agree on the maximum number of digits that are allowed.
        /// </summary>
        #if DECLARE_DATACONTRACT
        [DataMember(Name="ToDtTm")]
        #endif
        [IsoXmlTag("ToDtTm")]
        [IsoSimpleType(IsoSimpleType.ISODateTime)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoISODateTime Value { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.DateTime Value { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.DateTime Value { get; init; } 
        #else
        public System.DateTime Value { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
