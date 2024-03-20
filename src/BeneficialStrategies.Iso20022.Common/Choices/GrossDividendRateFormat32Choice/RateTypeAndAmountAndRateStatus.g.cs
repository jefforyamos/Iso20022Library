﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for RateTypeAndAmountAndRateStatus.  ISO2002 ID# _sk1gr83wEee5nJBZsW8MFQ.
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
namespace BeneficialStrategies.Iso20022.Choices.GrossDividendRateFormat32Choice
{
    /// <summary>
    /// Specifies different formats for the gross dividend rate.
    /// </summary>
    [IsoId("_sk1gr83wEee5nJBZsW8MFQ")]
    [DisplayName("Rate Type And Amount And Rate Status")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record RateTypeAndAmountAndRateStatus : GrossDividendRateFormat32Choice_
    #else
    public partial class RateTypeAndAmountAndRateStatus : GrossDividendRateFormat32Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a RateTypeAndAmountAndRateStatus instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public RateTypeAndAmountAndRateStatus( RateType74Choice_ reqRateType,RestrictedFINActiveCurrencyAnd13DecimalAmount reqAmount )
        {
            RateType = reqRateType;
            Amount = reqAmount;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Value expressed as a rate type.
        /// </summary>
        [IsoId("_sk1gyc3wEee5nJBZsW8MFQ")]
        [DisplayName("Rate Type")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="RateTp")]
        #endif
        [IsoXmlTag("RateTp")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required RateType74Choice_ RateType { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required RateType74Choice_ RateType { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public RateType74Choice_ RateType { get; init; } 
        #else
        public RateType74Choice_ RateType { get; set; } 
        #endif
        
        /// <summary>
        /// Value expressed as an amount.
        /// </summary>
        [IsoId("_sk1g0c3wEee5nJBZsW8MFQ")]
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
        /// Value expressed as a rate status.
        /// </summary>
        [IsoId("_sk1g083wEee5nJBZsW8MFQ")]
        [DisplayName("Rate Status")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="RateSts")]
        #endif
        [IsoXmlTag("RateSts")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public RateStatus4Choice_? RateStatus { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public RateStatus4Choice_? RateStatus { get; init; } 
        #else
        public RateStatus4Choice_? RateStatus { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
