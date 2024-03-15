﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for DateTime.  ISO2002 ID# _l61PQ7QVEeemgtANb5gbCw.
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
namespace BeneficialStrategies.Iso20022.Choices.DateOrDateTimePeriod2Choice
{
    /// <summary>
    /// Period expressed with dates and times.
    /// </summary>
    [IsoId("_l61PQ7QVEeemgtANb5gbCw")]
    [DisplayName("Date Time")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record DateTime : DateOrDateTimePeriod2Choice_
    #else
    public partial class DateTime : DateOrDateTimePeriod2Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a DateTime instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public DateTime( System.DateTime reqFromDateTime,System.DateTime reqToDateTime )
        {
            FromDateTime = reqFromDateTime;
            ToDateTime = reqToDateTime;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Date and time at which the range starts.
        /// </summary>
        [IsoId("_JWX38a3NEeey8N0JWnVPUw")]
        [DisplayName("From Date Time")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="FrDtTm")]
        #endif
        [IsoXmlTag("FrDtTm")]
        [IsoSimpleType(IsoSimpleType.ISODateTime)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoISODateTime FromDateTime { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.DateTime FromDateTime { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.DateTime FromDateTime { get; init; } 
        #else
        public System.DateTime FromDateTime { get; set; } 
        #endif
        
        /// <summary>
        /// Date and time at which the range ends.
        /// </summary>
        [IsoId("_JWX3863NEeey8N0JWnVPUw")]
        [DisplayName("To Date Time")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="ToDtTm")]
        #endif
        [IsoXmlTag("ToDtTm")]
        [IsoSimpleType(IsoSimpleType.ISODateTime)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoISODateTime ToDateTime { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.DateTime ToDateTime { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.DateTime ToDateTime { get; init; } 
        #else
        public System.DateTime ToDateTime { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
