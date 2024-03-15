﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Period.  ISO2002 ID# __aOTka5OEeuo-IflVgGqiA.
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
namespace BeneficialStrategies.Iso20022.Choices.TimeToMaturity2Choice
{
    /// <summary>
    /// Provides the period for the time to maturity.
    /// </summary>
    [IsoId("__aOTka5OEeuo-IflVgGqiA")]
    [DisplayName("Period")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Period : TimeToMaturity2Choice_
    #else
    public partial class Period : TimeToMaturity2Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        // No constructor needed for < NET8 because this type has no required members.
        #endif
        #nullable enable
        
        /// <summary>
        /// Specifies the start of the maturity period.
        /// </summary>
        [IsoId("__pHrMa5OEeuo-IflVgGqiA")]
        [DisplayName("Start")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Start")]
        #endif
        [IsoXmlTag("Start")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public MaturityTerm2? Start { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public MaturityTerm2? Start { get; init; } 
        #else
        public MaturityTerm2? Start { get; set; } 
        #endif
        
        /// <summary>
        /// Specifies the end of the maturity period.
        /// </summary>
        [IsoId("__pHrM65OEeuo-IflVgGqiA")]
        [DisplayName("End")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="End")]
        #endif
        [IsoXmlTag("End")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public MaturityTerm2? End { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public MaturityTerm2? End { get; init; } 
        #else
        public MaturityTerm2? End { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
