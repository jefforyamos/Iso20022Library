﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for FullPeriodUnits.  ISO2002 ID# _plN2PTi7Eeydid5dcNPKvg.
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
namespace BeneficialStrategies.Iso20022.Choices.BalanceFormat16Choice
{
    /// <summary>
    /// Number of units of a fund that were purchased in a previous distribution period and/or held at the beginning of a distribution period, for example Group I Units in the UK.
    /// </summary>
    [IsoId("_plN2PTi7Eeydid5dcNPKvg")]
    [DisplayName("Full Period Units")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record FullPeriodUnits : BalanceFormat16Choice_
    #else
    public partial class FullPeriodUnits : BalanceFormat16Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a FullPeriodUnits instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public FullPeriodUnits( ShortLong1Code reqShortLongPosition,FinancialInstrumentQuantity36Choice_ reqQuantity )
        {
            ShortLongPosition = reqShortLongPosition;
            Quantity = reqQuantity;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Sign of the quantity of security.
        /// </summary>
        [IsoId("_pf0_XTi7Eeydid5dcNPKvg")]
        [DisplayName("Short Long Position")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="ShrtLngPos")]
        #endif
        [IsoXmlTag("ShrtLngPos")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required ShortLong1Code ShortLongPosition { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required ShortLong1Code ShortLongPosition { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ShortLong1Code ShortLongPosition { get; init; } 
        #else
        public ShortLong1Code ShortLongPosition { get; set; } 
        #endif
        
        /// <summary>
        /// Quantity of security.
        /// </summary>
        [IsoId("_pf0_Xzi7Eeydid5dcNPKvg")]
        [DisplayName("Quantity")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Qty")]
        #endif
        [IsoXmlTag("Qty")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required FinancialInstrumentQuantity36Choice_ Quantity { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required FinancialInstrumentQuantity36Choice_ Quantity { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public FinancialInstrumentQuantity36Choice_ Quantity { get; init; } 
        #else
        public FinancialInstrumentQuantity36Choice_ Quantity { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
