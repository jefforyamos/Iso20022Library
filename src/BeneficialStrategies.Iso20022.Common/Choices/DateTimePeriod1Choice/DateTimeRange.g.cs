﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for DateTimeRange.  ISO2002 ID# _xTM9RZlcEeeE1Ya-LgRsuQ.
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
namespace BeneficialStrategies.Iso20022.Choices.DateTimePeriod1Choice
{
    /// <summary>
    /// Range of time between a start date and time and an end date and time.
    /// </summary>
    [IsoId("_xTM9RZlcEeeE1Ya-LgRsuQ")]
    [DisplayName("Date Time Range")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record DateTimeRange : DateTimePeriod1Choice_
    #else
    public partial class DateTimeRange : DateTimePeriod1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a DateTimeRange instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public DateTimeRange( System.DateTime reqFromDateTime,System.DateTime reqToDateTime )
        {
            FromDateTime = reqFromDateTime;
            ToDateTime = reqToDateTime;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Date and time at which the period starts.
        /// </summary>
        [IsoId("_aeAZNPhvEeSLI7Du5Hk4iw")]
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
        /// Date and time at which the period ends.
        /// </summary>
        [IsoId("_aeAZNfhvEeSLI7Du5Hk4iw")]
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
