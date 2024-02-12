﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for CurrencyExchangeReport.  ISO2002 ID# _77JeRKMgEeCJ6YNENx4h-w_2054430932.
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
namespace BeneficialStrategies.Iso20022.Choices.ExchangeRateReportOrError1Choice
{
    /// <summary>
    /// Reports on currency exchange information.
    /// </summary>
    [IsoId("_77JeRKMgEeCJ6YNENx4h-w_2054430932")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Currency Exchange Report")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record CurrencyExchangeReport : ExchangeRateReportOrError1Choice_
    #else
    public partial class CurrencyExchangeReport : ExchangeRateReportOrError1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a CurrencyExchangeReport instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public CurrencyExchangeReport( CurrencySourceTarget1 reqCurrencyReference,ExchangeRateReportOrError2Choice_ reqCurrencyExchangeOrError )
        {
            CurrencyReference = reqCurrencyReference;
            CurrencyExchangeOrError = reqCurrencyExchangeOrError;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Source and target currencies for which information is request.
        /// </summary>
        [IsoId("_77JeR6MgEeCJ6YNENx4h-w_-360463959")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Currency Reference")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required CurrencySourceTarget1 CurrencyReference { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public CurrencySourceTarget1 CurrencyReference { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CurrencySourceTarget1 CurrencyReference { get; init; } 
        #else
        public CurrencySourceTarget1 CurrencyReference { get; set; } 
        #endif
        
        /// <summary>
        /// Reports either on currency exchange information or on a business error.
        /// </summary>
        [IsoId("_77TPQKMgEeCJ6YNENx4h-w_-1732232506")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Currency Exchange Or Error")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required ExchangeRateReportOrError2Choice_ CurrencyExchangeOrError { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public ExchangeRateReportOrError2Choice_ CurrencyExchangeOrError { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ExchangeRateReportOrError2Choice_ CurrencyExchangeOrError { get; init; } 
        #else
        public ExchangeRateReportOrError2Choice_ CurrencyExchangeOrError { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
