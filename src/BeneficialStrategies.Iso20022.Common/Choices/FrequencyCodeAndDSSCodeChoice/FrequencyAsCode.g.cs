﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for FrequencyAsCode.  ISO2002 ID# _Uuhiodp-Ed-ak6NoX_4Aeg_501343039.
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
namespace BeneficialStrategies.Iso20022.Choices.FrequencyCodeAndDSSCodeChoice
{
    /// <summary>
    /// Frequency expressed as a code.
    /// </summary>
    [IsoId("_Uuhiodp-Ed-ak6NoX_4Aeg_501343039")]
    [DisplayName("Frequency As Code")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record FrequencyAsCode : FrequencyCodeAndDSSCodeChoice_
    #else
    public partial class FrequencyAsCode : FrequencyCodeAndDSSCodeChoice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a FrequencyAsCode instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public FrequencyAsCode( Frequency1Code reqValue )
        {
            Value = reqValue;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the regularity of an event.
        /// </summary>
        #if DECLARE_DATACONTRACT
        [DataMember(Name="FrqcyAsCd")]
        #endif
        [IsoXmlTag("FrqcyAsCd")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required Frequency1Code Value { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required Frequency1Code Value { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public Frequency1Code Value { get; init; } 
        #else
        public Frequency1Code Value { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
