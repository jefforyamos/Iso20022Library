﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for DateCalculationDescription.  ISO2002 ID# _3b5pQFSTEempisJfoIfvvQ.
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
namespace BeneficialStrategies.Iso20022.Choices.RequestShareHeldDate1Choice
{
    /// <summary>
    /// Provides the description on how the date from which the shares have been held should be determined and communicated.
    /// </summary>
    [IsoId("_3b5pQFSTEempisJfoIfvvQ")]
    [DisplayName("Date Calculation Description")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record DateCalculationDescription : RequestShareHeldDate1Choice_
    #else
    public partial class DateCalculationDescription : RequestShareHeldDate1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a DateCalculationDescription instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public DateCalculationDescription( System.String reqValue )
        {
            Value = reqValue;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a character string with a maximum length of 350 characters.
        /// </summary>
        #if DECLARE_DATACONTRACT
        [DataMember(Name="DtClctnDesc")]
        #endif
        [IsoXmlTag("DtClctnDesc")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax350Text Value { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String Value { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String Value { get; init; } 
        #else
        public System.String Value { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
