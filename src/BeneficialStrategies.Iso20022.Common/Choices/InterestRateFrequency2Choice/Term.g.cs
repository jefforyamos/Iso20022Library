﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Term.  ISO2002 ID# _mNON4fOFEeaS7fYULSI4_Q.
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
namespace BeneficialStrategies.Iso20022.Choices.InterestRateFrequency2Choice
{
    /// <summary>
    /// Frequency expressed in tenor notation.
    /// </summary>
    [IsoId("_mNON4fOFEeaS7fYULSI4_Q")]
    [DisplayName("Term")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Term : InterestRateFrequency2Choice_
    #else
    public partial class Term : InterestRateFrequency2Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        // No constructor needed for < NET8 because this type has no required members.
        #endif
        #nullable enable
        
        /// <summary>
        /// Unit for the rate basis.
        /// </summary>
        [IsoId("_sO0L0exREeakeva4q26Yqg")]
        [DisplayName("Unit")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Unit")]
        #endif
        [IsoXmlTag("Unit")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public RateBasis1Code? Unit { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public RateBasis1Code? Unit { get; init; } 
        #else
        public RateBasis1Code? Unit { get; set; } 
        #endif
        
        /// <summary>
        /// Value of the contract term in number of units.
        /// </summary>
        [IsoId("_sO0L0-xREeakeva4q26Yqg")]
        [DisplayName("Value")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Val")]
        #endif
        [IsoXmlTag("Val")]
        [IsoSimpleType(IsoSimpleType.Max3Number)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax3Number? Value { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.UInt64? Value { get; init; } 
        #else
        public System.UInt64? Value { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
