﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for RateTypeAmount.  ISO2002 ID# _UPYvkdp-Ed-ak6NoX_4Aeg_1388251896.
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
namespace BeneficialStrategies.Iso20022.Choices.GrossDividendRate1Choice
{
    /// <summary>
    /// Value is expressed as an amount related to an underlying securities, eg, underlying security for which an interest is paid.
    /// </summary>
    [IsoId("_UPYvkdp-Ed-ak6NoX_4Aeg_1388251896")]
    [DisplayName("Rate Type Amount")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record RateTypeAmount : GrossDividendRate1Choice_
    #else
    public partial class RateTypeAmount : GrossDividendRate1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a RateTypeAmount instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public RateTypeAmount( GrossDividendRateType1FormatChoice_ reqRateType,ActiveCurrencyAndAmount reqAmount )
        {
            RateType = reqRateType;
            Amount = reqAmount;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Type of underlying securities to which the rate is related, eg, underlying security for which an interest is paid.
        /// </summary>
        [IsoId("_UPh5hNp-Ed-ak6NoX_4Aeg_1284818087")]
        [DisplayName("Rate Type")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="RateTp")]
        #endif
        [IsoXmlTag("RateTp")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required GrossDividendRateType1FormatChoice_ RateType { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required GrossDividendRateType1FormatChoice_ RateType { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public GrossDividendRateType1FormatChoice_ RateType { get; init; } 
        #else
        public GrossDividendRateType1FormatChoice_ RateType { get; set; } 
        #endif
        
        /// <summary>
        /// Value expressed as an amount.
        /// </summary>
        [IsoId("_UPh5hdp-Ed-ak6NoX_4Aeg_1284818088")]
        [DisplayName("Amount")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Amt")]
        #endif
        [IsoXmlTag("Amt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required ActiveCurrencyAndAmount Amount { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required ActiveCurrencyAndAmount Amount { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ActiveCurrencyAndAmount Amount { get; init; } 
        #else
        public ActiveCurrencyAndAmount Amount { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
