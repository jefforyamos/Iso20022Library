﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Addition.  ISO2002 ID# _a76DiSAdEeuyDZ-ukt4YRg.
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
namespace BeneficialStrategies.Iso20022.Choices.UpdateType34Choice
{
    /// <summary>
    /// Addition of information to the securities transaction.
    /// </summary>
    [IsoId("_a76DiSAdEeuyDZ-ukt4YRg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Addition")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Addition : UpdateType34Choice_
    #else
    public partial class Addition : UpdateType34Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        // No constructor needed for < NET8 because this type has no required members.
        #endif
        #nullable enable
        
        /// <summary>
        /// Provides settlement type and identification information.
        /// </summary>
        [IsoId("_a76DkyAdEeuyDZ-ukt4YRg")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Settlement Type And Additional Parameters")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public SettlementTypeAndAdditionalParameters17? SettlementTypeAndAdditionalParameters { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public SettlementTypeAndAdditionalParameters17? SettlementTypeAndAdditionalParameters { get; init; } 
        #else
        public SettlementTypeAndAdditionalParameters17? SettlementTypeAndAdditionalParameters { get; set; } 
        #endif
        
        /// <summary>
        /// Link to another transaction that must be processed after, before or at the same time.
        /// </summary>
        [IsoId("_a76DlSAdEeuyDZ-ukt4YRg")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Linkages")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public Linkages48? Linkages { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public Linkages48? Linkages { get; init; } 
        #else
        public Linkages48? Linkages { get; set; } 
        #endif
        
        /// <summary>
        /// Details of the trade.
        /// </summary>
        [IsoId("_a76DlyAdEeuyDZ-ukt4YRg")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Trade Details")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public SecuritiesTradeDetails132? TradeDetails { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public SecuritiesTradeDetails132? TradeDetails { get; init; } 
        #else
        public SecuritiesTradeDetails132? TradeDetails { get; set; } 
        #endif
        
        /// <summary>
        /// Attributes defining a financial instrument.
        /// </summary>
        [IsoId("_a76DmSAdEeuyDZ-ukt4YRg")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Financial Instrument Attributes")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public FinancialInstrumentAttributes97? FinancialInstrumentAttributes { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public FinancialInstrumentAttributes97? FinancialInstrumentAttributes { get; init; } 
        #else
        public FinancialInstrumentAttributes97? FinancialInstrumentAttributes { get; set; } 
        #endif
        
        /// <summary>
        /// Details related to the account and quantity involved in the transaction.
        /// </summary>
        [IsoId("_a76DmyAdEeuyDZ-ukt4YRg")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Quantity And Account Details")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public QuantityAndAccount93? QuantityAndAccountDetails { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public QuantityAndAccount93? QuantityAndAccountDetails { get; init; } 
        #else
        public QuantityAndAccount93? QuantityAndAccountDetails { get; set; } 
        #endif
        
        /// <summary>
        /// Parameters which explicitly state the conditions that must be fulfilled before a particular transaction of a financial instrument can be settled. These parameters are defined by the instructing party in compliance with settlement rules in the market the transaction will settle in.
        /// </summary>
        [IsoId("_a76DnSAdEeuyDZ-ukt4YRg")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Settlement Parameters")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public SettlementDetails195? SettlementParameters { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public SettlementDetails195? SettlementParameters { get; init; } 
        #else
        public SettlementDetails195? SettlementParameters { get; set; } 
        #endif
        
        /// <summary>
        /// Specifies what settlement standing instruction database is to be used to derive the settlement parties involved in the transaction.
        /// </summary>
        [IsoId("_a76DnyAdEeuyDZ-ukt4YRg")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Standing Settlement Instruction Details")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public StandingSettlementInstruction17? StandingSettlementInstructionDetails { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public StandingSettlementInstruction17? StandingSettlementInstructionDetails { get; init; } 
        #else
        public StandingSettlementInstruction17? StandingSettlementInstructionDetails { get; set; } 
        #endif
        
        /// <summary>
        /// Identifies the chain of delivering settlement parties.
        /// </summary>
        [IsoId("_a76DoSAdEeuyDZ-ukt4YRg")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Delivering Settlement Parties")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public SettlementParties92? DeliveringSettlementParties { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public SettlementParties92? DeliveringSettlementParties { get; init; } 
        #else
        public SettlementParties92? DeliveringSettlementParties { get; set; } 
        #endif
        
        /// <summary>
        /// Identifies the chain of receiving settlement parties.
        /// </summary>
        [IsoId("_a76DoyAdEeuyDZ-ukt4YRg")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Receiving Settlement Parties")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public SettlementParties92? ReceivingSettlementParties { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public SettlementParties92? ReceivingSettlementParties { get; init; } 
        #else
        public SettlementParties92? ReceivingSettlementParties { get; set; } 
        #endif
        
        /// <summary>
        /// Cash parties involved in the transaction if different from the securities settlement parties.
        /// </summary>
        [IsoId("_a76DpSAdEeuyDZ-ukt4YRg")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Cash Parties")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public CashParties38? CashParties { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CashParties38? CashParties { get; init; } 
        #else
        public CashParties38? CashParties { get; set; } 
        #endif
        
        /// <summary>
        /// Total amount of money to be paid or received in exchange for the securities.
        /// </summary>
        [IsoId("_a76DpyAdEeuyDZ-ukt4YRg")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Settlement Amount")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public AmountAndDirection101? SettlementAmount { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public AmountAndDirection101? SettlementAmount { get; init; } 
        #else
        public AmountAndDirection101? SettlementAmount { get; set; } 
        #endif
        
        /// <summary>
        /// Other amounts than the settlement amount.
        /// </summary>
        [IsoId("_a76DqSAdEeuyDZ-ukt4YRg")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Other Amounts")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public OtherAmounts43? OtherAmounts { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public OtherAmounts43? OtherAmounts { get; init; } 
        #else
        public OtherAmounts43? OtherAmounts { get; set; } 
        #endif
        
        /// <summary>
        /// Other business parties relevant to the transaction.
        /// </summary>
        [IsoId("_a76DqyAdEeuyDZ-ukt4YRg")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Other Business Parties")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public OtherParties35? OtherBusinessParties { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public OtherParties35? OtherBusinessParties { get; init; } 
        #else
        public OtherParties35? OtherBusinessParties { get; set; } 
        #endif
        
        /// <summary>
        /// Provides information required for the registration or physical settlement.
        /// </summary>
        [IsoId("_a76DrSAdEeuyDZ-ukt4YRg")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Additional Physical Or Registration Details")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public RegistrationParameters7? AdditionalPhysicalOrRegistrationDetails { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public RegistrationParameters7? AdditionalPhysicalOrRegistrationDetails { get; init; } 
        #else
        public RegistrationParameters7? AdditionalPhysicalOrRegistrationDetails { get; set; } 
        #endif
        
        /// <summary>
        /// Additional information that cannot be captured in the structured elements and/or any other specific block.
        /// </summary>
        [IsoId("_a76DryAdEeuyDZ-ukt4YRg")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Supplementary Data")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public SupplementaryData1? SupplementaryData { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public SupplementaryData1? SupplementaryData { get; init; } 
        #else
        public SupplementaryData1? SupplementaryData { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
