﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for AdHocQuery.  ISO2002 ID# _QG7ioa5pEeuo-IflVgGqiA.
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
namespace BeneficialStrategies.Iso20022.Choices.TradeReportQuery12Choice
{
    /// <summary>
    /// Query criteria specifically applied to ad-hoc queries.
    /// </summary>
    [IsoId("_QG7ioa5pEeuo-IflVgGqiA")]
    [DisplayName("Ad Hoc Query")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record AdHocQuery : TradeReportQuery12Choice_
    #else
    public partial class AdHocQuery : TradeReportQuery12Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a AdHocQuery instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public AdHocQuery( System.String reqTradeLifeCycleHistory,System.String reqOutstandingTradeIndicator )
        {
            TradeLifeCycleHistory = reqTradeLifeCycleHistory;
            OutstandingTradeIndicator = reqOutstandingTradeIndicator;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Indicates whether the response must include all reports submitted for a trade (true) or only the current state of the trade (false).
        /// Usage:
        /// If false is selected, the reporting timestamp element must be absent.
        /// </summary>
        [IsoId("_QWIcQa5pEeuo-IflVgGqiA")]
        [DisplayName("Trade Life Cycle History")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="TradLifeCyclHstry")]
        #endif
        [IsoXmlTag("TradLifeCyclHstry")]
        [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoTrueFalseIndicator TradeLifeCycleHistory { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String TradeLifeCycleHistory { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String TradeLifeCycleHistory { get; init; } 
        #else
        public System.String TradeLifeCycleHistory { get; set; } 
        #endif
        
        /// <summary>
        /// Indicates whether the response must include all trades  (false) or only the outstanding trades (true).
        /// </summary>
        [IsoId("_QWIcQ65pEeuo-IflVgGqiA")]
        [DisplayName("Outstanding Trade Indicator")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="OutsdngTradInd")]
        #endif
        [IsoXmlTag("OutsdngTradInd")]
        [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoTrueFalseIndicator OutstandingTradeIndicator { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String OutstandingTradeIndicator { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String OutstandingTradeIndicator { get; init; } 
        #else
        public System.String OutstandingTradeIndicator { get; set; } 
        #endif
        
        /// <summary>
        /// Query criteria related to counterparties.
        /// </summary>
        [IsoId("_QWIcRa5pEeuo-IflVgGqiA")]
        [DisplayName("Trade Party Criteria")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="TradPtyCrit")]
        #endif
        [IsoXmlTag("TradPtyCrit")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public TradePartyQueryCriteria5? TradePartyCriteria { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public TradePartyQueryCriteria5? TradePartyCriteria { get; init; } 
        #else
        public TradePartyQueryCriteria5? TradePartyCriteria { get; set; } 
        #endif
        
        /// <summary>
        /// Query criteria related to transaction types.
        /// </summary>
        [IsoId("_QWIcR65pEeuo-IflVgGqiA")]
        [DisplayName("Trade Type Criteria")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="TradTpCrit")]
        #endif
        [IsoXmlTag("TradTpCrit")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public TradeTypeQueryCriteria1? TradeTypeCriteria { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public TradeTypeQueryCriteria1? TradeTypeCriteria { get; init; } 
        #else
        public TradeTypeQueryCriteria1? TradeTypeCriteria { get; set; } 
        #endif
        
        /// <summary>
        /// Query criteria related to time values.
        /// </summary>
        [IsoId("_QWIcSa5pEeuo-IflVgGqiA")]
        [DisplayName("Time Criteria")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="TmCrit")]
        #endif
        [IsoXmlTag("TmCrit")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public TradeDateTimeQueryCriteria2? TimeCriteria { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public TradeDateTimeQueryCriteria2? TimeCriteria { get; init; } 
        #else
        public TradeDateTimeQueryCriteria2? TimeCriteria { get; set; } 
        #endif
        
        /// <summary>
        /// Query criteria related to other fields.
        /// </summary>
        [IsoId("_QWIcS65pEeuo-IflVgGqiA")]
        [DisplayName("Other Criteria")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="OthrCrit")]
        #endif
        [IsoXmlTag("OthrCrit")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public TradeAdditionalQueryCriteria7? OtherCriteria { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public TradeAdditionalQueryCriteria7? OtherCriteria { get; init; } 
        #else
        public TradeAdditionalQueryCriteria7? OtherCriteria { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
