﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for AmountToAmount.  ISO2002 ID# _Rj3kgdp-Ed-ak6NoX_4Aeg_-251071667.
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
namespace BeneficialStrategies.Iso20022.Choices.RatioFormat1Choice
{
    /// <summary>
    /// The ratio is expressed as an amount per another amount.
    /// </summary>
    [IsoId("_Rj3kgdp-Ed-ak6NoX_4Aeg_-251071667")]
    [DisplayName("Amount To Amount")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record AmountToAmount : RatioFormat1Choice_
    #else
    public partial class AmountToAmount : RatioFormat1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a AmountToAmount instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public AmountToAmount( ActiveCurrencyAndAmount reqAmount1,ActiveCurrencyAndAmount reqAmount2 )
        {
            Amount1 = reqAmount1;
            Amount2 = reqAmount2;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Numerator of the quotient of amounts.
        /// </summary>
        [IsoId("_UHySwdp-Ed-ak6NoX_4Aeg_622579243")]
        [DisplayName("Amount")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Amt1")]
        #endif
        [IsoXmlTag("Amt1")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required ActiveCurrencyAndAmount Amount1 { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required ActiveCurrencyAndAmount Amount1 { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ActiveCurrencyAndAmount Amount1 { get; init; } 
        #else
        public ActiveCurrencyAndAmount Amount1 { get; set; } 
        #endif
        
        /// <summary>
        /// Denominator of the quotient of amounts.
        /// </summary>
        [IsoId("_UHySwtp-Ed-ak6NoX_4Aeg_636432914")]
        [DisplayName("Amount")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Amt2")]
        #endif
        [IsoXmlTag("Amt2")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required ActiveCurrencyAndAmount Amount2 { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required ActiveCurrencyAndAmount Amount2 { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ActiveCurrencyAndAmount Amount2 { get; init; } 
        #else
        public ActiveCurrencyAndAmount Amount2 { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
