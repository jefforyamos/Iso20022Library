﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for AmountToQuantity.  ISO2002 ID# _Q1-jydp-Ed-ak6NoX_4Aeg_-1315079997.
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
namespace BeneficialStrategies.Iso20022.Choices.RatioFormat6Choice
{
    /// <summary>
    /// Ratio expressed as an amount to quantity ratio.
    /// </summary>
    [IsoId("_Q1-jydp-Ed-ak6NoX_4Aeg_-1315079997")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Amount To Quantity")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record AmountToQuantity : RatioFormat6Choice_
    #else
    public partial class AmountToQuantity : RatioFormat6Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a AmountToQuantity instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public AmountToQuantity( System.Decimal reqAmount,System.UInt64 reqQuantity )
        {
            Amount = reqAmount;
            Quantity = reqQuantity;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Cash amount.
        /// </summary>
        [IsoId("_UHySzdp-Ed-ak6NoX_4Aeg_1510604904")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Amount")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoActiveCurrencyAnd13DecimalAmount Amount { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public System.Decimal Amount { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.Decimal Amount { get; init; } 
        #else
        public System.Decimal Amount { get; set; } 
        #endif
        
        /// <summary>
        /// Quantity expressed as number.
        /// </summary>
        [IsoId("_UHySztp-Ed-ak6NoX_4Aeg_1510604921")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Quantity")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoDecimalNumber Quantity { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public System.UInt64 Quantity { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.UInt64 Quantity { get; init; } 
        #else
        public System.UInt64 Quantity { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
