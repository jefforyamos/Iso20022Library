﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Period.  ISO2002 ID# _6GkgCR7yEeSxevWRRWxNAg.
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
namespace BeneficialStrategies.Iso20022.Choices.Frequency21Choice
{
    /// <summary>
    /// Frequency expressed as a proprietary code.
    /// </summary>
    [IsoId("_6GkgCR7yEeSxevWRRWxNAg")]
    [DisplayName("Period")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Period : Frequency21Choice_
    #else
    public partial class Period : Frequency21Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Period instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Period( Frequency6Code reqType,System.UInt64 reqCountPerPeriod )
        {
            Type = reqType;
            CountPerPeriod = reqCountPerPeriod;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Period for which the number of instructions are to be created and processed.
        /// </summary>
        [IsoId("_1bz5sB71EeSxevWRRWxNAg")]
        [DisplayName("Type")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Tp")]
        #endif
        [IsoXmlTag("Tp")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required Frequency6Code Type { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required Frequency6Code Type { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public Frequency6Code Type { get; init; } 
        #else
        public Frequency6Code Type { get; set; } 
        #endif
        
        /// <summary>
        /// Number of instructions to be created and processed during the specified period.
        /// </summary>
        [IsoId("_OPlVUB72EeSxevWRRWxNAg")]
        [DisplayName("Count Per Period")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CntPerPrd")]
        #endif
        [IsoXmlTag("CntPerPrd")]
        [IsoSimpleType(IsoSimpleType.DecimalNumber)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoDecimalNumber CountPerPeriod { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.UInt64 CountPerPeriod { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.UInt64 CountPerPeriod { get; init; } 
        #else
        public System.UInt64 CountPerPeriod { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
