﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for AmountToQuantity.  ISO2002 ID# _ctoZQZKQEeWHWpTQn1FFVg.
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
namespace BeneficialStrategies.Iso20022.Choices.SolicitationFeeRateFormat10Choice
{
    /// <summary>
    /// Ratio expressed as an amount to quantity ratio.
    /// </summary>
    [IsoId("_ctoZQZKQEeWHWpTQn1FFVg")]
    [DisplayName("Amount To Quantity")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record AmountToQuantity : SolicitationFeeRateFormat10Choice_
    #else
    public partial class AmountToQuantity : SolicitationFeeRateFormat10Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a AmountToQuantity instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public AmountToQuantity( RestrictedFINActiveCurrencyAnd13DecimalAmount reqAmount,System.UInt64 reqQuantity )
        {
            Amount = reqAmount;
            Quantity = reqQuantity;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Cash amount.
        /// </summary>
        [IsoId("_ckCYlJKQEeWHWpTQn1FFVg")]
        [DisplayName("Amount")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Amt")]
        #endif
        [IsoXmlTag("Amt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required RestrictedFINActiveCurrencyAnd13DecimalAmount Amount { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required RestrictedFINActiveCurrencyAnd13DecimalAmount Amount { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public RestrictedFINActiveCurrencyAnd13DecimalAmount Amount { get; init; } 
        #else
        public RestrictedFINActiveCurrencyAnd13DecimalAmount Amount { get; set; } 
        #endif
        
        /// <summary>
        /// Quantity expressed as number.
        /// </summary>
        [IsoId("_ckCYnJKQEeWHWpTQn1FFVg")]
        [DisplayName("Quantity")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Qty")]
        #endif
        [IsoXmlTag("Qty")]
        [IsoSimpleType(IsoSimpleType.RestrictedFINDecimalNumber)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoRestrictedFINDecimalNumber Quantity { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.UInt64 Quantity { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.UInt64 Quantity { get; init; } 
        #else
        public System.UInt64 Quantity { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
