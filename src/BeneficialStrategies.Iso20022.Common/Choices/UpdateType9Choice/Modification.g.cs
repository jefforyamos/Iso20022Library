﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Modification.  ISO2002 ID# _nWE8rQ0BEeKd14R19frrfQ.
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
namespace BeneficialStrategies.Iso20022.Choices.UpdateType9Choice
{
    /// <summary>
    /// Modification of information in the securities transaction.
    /// </summary>
    [IsoId("_nWE8rQ0BEeKd14R19frrfQ")]
    [DisplayName("Modification")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Modification : UpdateType9Choice_
    #else
    public partial class Modification : UpdateType9Choice_
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
        [IsoId("_1V9X4Q0BEeKd14R19frrfQ")]
        [DisplayName("Settlement Type And Additional Parameters")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="SttlmTpAndAddtlParams")]
        #endif
        [IsoXmlTag("SttlmTpAndAddtlParams")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public SettlementTypeAndAdditionalParameters5? SettlementTypeAndAdditionalParameters { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public SettlementTypeAndAdditionalParameters5? SettlementTypeAndAdditionalParameters { get; init; } 
        #else
        public SettlementTypeAndAdditionalParameters5? SettlementTypeAndAdditionalParameters { get; set; } 
        #endif
        
        /// <summary>
        /// Link to another transaction that must be processed after, before or at the same time.
        /// </summary>
        [IsoId("_1V9X5Q0BEeKd14R19frrfQ")]
        [DisplayName("Linkages")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Lnkgs")]
        #endif
        [IsoXmlTag("Lnkgs")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public Linkages1? Linkages { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public Linkages1? Linkages { get; init; } 
        #else
        public Linkages1? Linkages { get; set; } 
        #endif
        
        /// <summary>
        /// Details of the trade.
        /// </summary>
        [IsoId("_1V9X6Q0BEeKd14R19frrfQ")]
        [DisplayName("Trade Details")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="TradDtls")]
        #endif
        [IsoXmlTag("TradDtls")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public SecuritiesTradeDetails26? TradeDetails { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public SecuritiesTradeDetails26? TradeDetails { get; init; } 
        #else
        public SecuritiesTradeDetails26? TradeDetails { get; set; } 
        #endif
        
        /// <summary>
        /// Financial instrument representing a sum of rights of the investor vis-a-vis the issuer.
        /// </summary>
        [IsoId("_1V9X7Q0BEeKd14R19frrfQ")]
        [DisplayName("Financial Instrument Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="FinInstrmId")]
        #endif
        [IsoXmlTag("FinInstrmId")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public SecurityIdentification14? FinancialInstrumentIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public SecurityIdentification14? FinancialInstrumentIdentification { get; init; } 
        #else
        public SecurityIdentification14? FinancialInstrumentIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Attributes defining a financial instrument.
        /// </summary>
        [IsoId("_1V9X8Q0BEeKd14R19frrfQ")]
        [DisplayName("Financial Instrument Attributes")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="FinInstrmAttrbts")]
        #endif
        [IsoXmlTag("FinInstrmAttrbts")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public FinancialInstrumentAttributes35? FinancialInstrumentAttributes { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public FinancialInstrumentAttributes35? FinancialInstrumentAttributes { get; init; } 
        #else
        public FinancialInstrumentAttributes35? FinancialInstrumentAttributes { get; set; } 
        #endif
        
        /// <summary>
        /// Details related to the account and quantity involved in the transaction.
        /// </summary>
        [IsoId("_1V9X9Q0BEeKd14R19frrfQ")]
        [DisplayName("Quantity And Account Details")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="QtyAndAcctDtls")]
        #endif
        [IsoXmlTag("QtyAndAcctDtls")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public QuantityAndAccount30? QuantityAndAccountDetails { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public QuantityAndAccount30? QuantityAndAccountDetails { get; init; } 
        #else
        public QuantityAndAccount30? QuantityAndAccountDetails { get; set; } 
        #endif
        
        /// <summary>
        /// Parameters which explicitly state the conditions that must be fulfilled before a particular transaction of a financial instrument can be settled. These parameters are defined by the instructing party in compliance with settlement rules in the market the transaction will settle in.
        /// </summary>
        [IsoId("_1V9X-Q0BEeKd14R19frrfQ")]
        [DisplayName("Settlement Parameters")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="SttlmParams")]
        #endif
        [IsoXmlTag("SttlmParams")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public SettlementDetails50? SettlementParameters { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public SettlementDetails50? SettlementParameters { get; init; } 
        #else
        public SettlementDetails50? SettlementParameters { get; set; } 
        #endif
        
        /// <summary>
        /// Specifies what settlement standing instruction database is to be used to derive the settlement parties involved in the transaction.
        /// </summary>
        [IsoId("_1V9X_Q0BEeKd14R19frrfQ")]
        [DisplayName("Standing Settlement Instruction Details")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="StgSttlmInstrDtls")]
        #endif
        [IsoXmlTag("StgSttlmInstrDtls")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public StandingSettlementInstruction4? StandingSettlementInstructionDetails { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public StandingSettlementInstruction4? StandingSettlementInstructionDetails { get; init; } 
        #else
        public StandingSettlementInstruction4? StandingSettlementInstructionDetails { get; set; } 
        #endif
        
        /// <summary>
        /// Identifies the chain of delivering settlement parties.
        /// </summary>
        [IsoId("_1V9YAQ0BEeKd14R19frrfQ")]
        [DisplayName("Delivering Settlement Parties")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="DlvrgSttlmPties")]
        #endif
        [IsoXmlTag("DlvrgSttlmPties")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public SettlementParties11? DeliveringSettlementParties { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public SettlementParties11? DeliveringSettlementParties { get; init; } 
        #else
        public SettlementParties11? DeliveringSettlementParties { get; set; } 
        #endif
        
        /// <summary>
        /// Identifies the chain of receiving settlement parties.
        /// </summary>
        [IsoId("_1V9YBQ0BEeKd14R19frrfQ")]
        [DisplayName("Receiving Settlement Parties")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="RcvgSttlmPties")]
        #endif
        [IsoXmlTag("RcvgSttlmPties")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public SettlementParties11? ReceivingSettlementParties { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public SettlementParties11? ReceivingSettlementParties { get; init; } 
        #else
        public SettlementParties11? ReceivingSettlementParties { get; set; } 
        #endif
        
        /// <summary>
        /// Cash parties involved in the transaction if different for the securities settlement parties.
        /// </summary>
        [IsoId("_1V9YCQ0BEeKd14R19frrfQ")]
        [DisplayName("Cash Parties")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CshPties")]
        #endif
        [IsoXmlTag("CshPties")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public CashParties17? CashParties { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CashParties17? CashParties { get; init; } 
        #else
        public CashParties17? CashParties { get; set; } 
        #endif
        
        /// <summary>
        /// Total amount of money to be paid or received in exchange for the securities.
        /// </summary>
        [IsoId("_1V9YDQ0BEeKd14R19frrfQ")]
        [DisplayName("Settlement Amount")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="SttlmAmt")]
        #endif
        [IsoXmlTag("SttlmAmt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public AmountAndDirection32? SettlementAmount { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public AmountAndDirection32? SettlementAmount { get; init; } 
        #else
        public AmountAndDirection32? SettlementAmount { get; set; } 
        #endif
        
        /// <summary>
        /// Other amounts than the settlement amount.
        /// </summary>
        [IsoId("_1V9YEQ0BEeKd14R19frrfQ")]
        [DisplayName("Other Amounts")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="OthrAmts")]
        #endif
        [IsoXmlTag("OthrAmts")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public OtherAmounts14? OtherAmounts { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public OtherAmounts14? OtherAmounts { get; init; } 
        #else
        public OtherAmounts14? OtherAmounts { get; set; } 
        #endif
        
        /// <summary>
        /// Other business parties relevant to the transaction.
        /// </summary>
        [IsoId("_1V9YFQ0BEeKd14R19frrfQ")]
        [DisplayName("Other Business Parties")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="OthrBizPties")]
        #endif
        [IsoXmlTag("OthrBizPties")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public OtherParties19? OtherBusinessParties { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public OtherParties19? OtherBusinessParties { get; init; } 
        #else
        public OtherParties19? OtherBusinessParties { get; set; } 
        #endif
        
        /// <summary>
        /// Provides information required for the registration or physical settlement.
        /// </summary>
        [IsoId("_1V9YGQ0BEeKd14R19frrfQ")]
        [DisplayName("Additional Physical Or Registration Details")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="AddtlPhysOrRegnDtls")]
        #endif
        [IsoXmlTag("AddtlPhysOrRegnDtls")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public RegistrationParameters1? AdditionalPhysicalOrRegistrationDetails { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public RegistrationParameters1? AdditionalPhysicalOrRegistrationDetails { get; init; } 
        #else
        public RegistrationParameters1? AdditionalPhysicalOrRegistrationDetails { get; set; } 
        #endif
        
        /// <summary>
        /// Additional information that cannot be captured in the structured elements and/or any other specific block.
        /// </summary>
        [IsoId("_1V9YHQ0BEeKd14R19frrfQ")]
        [DisplayName("Supplementary Data")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="SplmtryData")]
        #endif
        [IsoXmlTag("SplmtryData")]
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
