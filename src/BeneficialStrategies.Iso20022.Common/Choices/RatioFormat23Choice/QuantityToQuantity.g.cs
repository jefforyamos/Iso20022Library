﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for QuantityToQuantity.  ISO2002 ID# _cti6GJKQEeWHWpTQn1FFVg.
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
namespace BeneficialStrategies.Iso20022.Choices.RatioFormat23Choice
{
    /// <summary>
    /// Ratio expressed as a quotient of quantities.
    /// </summary>
    [IsoId("_cti6GJKQEeWHWpTQn1FFVg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Quantity To Quantity")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record QuantityToQuantity : RatioFormat23Choice_
    #else
    public partial class QuantityToQuantity : RatioFormat23Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a QuantityToQuantity instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public QuantityToQuantity( System.UInt64 reqQuantity1,System.UInt64 reqQuantity2 )
        {
            Quantity1 = reqQuantity1;
            Quantity2 = reqQuantity2;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Numerator of the quotient of quantities.
        /// </summary>
        [IsoId("_WjNMUdp-Ed-ak6NoX_4Aeg_2126904066")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Quantity")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoRestrictedFINDecimalNumber Quantity1 { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public System.UInt64 Quantity1 { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.UInt64 Quantity1 { get; init; } 
        #else
        public System.UInt64 Quantity1 { get; set; } 
        #endif
        
        /// <summary>
        /// Denominator of the quotient of quantities.
        /// </summary>
        [IsoId("_WjNMUtp-Ed-ak6NoX_4Aeg_-1402106980")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Quantity")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoRestrictedFINDecimalNumber Quantity2 { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public System.UInt64 Quantity2 { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.UInt64 Quantity2 { get; init; } 
        #else
        public System.UInt64 Quantity2 { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
