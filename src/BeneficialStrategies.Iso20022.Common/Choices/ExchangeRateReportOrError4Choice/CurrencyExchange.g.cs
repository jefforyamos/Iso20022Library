﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for CurrencyExchange.  ISO2002 ID# _MqM5Q9fiEeqoweZZxm4TPQ.
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
namespace BeneficialStrategies.Iso20022.Choices.ExchangeRateReportOrError4Choice
{
    /// <summary>
    /// Requested business information.
    /// </summary>
    [IsoId("_MqM5Q9fiEeqoweZZxm4TPQ")]
    [DisplayName("Currency Exchange")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record CurrencyExchange : ExchangeRateReportOrError4Choice_
    #else
    public partial class CurrencyExchange : ExchangeRateReportOrError4Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a CurrencyExchange instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public CurrencyExchange( System.Decimal reqExchangeRate,string reqQuotedCurrency,System.DateTime reqQuotationDate )
        {
            ExchangeRate = reqExchangeRate;
            QuotedCurrency = reqQuotedCurrency;
            QuotationDate = reqQuotationDate;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// The value of one currency expressed in relation to another currency. ExchangeRate expresses the ratio between UnitCurrency and QuotedCurrency (ExchangeRate = UnitCurrency/QuotedCurrency).
        /// </summary>
        [IsoId("_MsMdUdfiEeqoweZZxm4TPQ")]
        [DisplayName("Exchange Rate")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="XchgRate")]
        #endif
        [IsoXmlTag("XchgRate")]
        [IsoSimpleType(IsoSimpleType.BaseOneRate)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoBaseOneRate ExchangeRate { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.Decimal ExchangeRate { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.Decimal ExchangeRate { get; init; } 
        #else
        public System.Decimal ExchangeRate { get; set; } 
        #endif
        
        /// <summary>
        /// Currency into which the base currency is converted, in a currency exchange.
        /// </summary>
        [IsoId("_MsMdU9fiEeqoweZZxm4TPQ")]
        [DisplayName("Quoted Currency")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="QtdCcy")]
        #endif
        [IsoXmlTag("QtdCcy")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required ActiveOrHistoricCurrencyCode QuotedCurrency { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required string QuotedCurrency { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public string QuotedCurrency { get; init; } 
        #else
        public string QuotedCurrency { get; set; } 
        #endif
        
        /// <summary>
        /// Date and time at which an exchange rate is quoted.
        /// </summary>
        [IsoId("_MsMdVdfiEeqoweZZxm4TPQ")]
        [DisplayName("Quotation Date")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="QtnDt")]
        #endif
        [IsoXmlTag("QtnDt")]
        [IsoSimpleType(IsoSimpleType.ISODateTime)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoISODateTime QuotationDate { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.DateTime QuotationDate { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.DateTime QuotationDate { get; init; } 
        #else
        public System.DateTime QuotationDate { get; set; } 
        #endif
        
        /// <summary>
        /// Lowest limit defined for the exchange rate.
        /// Usage: The currency authority publishes the exchange rate based on the price formed in the foreign exchange market, allowing it to float up and down within the prescribed fluctuation range. It is the lowest exchange rate supported in foreign exchange market transactions.
        /// </summary>
        [IsoId("_T-IZ4NfiEeqoweZZxm4TPQ")]
        [DisplayName("Low Limit")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="LwLmt")]
        #endif
        [IsoXmlTag("LwLmt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public ExchangeRateOrPercentage1Choice_? LowLimit { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ExchangeRateOrPercentage1Choice_? LowLimit { get; init; } 
        #else
        public ExchangeRateOrPercentage1Choice_? LowLimit { get; set; } 
        #endif
        
        /// <summary>
        /// Highest limit defined for the exchange rate.
        /// Usage: The currency authority publishes the exchange rate based on the price formed in the foreign exchange market, allowing it to float up and down within the prescribed fluctuation range. It is the highest exchange rate supported in foreign exchange market transactions.
        /// </summary>
        [IsoId("_U428wdfiEeqoweZZxm4TPQ")]
        [DisplayName("High Limit")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="HghLmt")]
        #endif
        [IsoXmlTag("HghLmt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public ExchangeRateOrPercentage1Choice_? HighLimit { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ExchangeRateOrPercentage1Choice_? HighLimit { get; init; } 
        #else
        public ExchangeRateOrPercentage1Choice_? HighLimit { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
