﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for AdHocQuery.  ISO2002 ID# _1id0wRfMEeyPHpqpKwtFdw.
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
namespace BeneficialStrategies.Iso20022.Choices.TradeReportQuery13Choice
{
    /// <summary>
    /// Query criteria specifically applied to ad-hoc queries.
    /// </summary>
    [IsoId("_1id0wRfMEeyPHpqpKwtFdw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Ad Hoc Query")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record AdHocQuery : TradeReportQuery13Choice_
    #else
    public partial class AdHocQuery : TradeReportQuery13Choice_
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
        [IsoId("_14z4MRfMEeyPHpqpKwtFdw")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Trade Life Cycle History")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoTrueFalseIndicator TradeLifeCycleHistory { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public System.String TradeLifeCycleHistory { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String TradeLifeCycleHistory { get; init; } 
        #else
        public System.String TradeLifeCycleHistory { get; set; } 
        #endif
        
        /// <summary>
        /// Indicates whether the response must include all trades  (false) or only the outstanding trades (true).
        /// </summary>
        [IsoId("_14z4MxfMEeyPHpqpKwtFdw")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Outstanding Trade Indicator")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoTrueFalseIndicator OutstandingTradeIndicator { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public System.String OutstandingTradeIndicator { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String OutstandingTradeIndicator { get; init; } 
        #else
        public System.String OutstandingTradeIndicator { get; set; } 
        #endif
        
        /// <summary>
        /// Query criteria related to counterparties.
        /// </summary>
        [IsoId("_14z4NRfMEeyPHpqpKwtFdw")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Trade Party Criteria")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
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
        [IsoId("_14z4NxfMEeyPHpqpKwtFdw")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Trade Type Criteria")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public TradeTypeQueryCriteria2? TradeTypeCriteria { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public TradeTypeQueryCriteria2? TradeTypeCriteria { get; init; } 
        #else
        public TradeTypeQueryCriteria2? TradeTypeCriteria { get; set; } 
        #endif
        
        /// <summary>
        /// Query criteria related to time values.
        /// </summary>
        [IsoId("_14z4ORfMEeyPHpqpKwtFdw")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Time Criteria")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
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
        [IsoId("_14z4OxfMEeyPHpqpKwtFdw")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Other Criteria")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
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
